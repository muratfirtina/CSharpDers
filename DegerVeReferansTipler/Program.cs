// See https://aka.ms/new-console-template for more information
int sayi1 = 10;
int sayi2 = 30;

sayi1 = sayi2;
sayi2 = 65;

//int değer tip olduğu için
//sayi1 ilk sayı2 ye eşitlendi 2.ye değil
Console.WriteLine(sayi1);



// array değer tip i referans tipe dönüştüğü için 
int[] sayilar1 = new int[] {10 , 20, 30 };
int[] sayilar2 = new int[] { 100, 200, 300 };

sayilar1 = sayilar2;
sayilar2[0] = 999;

Console.WriteLine(sayilar1[0]);




