using PolymorphysmOOP;
using PolymorphysmOOP.Şekiller;

Ucgen ucgen1 = new Ucgen(15, 5);


Kare kare1 = new Kare(30, 30);


Dikdortgen dikdortgen1 = new Dikdortgen(40, 5); 


double ucgenAlan = ucgen1.AlanHesapla(15, 5);

double kareAlan = kare1.AlanHesapla(30, 30);

double dikdortgenAlan = dikdortgen1.AlanHesapla(40, 5);

Console.WriteLine($"Karenin alanı : {kareAlan}\n\nDikdörtgen Alanı : {dikdortgenAlan}\n\nÜçgen Alanı : {ucgenAlan}");
