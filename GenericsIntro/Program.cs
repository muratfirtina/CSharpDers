using GenericsIntro;

MyList<string> isimler = new MyList<string>();
isimler.Add("Murat");
isimler.Add("Murat");
isimler.Add("Murat");
isimler.Add("Murat");
Console.WriteLine(isimler.Count);

MyDictionary<int, string> sehirler = new MyDictionary<int, string>();

sehirler.Add(34, "İstanbul");
sehirler.Add(07, "Antalya");
sehirler.Add(35, "İzmir");
sehirler.Add(06, "Ankara");
sehirler.Add(23, "Elazığ");
sehirler.Add(69, "Bayburt");

Console.WriteLine(sehirler.Count);

Console.WriteLine("Şehirler : ");
for (int i = 0; i < sehirler.Count; i++)
{
    Console.WriteLine("Plaka Kodu:"+ sehirler.Keys[i]+  " " +"Şehir Adı :"+ " " + sehirler.Values[i]);
}

sehirler.GetList();


