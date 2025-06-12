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
        internal Urun[] Urunler()
        {
            return new Urun[] {
                new() {
                    Adi = "Bilgisayar",
                    Durum = false,
                    Fiyati = 42000,
                    Id = 1,
                    Markasi = "Monster",
                    UrunAciklamasi = "Oyun bilgisayarı"
                },
                new() {
                    Adi = "Laptop",
                    Durum = true,
                    Fiyati = 48000,
                    Id = 2,
                    Markasi = "Monster",
                    UrunAciklamasi = "Oyun bilgisayarı"
                },
                new() {
                    Adi = "Telefon",
                    Durum = true,
                    Fiyati = 58000,
                    Id = 3,
                    Markasi = "Ayfon",
                    UrunAciklamasi = "Cep telefonu"
                }
            };
        }
    }
}
