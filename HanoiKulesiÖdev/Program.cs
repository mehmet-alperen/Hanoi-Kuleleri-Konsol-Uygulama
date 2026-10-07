using System;
string[] hamleler = new string[]
{
    "",
    "1.hamle Mavi disk 1.direkten 3.direğe alındı",
    "2.hamle Yeşil disk 1.direkten 2.direğe alındı",
    "3.hamle Mavi disk 3.direkten 2.direğe alındı",
    "4.hamle Sarı disk 1.direkten 3.direğe alındı",
    "5.hamle Mavi disk 2.direkten 1.direğe alındı",
    "6.hamle Yeşil disk 2.direkten 3.direğe alındı",
    "7.hamle Mavi disk 1.direkten 3.direğe alındı",
    "8.hamle Turuncu disk 1.direkten 2.direğe alındı",
    "9.hamle Mavi disk 3.direkten 2.direğe alındı",
    "10.hamle Yeşil disk 3.direkten 1.direğe alındı",
    "11.hamle Mavi disk 2.direkten 1.direğe alındı",
    "12.hamle Sarı disk 3.direkten 2.direğe alındı",
    "13.hamle Mavi disk 1.direkten 3.direğe alındı",
    "14.hamle Yeşil disk 1.direkten 2.direğe alındı",
    "15.hamle Mavi disk 3.direkten 2.direğe alındı",
    "16.hamle Kırmızı disk 1.direkten 3.direğe alındı",
    "17.hamle Mavi disk 2.direkten 1.direğe alındı",
    "18.hamle Yeşil disk 2.direkten 3.direğe alındı",
    "19.hamle Mavi disk 1.direkten 3.direğe alındı",
    "20.hamle Sarı disk 2.direkten 1.direğe alındı",
    "21.hamle Mavi disk 3.direkten 2.direğe alındı",
    "22.hamle Yeşil disk 3.direkten 1.direğe alındı",
    "23.hamle Mavi disk 2.direkten 1.direğe alındı",
    "24.hamle Turuncu disk 2.direkten 3.direğe alındı",
    "25.hamle Mavi disk 1.direkten 3.direğe alındı",
    "26.hamle Yeşil disk 1.direkten 2.direğe alındı",
    "27.hamle Mavi disk 3.direkten 2.direğe alındı",
    "28.hamle Sarı disk 1.direkten 3.direğe alındı",
    "29.hamle Mavi disk 2.direkten 1.direğe alındı",
    "30.hamle Yeşil disk 2.direkten 3.direğe alındı",
    "31.hamle Mavi disk 1.direkten 3.direğe alındı"
};
Console.WriteLine("Tüm adımları listelemek için: 0 yazın");
Console.WriteLine("Belirli bir adımı görmek için: 1 ile 31 arasında bir sayı yazın");
Console.Write("Seçiminiz: ");
int secim = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------------------------------------------------");
if (secim == 0)
{
    for (int i = 1; i <= 31; i++)
    {
        Console.WriteLine(hamleler[i]);
    }
}
else if (secim >= 1 && secim <= 31)
{
    Console.WriteLine(hamleler[secim]);
}
else
{
    Console.WriteLine("Hatalı giriş! Lütfen 0 ile 31 arasında bir değer giriniz.");
}
Console.WriteLine("-------------------------------------------------");
