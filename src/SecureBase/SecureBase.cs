using System.Text;
using System.Security.Cryptography;

public class SecureBase : IDisposable
{

    public enum SBEncoding{
        UNICODE,
        UTF8
    }

    const string defcharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!\"#&'()*,-.:;<>?@[]\\^_{}|~/+=";
    const string base64standart = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
    string globalcharset = string.Empty;
    char padding;
    private bool disposed = false;
    SBEncoding GEncoding;

    public SecureBase(SBEncoding encoding) {
        globalcharset = base64standart;
        padding = '=';
        GEncoding = encoding;
    }

    public SecureBase(SBEncoding encoding, string secretkey) {
        SetSecretKey(secretkey);
        GEncoding = encoding;
    }

    public void SetSecretKey(string secretkey) {
        if (secretkey.Length != 0) {
            globalcharset = defcharset;
            pr_SuffleCharset(secretkey);
            padding = Convert.ToChar(globalcharset.Substring(64, 1));
            globalcharset = globalcharset.Substring(0, 64);
        } else {
            globalcharset = base64standart;
            padding = '=';
        }
    }

    public string Encode(string input) {
        if (GEncoding == SBEncoding.UNICODE)
            return new UnicodeEncoding(false, false).GetString(ProcessEncoding(new UnicodeEncoding(false, false).GetBytes(input)));
        else
            return new UTF8Encoding().GetString(ProcessEncoding(new UTF8Encoding().GetBytes(input)));
    }

    public string Decode(string input) {
        if (GEncoding == SBEncoding.UNICODE)
            return new UnicodeEncoding(false, false).GetString(ProcessDecoding(input));
        else
            return new UTF8Encoding().GetString(ProcessDecoding(input));
    }

    private byte[] ProcessEncoding(byte[] input) {
        try {
            char[] baseArray = globalcharset.ToCharArray();
            byte[] pdata = input;
            char[] encodedData = new char[0];
            if (pdata.Length > 0) {
                int length = pdata.Length;
                int lengthDiv3 = length / 3;
                int remainder = length % 3;
                int encodedLength = (lengthDiv3 * 4) + (remainder == 0 ? 0 : 4);
                encodedData = new char[encodedLength];
                int dataIndex = 0;
                int encodedIndex = 0;
                for (int i = 0; i < lengthDiv3; i++) {
                    int chunk = (pdata[dataIndex++] << 16) | (pdata[dataIndex++] << 8) | pdata[dataIndex++];
                    encodedData[encodedIndex++] = baseArray[(chunk >> 18) & 63];
                    encodedData[encodedIndex++] = baseArray[(chunk >> 12) & 63];
                    encodedData[encodedIndex++] = baseArray[(chunk >> 6) & 63];
                    encodedData[encodedIndex++] = baseArray[chunk & 63];
                }
                if (remainder == 1) {
                    int lastByte = pdata[dataIndex];
                    encodedData[encodedIndex++] = baseArray[lastByte >> 2];
                    encodedData[encodedIndex++] = baseArray[((lastByte & 3) << 4)];
                    encodedData[encodedIndex++] = padding;
                    encodedData[encodedIndex++] = padding;
                } else if (remainder == 2) {
                    int secondLastByte = pdata[dataIndex++];
                    int lastByte = pdata[dataIndex];
                    encodedData[encodedIndex++] = baseArray[secondLastByte >> 2];
                    encodedData[encodedIndex++] = baseArray[((secondLastByte & 3) << 4) | (lastByte >> 4)];
                    encodedData[encodedIndex++] = baseArray[(lastByte & 15) << 2];
                    encodedData[encodedIndex++] = padding;
                }
            }
            if (GEncoding == SBEncoding.UNICODE)
                return new UnicodeEncoding(false, false).GetBytes(encodedData);
            else
                return new UTF8Encoding().GetBytes(encodedData);
        }
        catch (Exception) {
            throw new Exception("Invalid data or secret key!");
        }
    }

    private byte[] ProcessDecoding(string input) {
        try {
            char[] baseArray = globalcharset.ToCharArray();
            byte[] decodedData = new byte[0];
            if (input.Length > 0) {
                byte[] base64Values = new byte[256];
                for (int i = 0; i < 64; i++) {
                    base64Values[baseArray[i]] = (byte)i;
                }
                int length = input.Length;
                int paddingCount = 0;
                if (length > 0 && input[length - 1] == padding) {
                    paddingCount++;
                }
                if (length > 1 && input[length - 2] == padding) {
                    paddingCount++;
                }
                int decodedLength = (length * 3) / 4 - paddingCount;
                decodedData = new byte[decodedLength];
                int encodedIndex = 0;
                int decodedIndex = 0;
                while (encodedIndex < length) {
                    int chunk = (base64Values[input[encodedIndex++]] << 18) |
                                (base64Values[input[encodedIndex++]] << 12) |
                                (base64Values[input[encodedIndex++]] << 6) |
                                base64Values[input[encodedIndex++]];
                    decodedData[decodedIndex++] = (byte)((chunk >> 16) & 255);
                    if (decodedIndex < decodedLength) {
                        decodedData[decodedIndex++] = (byte)((chunk >> 8) & 255);
                    }
                    if (decodedIndex < decodedLength) {
                        decodedData[decodedIndex++] = (byte)(chunk & 255);
                    }
                }
            }
            return decodedData;
        }
        catch (Exception ex) {
            throw new Exception(ex.Message);
        }
    }
    
    private void pr_SuffleCharset(string secretkey) {
        string secrethash = string.Empty;
        secrethash = computeHash(secretkey, 512);
        globalcharset = fn_SuffleCharset(globalcharset, fn_CharacterSetSecretKey(secrethash));
    }

    private string computeHash(string s, int key) {
        Keccak keccak = new Keccak();
        byte[] input = System.Text.Encoding.UTF8.GetBytes(s);
        StringBuilder sb = new StringBuilder();
        byte[] hash = keccak.Hash(input, key);
        keccak.Dispose();
        return BitConverter.ToString(hash).Replace("-", "").ToLower();
    }

    private string fn_SuffleCharset(string data, int[] keys) {
        char[] karakterler = data.ToCharArray();
        int keylen = keys.Length;
        for (int j = 0; j < keylen - 1; j++) {
            for (int i = karakterler.Length - 1; i > 0; i--) {
                int x = (i * keys[j]) % karakterler.Length;
                char temp = karakterler[i];
                karakterler[i] = karakterler[x];
                karakterler[x] = temp;
            }
        }
        return new string(karakterler);
    }

    private int[] fn_CharacterSetSecretKey(string anahtar) {
        int[] arr = new int[anahtar.Length];
        for (int i = 0; i < anahtar.Length - 1; i++) {
            char c = anahtar[i];
            int hs = 0;
            hs = (hs * 31 + c) % int.MaxValue;
            arr[i] = hs;
        }
        return arr;
    }

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing) {
        if (!disposed) {
            disposed = true;
        }
    }
    ~SecureBase() {
        Dispose(false);
    }

}

