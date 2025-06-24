namespace Konu15AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Classes!");
            Database database = new Oracle();//Database sınıfından yeni bir oracle nesnesi oluşturuyoruz. Database nesnesi oluşturulmuyor!
            database.Add();
            database.Delete();

            Console.WriteLine();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Add metodu çalıştı Ekleme yapıldı");
        }
        public abstract void Delete();//crud
        public abstract void Update();//crud
        public abstract void Get();//crud
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Sql den silindi");
        }

        public override void Get()
        {
            Console.WriteLine("SqlServer Get çalıştı");
        }

        public override void Update()
        {
            Console.WriteLine("Sql de güncellendi");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Oracle dan silindi");
        }

        public override void Get()
        {
            Console.WriteLine("Oracle Get çalıştı");
        }

        public override void Update()
        {
            Console.WriteLine("Oracle da güncellendi");
        }
    }
}
