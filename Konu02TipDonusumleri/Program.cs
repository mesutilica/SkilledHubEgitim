namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Dönüşümleri!");
            //Implicit Casting - otomatik dönüşüm
            //char -> int -> long -> float -> double
            //Explicit Casting - Manuel
            //double -> float -> long -> int -> char

            //Implicit Casting daha küçük boyutlu bir türü daha büyük bir boyut türüne geçirirken otomatik olarak yapılır
            Console.WriteLine("Implicit Casting");
            int sayi = 9;
            double kesirliSayi = sayi; //int den double a otomatik dönüşüm

            Console.WriteLine(sayi);      // Çıktı 9
            Console.WriteLine(kesirliSayi);   // Çıktı 9


            //Explicit Casting türü değerin önüne parantez içine alarak manuel yapılmalıdır
            Console.WriteLine("Explicit Casting");
            double kesirliSayi2 = 9.78;
            int tamSayi = (int)kesirliSayi2;    // Manuel dönüştürme: double dan int e
            Console.WriteLine("kesirliSayi2:" + kesirliSayi2);
            Console.WriteLine("tamSayi:" + tamSayi);
            Console.WriteLine();
        }
    }
}
