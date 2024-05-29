# gorsel-tatanka

Uygulanması gereken adımlar:

1: Hastane Uygulaması/Debug Klasöründen setup kurulumu gerçekleştirniz.
2: Programa girilirken veri tabanına Microsoft.ace.oledb 12 hatası sebebi ile erişilememektedir. Bu yüzden AccessDatabaseEngine programının kurulumu yapılması gerekmektedir.
3: AccessDatabaseEngine kurulumu gerçekleştirildikten sonra programa giriş sağlanıcaktır. Veri tabanı erişebilir duruma geçicektir ancak program yönetici izinleriyle çalıştırılmadığı takdirde veri tabanı read-only modunda olacaktır ve yeni veri girişini kabul etmeyecektir.
4: Program içerisinde T.C. kimlik no, telefon ve e-mail pattern kontrolü yapılmaktadır. Bu sebepten giriş için önceden kişiler tanıtılmıştır.
    
    Doktor giriş bilgileri:
        Doktor_1:
            T.C.: 11111111110
            Şifre: 11
        Doktro_2:
            T.C.: 22222222220
            Şifre: 22

    Sekreter giriş bilgileri:
        Sekreter_1:
            T.C.: 33333333330
            Şifre: 33
        Sekreter_2:
            T.C.: 44444444440
            Şifre: 44

    Hasta bilgileri:
        Hasta_1:
            T.C.: 55555555550
        Hasta_2:
            T.C.: 66666666660

5: T.C. kimlik kontrolü gerçek hayat kontrolü sağlandığı için deneme amaçlı olarak aşşağıda bulunan T.C. kimlik numaraları kullanılabilir.
    77777777770
    88888888880
    99999999990