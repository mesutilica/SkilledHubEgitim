namespace Konu12KalitimInheritance
{
    class Arac
    {
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Kornaya Basıldı!");
        }
    }
    class Otomobil : Arac // iki nokta üstü üste araç dediğimizde araç sınıfındaki içerikler otomobil sınıfında kullanılabilir.
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    class Yat : Arac
    {
        public int Uzunluk { get; set; }
        public int Kamara { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu12 Kalitim Inheritance!");
            Arac arac = new();
            arac.AracTuru = "Araba";
            Console.WriteLine("arac.AracTuru = " + arac.AracTuru);

            Otomobil otomobil = new();
            otomobil.AracTuru = "Otomobil"; // Normalde Otomobil classında AracTuru yok
            otomobil.Marka = "Togg";
            otomobil.Model = "T10X";
            Console.WriteLine("otombil.AracTuru : " + otomobil.AracTuru);
            otomobil.KornaCal(); // KornaCal metodu bir üst sınıf olan Arac sınıfından geliyor

            Console.WriteLine();

            Kategori kategori = new()
            {
                Name = "Elektronik",
                UstMenudeGoster = true,
                CreateDate = DateTime.Now
            };
            if (kategori.UstMenudeGoster == true)
            {
                Console.WriteLine($"kategori bilgileri :\n Adı : {kategori.Name} - Eklenme Tarihi : {kategori.CreateDate}");
            }

            Console.WriteLine();

            Urun urun = new()
            {
                Name = "Klavye",
                Fiyat = 299,
                Kdv = 18,
                CreateDate = DateTime.Now
            };
            Console.WriteLine("Ürün Bilgileri");
            Console.WriteLine($"Adı: {urun.Name}");
            Console.WriteLine($"Fiyat: {urun.Fiyat}");
            Console.WriteLine($"Kdv: {urun.Kdv}");
            Console.WriteLine($"Eklenme Tarihi: {urun.CreateDate}");

            Console.WriteLine();

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (var item in birCizici)
            {
                item.Ciz(); // çiz metodunu çalıştır
            }

        }
        // Polimorfizm - Çokbiçimlilik
        public class Cizici
        {
            public virtual void Ciz() // virtual keywordü ile bu metodu override-ezilebilir hale getiriyoruz
            {
                Console.WriteLine("Cizici");
            }
        }
        public class DogruCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Düz Çizgi");
            }
        }
        public class DaireCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Daire Çizgi");
            }
        }
        public class KareCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Kare Çizgi");
            }
        }
    }
}
