namespace Konu14InterfacesArayuzler
{
    public interface OrnekArayuz // class yerine interface yazıyoruz
    {
        public int Id { get; set; }
    }
    interface IDemo
    {
        void Goster(); // interface de metot imzası tanımlama
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu14:Interfaces-Arayuzler!");
        }
    }
}
