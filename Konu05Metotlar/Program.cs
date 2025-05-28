namespace Konu05Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metotlar!");
            Console.WriteLine();
            ToplamaYap(); // Metot çağrısı olmadan ekrana yazdırmaz
            ToplamaYap(50, 8);
            Console.WriteLine("Geriye değer döndüren metot:");
            int sonuc = ToplamaYap(10, 20, 30); // Metot çağrısı ile geriye değer döndürülür
            Console.WriteLine("Sonuç: " + sonuc);
        }
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
    }
}
