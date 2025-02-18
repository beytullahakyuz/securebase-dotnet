## TR

SecureBase kütüphanesi standart base64 algoritmasına ek olarak gizli anahtar seçeneği sunmaktadır. Böylelikle kütüphaneyi kullanan projelere özgü base64 işlemi gerçekleşir. Her projenin gizli anahtarı farklı olacağından oluşan base64 çıktısıda gizli anahtara bağlı olarak değişir.

## Hedef

Standart base64 kodlaması birçok projede kullanılmaktadır ve olası veri sızıntılarında kullanıcı verileri (fotoğraf, kimlik, vb.) base64 ile kodlandığından kolaylıkla açığa çıkabilmektedir. SecureBase burada devreye girerek kodlamanın çözümlenmesini zorlaştırmaktadır ve base64 ile kodlandığını gizlemektedir.

## Kullanım/Örnek

```javascript
SecureBase bs = new SecureBase();
bs.SetSecretKey(secretkey);

//Text to Base64
string encodeddata = bs.Encode(data);

//Base64 to Text
string decodeddata = bs.Decode(data);
```

### Notlar
**Demos/SecureBaseApp** klasöründen demo projeye erişebilirsiniz.
Encoding: **Unicode

## Ekran Görüntüleri

Kodlama (Farklı gizli anahtarlarla)
![Kodlama](https://github.com/beytullahakyuz/securebase-dotnet/blob/main/screenshots/tr_1.png)
![Kodlama](https://github.com/beytullahakyuz/securebase-dotnet/blob/main/screenshots/tr_2.png)

Kod çözme
![Kod çözme](https://github.com/beytullahakyuz/securebase-dotnet/blob/main/screenshots/tr_1_decoding.png)
![Kod çözme](https://github.com/beytullahakyuz/securebase-dotnet/blob/main/screenshots/tr_2_decoding.png)


## Yükleme 

[Nuget Gallery](https://www.nuget.org/packages/SecureBase/)

Güncelleme Notları - v1.3
+ Demo uygulaması güncellendi.
+ SetSecretKey fonksiyonu eklendi.
+ Encode ve Decode overload fonksiyonları eklendi. (byte[])

Güncelleme Notları - v1.2
+ Unicode desteği eklendi.


## EN

The SecureBase library offers a secret key option in addition to the standard base64 algorithm. Since the secret key will be different in each project, the base64 output will also vary depending on the secret key.

## Goal

Standard base64 encoding is used in many projects, and in case of possible data leaks, user data (photo, identity, etc.) can be easily exposed because it is encoded with base64. This is where SecureBase comes into play, making the encoding harder to decipher and hiding the fact that it is base64 encoded.

## Using/Example

```javascript
SecureBase bs = new SecureBase();
bs.SetSecretKey(secretkey);

//Text to Base64
string encodeddata = bs.Encode(data);

//Base64 to Text
string decodeddata = bs.Decode(data);

```

### Notes
You can access demo projet from **demos/SecureBaseApp** klasöründen folder.
Encoding: **Unicode

## Screenshots

Encoding (Different secret keys)
![Encoding](https://github.com/beytullahakyuz/securebase-dotnet/blob/main/screenshots/en_1.png)
![Encoding](https://github.com/beytullahakyuz/securebase-dotnet/blob/main/screenshots/en_2.png)

Decoding
![Decoding](https://github.com/beytullahakyuz/securebase-dotnet/blob/main/screenshots/en_1_decoding.png)
![Decoding](https://github.com/beytullahakyuz/securebase-dotnet/blob/main/screenshots/en_2_decoding.png)


## Installation 

[Nuget Gallery](https://www.nuget.org/packages/SecureBase/)

Update Notes - v1.3
+ Updated demo application.
+ Added SetSecretKey function.
+ Added Encode and Decode overload functions. (byte[])

Update Notes - v1.2
+ Added unicode support.

