namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karar Yapilari!");
            /*Console.WriteLine("Bir Sayı Giriniz:");
            var sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)//eğer sayı 0 dan büyükse
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else if (sayi < 0) // değilse eğer sayı 0 dan küçükse
            {
                Console.WriteLine("Sayı Negatif");
            }
            else
            {
                Console.WriteLine("Sayı Sıfır");
            }

            Console.WriteLine("Kullanıcı Adınızı Giriniz:");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi Giriniz:");
            string sifre = Console.ReadLine();

            string veritabanindakiKullaniciAdi = "admin";
            string veritabanindakiSifre = "123456";

            if (kullaniciAdi == veritabanindakiKullaniciAdi && sifre == veritabanindakiSifre)
            {
                Console.WriteLine("Giriş Başarılı!");
            }            
            else
            {
                Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı!");
            }

            int saat = DateTime.Now.Hour; // bulunduğumuz saat bilgisini sistemden aldık
            if (saat < 18) // eğer saat 18 den küçükse
            {
                Console.WriteLine("İyi günler. Saat : " + saat);
            }
            else
                Console.WriteLine("İyi Akşamlar. Saat : " + saat);

            Console.WriteLine("Ternary operatörü");

            Console.WriteLine((saat < 18) ? "İyi günler. Saat : " + saat : "İyi Akşamlar. Saat : " + saat);
            */
            Console.WriteLine("switch case yapısı ile akış kontrolü");
            int ay = DateTime.Now.Month;//Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bulunduğumuz Ay : " + ay);
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimi");
                    Console.WriteLine();
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimi");
                    Console.WriteLine();
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimi");
                    Console.WriteLine();
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimi");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Hata Oluştu!");
                    break;
            }
        }
    }
}
