namespace Konu14InterfacesArayuzler
{
    public interface OrnekArayuz // class yerine interface yazıyoruz
    {
        public int Id { get; set; }
    }
    interface IDemo
    {
        void Goster(); // interface de metot imzası tanımlama
    }
    interface icerebilecekleri : IDemo
    {
        public int sayi1 { get; set; }
        int sayi { get; set; }
        static int sayi2 { get; set; }
        void Topla();
        int ToplamaYap();
    }
    class ArayuzKullanimi : icerebilecekleri
    {
        public int sayi1 { get; set; }
        public int sayi { get; set; }

        public void Goster()
        {
            Console.WriteLine(sayi1);
        }

        public void Topla()
        {
            Console.WriteLine();
        }

        public int ToplamaYap()
        {
            return 18;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu14:Interfaces-Arayuzler!");
            ArayuzKullanimi arayuzKullanimi = new();
            arayuzKullanimi.sayi1 = 18;
            arayuzKullanimi.Goster();

            Urun urun = new Urun();
            Console.WriteLine("Ürün Adı Giriniz:");
            var urunadi = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(urunadi))
            {
                urun.Name = urunadi;
                urun.Add(urun.Name);
            }
            else
                Console.WriteLine("Ürün Adı Boş Geçilemez!");

            Console.WriteLine();

            Console.WriteLine("Kategori Adı Giriniz:");
            Kategori kategori = new Kategori();
            KategoriDBIslemleri kategoriDBIslemleri = new();
            var kategoriadi = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(kategoriadi))
            {
                kategori.Name = kategoriadi;
                kategoriDBIslemleri.Add(kategoriadi);
            }
            else
                Console.WriteLine("Ürün Adı Boş Geçilemez!");
        }
    }
}
