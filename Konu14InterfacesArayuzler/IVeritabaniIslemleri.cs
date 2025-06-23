namespace Konu14InterfacesArayuzler
{
    internal interface IVeritabaniIslemleri
    {
        // bu arayüzü kullanacak class lar aşağıdaki metotları içermek zorundadır!
        // CRUD metot imzaları
        void Add(string name); // ekle
        void Update(int id); // güncelle
        void Delete(int id); // sil
        void GetAll(); // listele
        // interface lerde metotlar açıkça yazılmaz, sadece geri dönüş tipi, adı ve parametresi belirtilir.
    }
}
