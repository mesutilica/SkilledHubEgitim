namespace Konu14InterfacesArayuzler
{
    public class KategoriDBIslemleri : IVeritabaniIslemleri
    {
        public void Add(string name)
        {
            Console.WriteLine(name + " kategorisi eklendi");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Delete");
        }

        public void GetAll()
        {
            Console.WriteLine();
        }

        public void Update(int id)
        {
            Console.WriteLine("Update");
        }
    }
}
