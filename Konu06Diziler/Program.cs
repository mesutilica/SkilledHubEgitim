namespace Konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziler!");
            //Dizi oluşturma
            int[] sayi;
            int[] ogrenciler = new int[6];//ogrenciler isminde int veri tipi taşıyan ve 7 elemandan oluşan bir dizi oluşturduk. Dizi boyutu artmaz, azalmaz.
            //Dizilerde indis denilen yapı vardır ve içine eklenecek elemanlar 0 dan başlar
            ogrenciler[0] = 100; // diziye veri atama
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500;
            ogrenciler[5] = 600;
            Console.WriteLine("Seçilen öğrenci no: " + ogrenciler[5]);
        }
    }
}
