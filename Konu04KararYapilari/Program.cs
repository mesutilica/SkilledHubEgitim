namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karar Yapilari!");
            Console.WriteLine("Bir Sayı Giriniz:");
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
        }
    }
}
