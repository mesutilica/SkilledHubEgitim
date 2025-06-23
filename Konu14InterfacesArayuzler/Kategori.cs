namespace Konu14InterfacesArayuzler
{
    public class Kategori : ISinifGereksinimleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        // kategoriye ait özellikler
        public bool UstMenudeGoster { get; set; }
        public bool YanMenudeGoster { get; set; }
    }
}
