namespace Konu14InterfacesArayuzler
{
    public class Urun : ISinifGereksinimleri, IVeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        // urun classına özel propertyler
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? Image { get; set; }
        public int KategoriId { get; set; }

        public void Add(string name)
        {
            Console.WriteLine(name + " ürünü eklendi");
        }

        public void Delete(int id)
        {
            Console.WriteLine(id + " li ürün silindi");
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            Console.WriteLine(id + " li ürün güncellendi");
        }
    }
}
