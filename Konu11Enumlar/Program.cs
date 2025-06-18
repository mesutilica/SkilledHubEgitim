namespace Konu11Enumlar
{
    internal class Program
    {
        //Enum(Numaratör) lar nesneleri numaralandırmak için kullanılır
        /*
         * Enum tipler üzerindeki kısıtlar
         * 1-Enum blokunda metot tanımlanamaz
         * 2-Arayüz(Interface) kullanamazlar
         * 3-enum blokunda property kullanılmaz         
         */
        enum Aylar : byte//byte koleksiyondaki numaraların veri tipinin byte türünden olacağını belirtiyor
        {
            Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
        }
        enum SiparisDurumu
        {
            Hazırlanıyor, Hazırlandı, KargoBekleniyor, Kargolandı
        }
        enum Meyveler : int
        {
            Elma = 3, Armut = 7, Çilek = 1
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 11 Enumlar!");
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine($"{Meyveler.Armut} = {a}, {Meyveler.Elma}={b}, {Meyveler.Çilek}={c}");
            Ornek1(SiparisDurum: 1);

        }
        static void Ornek1(int SiparisDurum)
        {
            if (SiparisDurum == (int)SiparisDurumu.Hazırlanıyor)
                Console.WriteLine("Siparişiniz Hazırlanıyor");
            if (SiparisDurum == (int)SiparisDurumu.Hazırlandı)
                Console.WriteLine("Siparişiniz Hazırlandı");
            if (SiparisDurum == (int)SiparisDurumu.KargoBekleniyor)
                Console.WriteLine("Siparişiniz İçin Kargo Bekleniyor");
            if (SiparisDurum == (int)SiparisDurumu.Kargolandı)
                Console.WriteLine("Siparişiniz Kargoya Verildi");
        }
    }
}
