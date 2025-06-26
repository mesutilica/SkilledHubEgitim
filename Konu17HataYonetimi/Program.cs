using ClassLibrary1;

namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hata Yonetimi!");
            Console.WriteLine();
            Console.WriteLine("Kdv Hesaplamak İçin Fiyat Giriniz :");
            var sayi = Console.ReadLine();
            // KdvHesapla(int.Parse(sayi));
            try
            {
                KdvHesapla(int.Parse(sayi)); // kodları çalıştırmayı dene
            }
            catch (Exception hata) // Exception a hata ismini verdik, bu bize oluşan hatayı verir.
            {
                Console.WriteLine("Hata Oluştu! Lütfen sadece sayısal değer giriniz!");
                // throw; // bu yine hata fırlatır
                // oluşana hatayı loglayabiliriz
                Console.WriteLine(hata.Message);
            }
            finally
            {
                Console.WriteLine("try catch bloğundan sonra her seferinde çalışmasını istediğimiz bir işlem varsa bu blokta çalıştırabiliriz. Kullanımı zorunlu değildir.");
                Console.WriteLine("Bir sayı giriniz :");
                var sayi2 = Console.ReadLine();
                KdvHesapla(double.Parse(sayi2));
            }

            Category category = new Category();
            category.Name = "Elektronik";
            Console.WriteLine(category.Name);

            Console.WriteLine();

            Product product = new Product();
            product.Name = "Oyun Bilgisayarı";
            Console.WriteLine("Ürün Adı:");
            Console.WriteLine(product.Name);

        }
        static void KdvHesapla(double fiyat)
        {
            Console.WriteLine("Fiyat : " + fiyat);
            Console.WriteLine("Kdv : " + (fiyat * 0.20));
            Console.WriteLine("Kdv Dahil Toplam Tutar :" + (fiyat + (fiyat * 0.20)));
        }
    }
}
