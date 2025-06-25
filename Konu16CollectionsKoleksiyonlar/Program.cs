using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            // Ornek4();
            // Ornek5();
            // Ornek6();
            // Ornek7();
            // Ornek8();
            // StringBuilderKullanimi();
            ListKullanimi();
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
            // strings.Add(34); // string dışında ekleme yapılamaz!
            Console.WriteLine("String Collection");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek5()
        {
            var dictionary = new StringDictionary(); // key value şeklinde veri saklayabilir
            dictionary.Add("18", "Çankırı");
            dictionary.Add("06", "Angara");
            dictionary.Add("34", "İstanbul");
            dictionary.Add("01", "Adana");
            dictionary.Add("58", "Sivas");
            Console.WriteLine();
            Console.WriteLine("String Dictionary");
            Console.WriteLine("dictionary 18: " + dictionary["18"]);
            Console.WriteLine();
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("String Dictionary Keys");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("String Dictionary Values");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek6()
        {
            Stack stack = new(); // Stack sınıfı programlamada LIFO - son giren ilk çıkar kuralıyla çalışır.
            // stack.add(); stack de listeye add metoduyla ekleme yapılmaz
            stack.Push("Çankırı");
            stack.Push("Ankara");
            stack.Push("İstanbul");
            stack.Push("Karabük");
            stack.Push(34);
            stack.Push(58);
            Console.WriteLine("Stack");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop()); // stack de nesneler üst üste koyulmuş gibidir verilere de üstten çekerek ulaşılır
            }
        }
        static void Ornek7()
        {
            Queue queue = new(); // Queue sınıfı programlamada FIFO - ilk giren ilk çıkar mantığıyla çalışır
            queue.Enqueue("Lale");
            queue.Enqueue("Gül");
            queue.Enqueue("Zambak");
            queue.Enqueue(18); // obje aldığı için her türlü veri kabul eder
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        static void Ornek8()
        {
            Dictionary<string, string> dictionary = new(); // hangi veri tipinden oluşacağını bizim belirleyebildiğimiz liste sistemi
            dictionary.Add("book", "kitap");
            dictionary.Add("18", "Çankırı");
            dictionary.Add("34", "İstanbul");
            Console.WriteLine(dictionary["book"]);

            Console.WriteLine();

            Dictionary<int, string> dictionary2 = new();
            dictionary2.Add(1, "kitap");
            dictionary2.Add(18, "Çankırı");
            dictionary2.Add(34, "İstanbul");

            Console.WriteLine();

            Console.WriteLine("dictionary2 Values");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine();

            Console.WriteLine("dictionary2 Keys");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine();

            Console.WriteLine("dictionary2 Key Values");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
        static void StringBuilderKullanimi()
        {
            Console.WriteLine("String Builder Kullanimi");
            var sb = new StringBuilder();
            sb.Append(1);
            sb.Append(8);
            Console.WriteLine("sb : " + sb.ToString());

            Console.WriteLine();

            StringBuilder sb2 = new();
            sb2.Append("Çankırı ");
            sb2.Append("İstanbul ");
            sb2.Append("Sivas ");
            Console.WriteLine("sb2: " + sb2.ToString());

            Console.WriteLine();

            StringBuilder sb3 = new();
            sb3.Append("Çankırı ");
            sb3.Append(Environment.NewLine);
            sb3.Append("İstanbul ");
            sb3.Append(Environment.NewLine);
            sb3.Append("Sivas ");
            Console.WriteLine("sb3: " + sb3.ToString());

            Console.WriteLine();

            StringBuilder sb4 = new();
            sb4.AppendLine("Çankırı ");
            sb4.AppendLine("İstanbul ");
            sb4.AppendLine("Sivas ");
            Console.WriteLine("sb4: " + sb4.ToString());
        }
        static void ListKullanimi()
        {
            List<string> sehirler = new(); // string veri tipi alabilen bir liste
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Kocaeli");
            sehirler.Add("Sivas 58");
            Console.WriteLine("Şehirler : ");
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<User> users = new();
            users.Add(new User
            {
                Id = 1,
                Name = "Sümeyye",
                Password = "123"
            });
            users.Add(new User
            {
                Id = 2,
                Name = "Rukiye",
                Password = "456"
            });
            Console.WriteLine("Kullanıcılar:");
            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }

            List<User> kullanicilar = new()
            {
                new User
                {
                    Id = 3,
                    Name = "Ali",
                    Password = "789"
                },
                new User
                {
                    Id = 4,
                    Name = "Alparslan",
                    Password = "1071"
                }
            };
            Console.WriteLine();
            Console.WriteLine("Kullanıcılar 2:");
            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici.Name);
            }
            var yeniKullanici = new User()
            {
                Id = 5,
                Name = "Alp",
                Password = "789"
            };
            Console.WriteLine("Kullanıcılar listesinde yeniKullanici var mı? " + kullanicilar.Contains(yeniKullanici));

            kullanicilar.Add(yeniKullanici); // ekledik

            Console.WriteLine("Kullanıcılar listesinde yeniKullanici var mı? " + kullanicilar.Contains(yeniKullanici));

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Listedeki kayıt sayısı : " + kullanicilar.Count);

            Console.WriteLine();
            kullanicilar.Insert(0, yeniKullanici);

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name);
            }
        }

    }
}
