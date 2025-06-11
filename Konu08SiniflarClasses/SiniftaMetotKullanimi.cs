
namespace Konu08SiniflarClasses
{
    public class SiniftaMetotKullanimi
    {
        string kurucuMetot;
        public SiniftaMetotKullanimi() //constructor kurucu metot: kısayolu ctor > tab
        {
            Console.WriteLine();
            kurucuMetot = "Sınıflarda constructor (kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturulduğunda otomatik olarak çalışır ve içerisindeki kodları çalıştrır. Kurucu metotlar değişkenler gibi veri tipi almazlar ve void ifadesi de bulunmaz, sınıfın adıyla aynı ad kullanılarak oluşturulur.";//yukarda tanımladığımız kurucumetot değişkenine sınıfımızın kurucu metodunda değer ataması yaptık
            Console.WriteLine(kurucuMetot);
            Console.WriteLine();
        }

        public bool LoginKontrol(string kullanici, string sifre)
        {
            if (kullanici == "admin" && sifre == "123456")
            {
                return true;
            }
            return false;
        }

        public int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static string StatikDegisken = "Sınıflarda metot ve değişken de kullanabiliriz";
        public string DinamikDegisken = "Bu değişken statik değildir!";

    }
}
