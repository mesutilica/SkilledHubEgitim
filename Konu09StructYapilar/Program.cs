namespace Konu09StructYapilar
{
    public struct Yapi
    {
        //public string ad = "ali";//struct kullanımında class dan farklı olarak öğelere başlangıç değeri atanamaz
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("yapı içindeki metot çalıştı");
        }
    }
    internal class Program
    {
        struct Kimlik
        {
            //Kimlik struct'ının değişkenleri
            public string ad;
            public string soyad;
            public int yas;
            public string dogumyeri;
            public struct Adres
            {
                public int Id { get; set; }
                public int KapiNo { get; set; }
                public string Sehir { get; set; }
                public string Ilce { get; set; }
                public string AcikAdres { get; set; }
            }
            internal string Birlestir(string ad, string soyad)
            {
                return ad + " " + soyad.ToUpper();
            }
            public void ToplamiYaz(int sayi1, int sayi2)
            {
                Console.WriteLine("Sayı 1 ve Sayı 2 nin Toplamı;");
                Console.WriteLine(sayi1 + sayi2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Struct - Yapilar!");

            Yapi ilkyapi = new Yapi();
            ilkyapi.metin = "yapı metni";
            ilkyapi.sayi = 18;
            ilkyapi.Metot();
            Console.WriteLine(ilkyapi.metin);

            //Struct ile yapı kurma
            Kimlik kimlik = new Kimlik();
            kimlik.ad = "Eşref";
            kimlik.soyad = "Ay";
            kimlik.dogumyeri = "İstanbul";
            kimlik.yas = 23;

            Console.WriteLine();

            //Struct ile kurulan yapıyı kullanma
            Console.WriteLine("Kimlik Bilgileri;");
            Console.WriteLine("Ad : {0}, Soyad : {1}", kimlik.ad, kimlik.soyad);
            Console.WriteLine("Doğum Yeri : " + kimlik.dogumyeri);
            Console.WriteLine("Yaşı : " + kimlik.yas);

            Console.WriteLine();

            Console.WriteLine(kimlik.Birlestir("Ali İhsan", "Aras"));
            kimlik.ToplamiYaz(10, 8);

            Kimlik.Adres adres = new Kimlik.Adres();
            adres.AcikAdres = "Papatya sokak.";
            adres.Ilce = "Sarıyer";
            adres.Sehir = "İstanbul";

            Console.WriteLine();
            Console.WriteLine("Kullanıcı Adres Bilgileri:");

            Console.WriteLine(adres.AcikAdres);
            Console.WriteLine(adres.Ilce);
            Console.WriteLine(adres.Sehir);
        }
    }
}
