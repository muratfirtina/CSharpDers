using System;
namespace Methods
{
    public class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Adi);
        }


        //hatalı kullanım
        public void Ekle2(string urunAdi,double fiyat, string aciklama)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}

