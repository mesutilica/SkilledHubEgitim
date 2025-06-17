namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10 String Sinifi!");
            string degisken;
            char karakter = 'F'; // char tek karakter alır
            string metinlericin = "metinler için mi kullanıyorduk?";
            Console.WriteLine(metinlericin);
            //Ornek1();
            //StringMetotlari();
            SplitMetodu();
        }
        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir";
            String birsayi = "123456789";
            System.String birTarih = "02.05.2021";
            string kod = "//5456dfgd\n";//buradaki \n kodu enter görevi görür ve kendinden sonra gelecek olan metni bir alt satıra kaydırır
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);

            string s = "Barış Manço";
            Console.WriteLine("For Döngüsü Çıktısı");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s[" + i + "] = " + s[i]);
            }
            Console.WriteLine("Foreach Döngüsü Çıktısı");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
        static void StringMetotlari()
        {
            string metin = "Stringin Birçok Metodu Vardır";
            Console.WriteLine("metin in karakter sayısı(metin.Length) : " + metin.Length); // Length metin değişkeninde kaç karakter olduğunu verir.
            var klon = metin.Clone(); // Clone metodu metin değişkeninin klonlayıp klon değişkenine atar.
            Console.WriteLine("metnin klonu : " + klon);
            metin = "My Name is Ali";
            Console.WriteLine(metin + " EndsWith i: " + metin.EndsWith("i"));
            Console.WriteLine(metin + " EndsWith r: " + metin.EndsWith("r"));

            Console.WriteLine();

            Console.WriteLine(metin + " StartsWith s: " + metin.StartsWith("s"));
            Console.WriteLine(metin + " StartsWith m: " + metin.StartsWith("m"));
            Console.WriteLine(metin + " StartsWith M: " + metin.StartsWith("M"));

            Console.WriteLine();

            Console.WriteLine(metin + " IndexOf name: " + metin.IndexOf("name"));
            Console.WriteLine(metin + " IndexOf Name: " + metin.IndexOf("Name"));
            Console.WriteLine(metin + " LastIndexOf i: " + metin.LastIndexOf("i"));

            Console.WriteLine();

            Console.WriteLine(metin + " Insert 0: " + metin.Insert(0, "Merhaba : "));// metnin değeri değişmiyor sadece başına merhaba ekleniyor
            Console.WriteLine(metin);

            Console.WriteLine();
            Console.WriteLine(metin + " Substring 2: " + metin.Substring(2));
            Console.WriteLine(metin + " Substring 2, 5: " + metin.Substring(2, 5));

            Console.WriteLine();
            Console.WriteLine(metin + " ToLower: " + metin.ToLower());
            Console.WriteLine(metin + " ToUpper: " + metin.ToUpper());
            Console.WriteLine(metin + " metin.ToLower().Replace: " + metin.ToLower().Replace(" ", "-"));
            Console.WriteLine(metin + " Remove 2: " + metin.Remove(2));
            Console.WriteLine(metin + " Remove 2, 5: " + metin.Remove(2, 5));
        }
        static void SplitMetodu()
        {
            string sehirler = "İstanbul,Ankara,İzmir,Bursa,Adana,Antalya";
            string[] sehirlerArray = sehirler.Split(',');
            Console.WriteLine("4. Şehir : " + sehirlerArray[3]);
            foreach (var item in sehirlerArray)
            {
                Console.WriteLine("Şehir : " + item);
            }
            Console.WriteLine();

            Console.WriteLine("tarih parçalama");
            var tarih = DateTime.Now.ToShortDateString();
            Console.WriteLine("tarih: " + tarih);
            var tarihparcalari = tarih.Split(".");
            var gun = tarihparcalari[0];
            var ay = tarihparcalari[1];
            var yil = tarihparcalari[2];
            Console.WriteLine("gun: " + gun + "\n ay: " + ay + "\n yil: " + yil);
        }
    }
}
