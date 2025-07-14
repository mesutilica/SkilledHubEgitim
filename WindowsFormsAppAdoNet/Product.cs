namespace WindowsFormsAppAdoNet
{
    public class Product
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int StokMiktari { get; set; }
        public bool Durum { get; set; }
    }
}
