namespace Konu03Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 03 Operatorler!");
            Console.WriteLine("1-Aritmetik Operatörler");
            int sayi1 = 3;
            int sayi2 = 4;
            int sayi3 = 5;
            Console.WriteLine();
            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}"); // string tırnağının önüne $ işareti koyarak string interpolasyonu yapıyoruz.
            Console.WriteLine("1234" + sayi3); // string ile int arasında + işlemi yapıldığında int string'e dönüştürülür ve string olarak birleştirilir.
            Console.WriteLine();
            Console.WriteLine("Hesaplama İşlemleri: ");
            Console.WriteLine("sayi1 + sayi2: " + (sayi1 + sayi2));
            Console.WriteLine("sayi1 - sayi2: " + (sayi1 - sayi2));
            Console.WriteLine("sayi1 * sayi2: " + (sayi1 * sayi2));
            Console.WriteLine("sayi1 / sayi2: " + (sayi1 / sayi2));
            Console.WriteLine("sayi1 % sayi2: " + (sayi1 % sayi2));

            Console.WriteLine();

            Console.WriteLine("Artırım ve Azaltım Operatörleri");
            sayi2++; // bir değişkendeki değeri 1 artırmak için
            Console.WriteLine("sayi2: " + sayi2);
            sayi2--; // bir değişkendeki değeri 1 eksiltmek için
            Console.WriteLine("sayi2: " + sayi2);

            Console.WriteLine();

            Console.WriteLine("Atama Operatörleri");
            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
            Console.WriteLine("sayi1 += sayi2: " + (sayi1 += sayi2));
            Console.WriteLine("sayi1 -= sayi2: " + (sayi1 -= sayi2));
            Console.WriteLine("sayi1 *= sayi2: " + (sayi1 *= sayi2));
            Console.WriteLine("sayi1 /= sayi2: " + (sayi1 /= sayi2));
            Console.WriteLine("sayi1 %= sayi2: " + (sayi1 %= sayi2));

            Console.WriteLine();

            Console.WriteLine("İlişkisel Operatörler"); // birden fazla değeri karşılaştırıp aralarındaki durumu öğrenmek için kullanırız.
            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
            Console.WriteLine("sayı 1 sayı 2 ye eşit mi? " + (sayi1 == sayi2));
            Console.WriteLine("sayı 1 sayı 2 ye eşit değil mi? " + (sayi1 != sayi2));
            Console.WriteLine("sayı 1 sayı 2 den büyük mü? " + (sayi1 > sayi2));
            Console.WriteLine("sayı 1 sayı 2 den küçük mü? " + (sayi1 < sayi2));
            Console.WriteLine("sayı 1 sayı 2 den küçük mü veya sayılar eşit mi? " + (sayi1 <= sayi2));
            Console.WriteLine("sayı 1 sayı 2 den büyük mü veya sayılar eşit mi? " + (sayi1 >= sayi2));

            Console.WriteLine();

            Console.WriteLine("Ternary Operatörü");// eğer karşılaştırma için 2 değer kullanacaksak karşılaştırmanın kısayolu olarak kullanırız.
            Console.WriteLine("Ternary: " + ((sayi1 == sayi2) ? $"sayı 1({sayi1}) sayı 2({sayi2}) ye eşit" : $"sayı 1({sayi1}) sayı 2({sayi2}) ye eşit değil"));

            Console.WriteLine();
            Console.WriteLine("Mantıksal Operatörler");
            Console.WriteLine("And & Operatörü");
            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
            sayi1 = 4; // sayi1 değerini 4 olarak atıyoruz ki karşılaştırma işlemi true olsun.
            Console.WriteLine("sayı 1 sayı 2 ye eşit mi? " + (sayi1 == sayi2));
            Console.WriteLine("sayı 1 sayı 2 den büyük mü? " + (sayi1 > sayi2));
            
            Console.WriteLine("sayı 1 sayı 2 ye eşit mi? ve sayı 1 sayı 2 den küçük mü? " + ((sayi1 == sayi2) && (sayi1 < sayi2)));// iki değerin de true sonucu vermesi lazım 1 tanesi false olması durumunda sonuç False olur

            Console.WriteLine();
            Console.WriteLine("Veya || Operatörü");
            Console.WriteLine("sayı 1 sayı 2 ye eşit mi? veya sayı 1 sayı 2 den küçük mü? " + ((sayi1 == sayi2) || (sayi1 < sayi2)));
        }
    }
}
