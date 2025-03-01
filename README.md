## EN

The SecureBase library offers a secret key option in addition to the standard base64 algorithm. Since the secret key will be different in each project, the base64 output will also vary depending on the secret key.

For detailed information, please review the source below.

[SecureBase Wiki](https://beytullahakyuz.gitbook.io/securebase)

## Using/Example

```csharp
//SecureBase.SBEncoding sbencoding = SecureBase.SBEncoding.UNICODE;
SecureBase.SBEncoding sbencoding = SecureBase.SBEncoding.UTF8;

SecureBase bs = new SecureBase(sbencoding);
bs.SetSecretKey(secretkey);

//Encoding
string encodeddata = bs.Encode(data);

//Decoding
string decodeddata = bs.Decode(data);
```

## Screenshots

Encoding (Different secret keys)
![Encoding](https://github.com/beytullahakyuz/assets/blob/main/securebase-dotnet/en_1.png)
![Encoding](https://github.com/beytullahakyuz/assets/blob/main/securebase-dotnet/en_2.png)

Decoding
![Decoding](https://github.com/beytullahakyuz/assets/blob/main/securebase-dotnet/en_1_decoding.png)
![Decoding](https://github.com/beytullahakyuz/assets/blob/main/securebase-dotnet/en_2_decoding.png)


## Installation 

[Nuget Gallery](https://www.nuget.org/packages/SecureBase/)

## TR

SecureBase kütüphanesi standart base64 algoritmasına ek olarak gizli anahtar seçeneği sunmaktadır. Böylelikle kütüphaneyi kullanan projelere özgü base64 işlemi gerçekleşir. Her projenin gizli anahtarı farklı olacağından oluşan base64 çıktısıda gizli anahtara bağlı olarak değişir.

Detaylı bilgi için aşağıdaki kaynağı inceleyiniz.

[SecureBase Wiki](https://beytullahakyuz.gitbook.io/securebase)

## Kullanım/Örnek

```csharp
//SecureBase.SBEncoding sbencoding = SecureBase.SBEncoding.UNICODE;
SecureBase.SBEncoding sbencoding = SecureBase.SBEncoding.UTF8;

SecureBase bs = new SecureBase(sbencoding);
bs.SetSecretKey(secretkey);

//Encoding
string encodeddata = bs.Encode(data);

//Decoding
string decodeddata = bs.Decode(data);
```

## Ekran Görüntüleri

Kodlama (Farklı gizli anahtarlarla)
![Kodlama](https://github.com/beytullahakyuz/assets/blob/main/securebase-dotnet/tr_1.png)
![Kodlama](https://github.com/beytullahakyuz/assets/blob/main/securebase-dotnet/tr_2.png)

Kod çözme
![Kod çözme](https://github.com/beytullahakyuz/assets/blob/main/securebase-dotnet/tr_1_decoding.png)
![Kod çözme](https://github.com/beytullahakyuz/assets/blob/main/securebase-dotnet/tr_1_decoding.png)


## Yükleme 

[Nuget Gallery](https://www.nuget.org/packages/SecureBase/)