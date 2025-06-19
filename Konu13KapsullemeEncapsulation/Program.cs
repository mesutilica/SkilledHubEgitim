namespace Konu13KapsullemeEncapsulation
{
    public class Bolum
    {
        private string BolumAdi;//dışarıdan erişime kapalı değişkenimiz. 
        //Accessor (Getter)
        public string GetBolumAdi()
        {
            return BolumAdi;
        }//Geriye private BolumAdi değişkenini döndüren metot
        public void SetBolumAdi(string istenenEgitimi)
        {
            if (istenenEgitimi == "Yazılım Mühendisliği")
            {
                Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır!", istenenEgitimi);
            }
            else BolumAdi = istenenEgitimi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13:Kapsulleme-Encapsulation!");
            Bolum bolum = new Bolum();
            Console.WriteLine("Kurumumuzdaki Bölümler:");
            Console.WriteLine("1-Elektronik");
            Console.WriteLine("2-Bilgisayar Mühendisliği");
            Console.WriteLine("3-Grafik Tasarım");
            Console.WriteLine("Lütfen Bölüm Adını Giriniz;");
            //var bolumAdi = Console.ReadLine();//ekrandan alınan değeri okuyup var  ile oluşturduğumuz bolumadi değişkenine atadık
            //bolum.SetBolumAdi(bolumAdi);//bolum içerisindeki SetBolumAdi metoduna bölüm adını gönderdik, private değişkene atama yapıldı
            //Console.WriteLine("Kayıt Olunacak Bölüm Adı : " + bolum.GetBolumAdi());//bolum içerisindeki GetBolumAdi() metodunu direk ekrana yazdırdık çünkü GetBolumAdi()

            Fakulte fakulte = new Fakulte
            {
                Bolum = "Yazılım Mühendisliği"
            };

            Console.WriteLine("Fakülte = {0} {1}", fakulte.Bolum, "2.değer");

            Universite universite = new("Maliye");
            Console.WriteLine("Universite Bölümü : " + universite.Bolum);
            // universite.Bolum = ""; // bu şekilde bir veri gönderimi yapamayız çünkü property read only
        }
    }
    //Özgen (Property) kullanarak kapsülleme
    public class Fakulte
    {
        private string bolum;//Fakülte sınıfının içindeki bolum değişkenini private tanımlayarak kapsüllemiş olduk, böylece bu değişkene sadece aşağıdaki get, set metotlarıyla erişilebilir
        public string Bolum
        {
            get { return bolum; } //get bloğu içindeki return(dön) komutundan anlaşılacağı üzere geriye içerdeki private tanımladığımız kapsüllenen bolum değişkenine atanan veriyi döndürür
            set
            {
                if (value == "Yazılım Mühendisliği")
                {
                    Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır!", value);
                }
                else bolum = value;
            } //set bloğu ise dışarıya açık Bolum değişkenine atanan veriyi alıp içerde kapsüllediğimiz private bolum değişkenine atar
        }
    }
    //Yalnız okunur (Read only property)
    public class Universite
    {
        private string bolum;
        public Universite(string str)
        {
            bolum = str;
        }
        public string Bolum { get { return bolum; } }
    }
}
