namespace Konu05Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metotlar!");
            Console.WriteLine();
            Console.Beep(); // bip sesi çıkar
            //Console.BackgroundColor = ConsoleColor.Green;
            ToplamaYap(); // Metot çağrısı olmadan ekrana yazdırmaz
            ToplamaYap(50, 8);
            Console.WriteLine("Geriye değer döndüren metot:");
            int sonuc = ToplamaYap(10, 20, 30); // Metot çağrısı ile geriye değer döndürülür
            Console.WriteLine("Sonuç: " + sonuc);
            /*
            Console.WriteLine("Lütfen mail adresinizi giriniz");
            var email = Console.ReadLine();
            if (MailGonder(email) == false)
            {
                Console.WriteLine("Mail Adresi Boş Geçilemez!");
            }
            else 
                Console.WriteLine("Mail kabul edildi!");
            */
            // KdvHesapla();
            MatematikselMetotlar();
        }

        #region ToplamaYapMetotları
        static void ToplamaYap()
        {
            Console.WriteLine(10 + 8);
        }
        static void ToplamaYap(int sayi1, int sayi2)
        {
            //void olan metotlar geriye değer döndürmeyen metotlardır
            // Aynı isimde metotlar farklı parametrelerle kullanılırsa buna overloading-aşırı yükleme denir.
            //Metot kullanımında kullanılan parametreler(sayi1, sayi2) metodun kullanıldığı yerde metoda gönderilmek zorundadır, aksi halde program hata verir
            Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
        }
        static int ToplamaYap(int sayi1, int sayi2, int sayi3)
        {
            //Geriye değer döndüren metotlarda metot isminin önüne metodun geriye döndüreceği veri türü yazılır
            //metodun aldığı parametre ile geri dönüş veri türü aynı olmak zorunda DEĞİLDİR!
            //Yani bir metot parametre olarak int alırken geriye string, bool vb veri türü döndürebilir!
            return sayi1 + sayi2 + sayi3; // int olan metotlar geriye değer döndürür, return ile değer döndürülür
        }
        #endregion

        static bool MailGonder(string mailAdresi)
        {
            if (!string.IsNullOrWhiteSpace(mailAdresi))//Eğer mailAdresi değişkenine bir değer girilmişse, yani mail adresi boş değilse
            {
                return true;//geriye true değeri döndür
            }
            else 
                return false;//mailAdresi değişkeni boşsa geriye false döndür
        }
        static void KdvHesapla()
        {
            double fiyat, kdv, toplam;
            Console.WriteLine("Ürün fiyatını giriniz:");
            fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kdv miktarını giriniz:");
            var kdvMiktari = Convert.ToDouble(Console.ReadLine());
            kdv = fiyat * kdvMiktari / 100;
            toplam = fiyat + kdv;
            Console.WriteLine("Ürün kdv tutarı: " + kdv + " TL");
            Console.WriteLine("Kdv dahil fiyatı : " + toplam + " TL");
        }
        static void MatematikselMetotlar()
        {
            // belirli matematiksel işlemleri yapan bazı metotlar
            int max = Math.Max(10, 34); // x ve y sayılarının en büyüğünü tutar.
            int min = Math.Min(10, 34); // x ve y sayılarının en küçüğünü tutar.

            double c = Math.Ceiling(12.67); //x sayısından büyük en küçük tam sayıyı tutar (yukarı yuvarlama).
            double d = Math.Floor(12.67); //x sayısından küçük en büyük tam sayıyı tutar (aşağı yuvarlama).
            Console.WriteLine("Max:" + max + " min:" + min + " Ceiling:" + c + " Floor:" + d);
        }
    }
}
