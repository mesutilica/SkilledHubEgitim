using System.Collections.Specialized;
using System.Collections;
using System.Text;

namespace Konu16CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections-Koleksiyonlar!");
            // Ornek1();
            // Ornek2();
            // Ornek3();
            Ornek4();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new();
            arrayList.Add(1); // arrayList e Add metoduyla veri eklenir
            arrayList.Add(2);
            arrayList.Add(3);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);// listedeki elemanları ekrana yazdır
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList ilk eleman : " + arrayList[0]);// listede index ini verdiğimiz elemana ulaşma
        }
        static void Ornek2()
        {
            ArrayList arrayList = new();
            arrayList.Add("İstanbul"); // arrayList e Add metoduyla veri eklenir
            arrayList.Add("Ankara");
            arrayList.Add("İzmir");
            arrayList.Add("Elazığ");
            arrayList.Add("Çankırı");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);// listedeki elemanları ekrana yazdır
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList ilk eleman : " + arrayList[0]);// listede index ini verdiğimiz elemana ulaşma
            Console.WriteLine();
            Console.WriteLine("ArrayList de sıralama yapabiliriz");
            arrayList.Sort();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek3()
        {
            int tamSayi = 18;
            double kesirli = 18.8;
            ArrayList arrayList = new();
            arrayList.Add("Ankara");
            arrayList.Add(tamSayi);
            arrayList.Add(kesirli);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < arrayList.Count; i++) // for döngüsü
            {
                Console.WriteLine(arrayList[i]);
            }
        }
        static void Ornek4()
        {
            var strings = new StringCollection();
            strings.Add("İstanbul");
            strings.Add("Ankara");
            strings.Add("Bursa");
            Console.WriteLine("String Collection");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
