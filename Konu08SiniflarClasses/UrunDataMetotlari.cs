namespace Konu08SiniflarClasses
{
    public class UrunDataMetotlari
    {
        internal void UrunEkle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " ürünü eklendi!");
        }
        internal void UrunGuncelle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " ürünü güncellendi!");
        }
        internal void UrunSil(Urun urun)
        {
            Console.WriteLine(urun.Adi + " ürünü silindi!");
        }
        internal Urun UrunGetir()
        {
            Urun urun = new Urun()
            {
                Adi = "Tv",
                Durum = true,
                Fiyati = 3333
            };
            return urun;
        }
    }
}
