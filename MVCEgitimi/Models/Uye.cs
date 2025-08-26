namespace MVCEgitimi.Models
{
    public class Uye
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public string? TcKimlikNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Sifre { get; set; }
        public string? SifreTekrar { get; set; }
    }
}
