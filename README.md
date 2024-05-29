# Hastane Uygulaması Kurulum ve Kullanım Kılavuzu

Bu doküman, Hastane Uygulaması'nın kurulumu ve kullanımı ile ilgili adımları detaylı bir şekilde açıklamaktadır.

## 1. Setup Kurulumu

Öncelikle, **Hastane Uygulaması** klasöründe yer alan **Debug** klasöründen setup dosyasını çalıştırarak kurulumu gerçekleştiriniz.

## 2. AccessDatabaseEngine Kurulumu

Programa giriş yaparken "Microsoft.ACE.OLEDB.12.0" hatası ile karşılaşabilirsiniz. Bu hata, veri tabanına erişim sorunu yaşandığını gösterir. Bu nedenle, proje dosyalarında **AccessDatabaseEngine** programını kurmanız gerekmektedir.

## 3. Programın Yönetici İzinleri ile Çalıştırılması

AccessDatabaseEngine kurulumunu tamamladıktan sonra, programa giriş yapabilirsiniz. Ancak, program yönetici izinleriyle çalıştırılmadığı takdirde veri tabanı yalnızca "read-only" modunda olacaktır. Bu durumda, yeni veri girişi yapılamaz. Yönetici izinleriyle programı çalıştırmayı unutmayınız.

## 4. Kullanıcı Giriş Bilgileri

Program içerisinde T.C. kimlik numarası, telefon ve e-mail gibi bilgilerin pattern kontrolü yapılmaktadır. Bu sebepten ötürü, giriş için önceden tanımlanmış kullanıcı bilgilerini kullanabilirsiniz.

### Doktor Giriş Bilgileri

- **Doktor_1**
  - T.C.: 11111111110
  - Şifre: 11

- **Doktor_2**
  - T.C.: 22222222220
  - Şifre: 22

### Sekreter Giriş Bilgileri

- **Sekreter_1**
  - T.C.: 33333333330
  - Şifre: 33

- **Sekreter_2**
  - T.C.: 44444444440
  - Şifre: 44

### Hasta Bilgileri

- **Hasta_1**
  - T.C.: 55555555550

- **Hasta_2**
  - T.C.: 66666666660

## 5. Test Amaçlı T.C. Kimlik Numaraları

T.C. kimlik numarası kontrolü gerçek hayattaki gibi yapılmaktadır. Deneme amaçlı olarak aşağıdaki T.C. kimlik numaralarını kullanabilirsiniz:

- 77777777770
- 88888888880
- 99999999990

Bu adımları takip ederek Hastane Uygulaması'nı sorunsuz bir şekilde kurabilir ve kullanabilirsiniz.
