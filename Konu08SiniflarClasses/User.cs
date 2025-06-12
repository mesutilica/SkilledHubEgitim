namespace Konu08SiniflarClasses
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public DateTime CreateDate { get; set; } // prop > tab
        public bool KullaniciGiris(string mail, string sifre)
        {
            string veritabanindaKayitliMail = "info@uygulama.com";
            string veritabanindaKayitliSifre = "123456";
            bool islemSonucu = false;

            if (mail == veritabanindaKayitliMail && sifre == veritabanindaKayitliSifre)
            {
                islemSonucu = true;
            }

            return islemSonucu;
        }
    }
}
