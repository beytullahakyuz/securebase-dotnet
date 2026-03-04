using System;

public sealed class Keccak : IDisposable {
    private const int KeccakRounds = 24;
    private static readonly ulong[] RoundConstants = new ulong[KeccakRounds]
    {
            0x0000000000000001, 0x0000000000008082, 0x800000000000808A, 0x8000000080008000,
            0x000000000000808B, 0x0000000080000001, 0x8000000080008081, 0x8000000000008009,
            0x000000000000008A, 0x0000000000000088, 0x0000000080008009, 0x000000008000000A,
            0x000000008000808B, 0x800000000000008B, 0x8000000000008089, 0x8000000000008003,
            0x8000000000008002, 0x8000000000000080, 0x000000000000800A, 0x800000008000000A,
            0x8000000080008081, 0x8000000000008080, 0x0000000080000001, 0x8000000080008008
    };

    private static readonly int[] RhoOffsets = new int[25]
    {
            0, 1, 62, 28, 27,
            36, 44, 6, 55, 20,
            3, 10, 43, 25, 39,
            41, 45, 15, 21, 8,
            18, 2, 61, 56, 14
    };

    [ThreadStatic]
    private static ulong[] _threadState;

    private bool _disposed;

    public byte[] Hash(byte[] input, int outputLengthBits) {
        if (_disposed) throw new ObjectDisposedException("Object is disposed");

        InitializeThreadState();

        int rateInBytes = (1600 - 2 * outputLengthBits) / 8;
        byte[] paddedMessage = Pad(input, rateInBytes);
        Absorb(paddedMessage, rateInBytes);
        return Squeeze(outputLengthBits / 8);
    }

    private void InitializeThreadState() {
        if (_threadState == null) {
            _threadState = new ulong[25];
        } else {
            Array.Clear(_threadState, 0, _threadState.Length);
        }
    }

    private void Absorb(byte[] message, int rateInBytes) {
        int blockSize = rateInBytes;
        for (int offset = 0; offset < message.Length; offset += blockSize) {
            for (int i = 0; i < blockSize / 8; i++) {
                _threadState[i] ^= BitConverter.ToUInt64(message, offset + i * 8);
            }
            KeccakF();
        }
    }

    private byte[] Squeeze(int outputLength) {
        byte[] output = new byte[outputLength];
        int offset = 0;

        while (outputLength > 0) {
            int bytesToOutput = Math.Min(outputLength, 200);
            Buffer.BlockCopy(_threadState, 0, output, offset, bytesToOutput);

            offset += bytesToOutput;
            outputLength -= bytesToOutput;

            if (outputLength > 0) KeccakF();
        }

        return output;
    }

    private void KeccakF() {
        for (int round = 0; round < KeccakRounds; round++) {
            ulong[] C = new ulong[5];
            ulong[] D = new ulong[5];

            for (int i = 0; i < 5; i++) {
                C[i] = _threadState[i] ^ _threadState[i + 5] ^ _threadState[i + 10] ^ _threadState[i + 15] ^ _threadState[i + 20];
            }

            for (int i = 0; i < 5; i++) {
                D[i] = C[(i + 4) % 5] ^ Rol(C[(i + 1) % 5], 1);
            }

            for (int i = 0; i < 25; i += 5) {
                for (int j = 0; j < 5; j++) {
                    _threadState[i + j] ^= D[j];
                }
            }

            ulong[] B = new ulong[25];
            for (int i = 0; i < 25; i++) {
                B[i] = Rol(_threadState[i], RhoOffsets[i]);
            }

            for (int i = 0; i < 25; i += 5) {
                for (int j = 0; j < 5; j++) {
                    _threadState[i + j] = B[i + j] ^ (~B[i + ((j + 1) % 5)] & B[i + ((j + 2) % 5)]);
                }
            }

            _threadState[0] ^= RoundConstants[round];
        }
    }

    private static ulong Rol(ulong x, int n) {
        return (x << n) | (x >> (64 - n));
    }

    private static byte[] Pad(byte[] input, int rateInBytes) {
        int paddingLength = rateInBytes - (input.Length % rateInBytes);
        byte[] padded = new byte[input.Length + paddingLength];
        Array.Copy(input, padded, input.Length);
        padded[input.Length] = 0x06;
        padded[padded.Length - 1] |= 0x80;
        return padded;
    }

    public void Dispose() {
        if (!_disposed) {
            if (_threadState != null) {
                Array.Clear(_threadState, 0, _threadState.Length);
                _threadState = null;
            }
            _disposed = true;
        }
        GC.SuppressFinalize(this);
    }
}