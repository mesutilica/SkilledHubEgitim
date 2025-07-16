using System.Data; // veritabanı işlemleri için gerekli
using System.Data.SqlClient; // ado.net kütüphaneleri

namespace WindowsFormsAppAdoNet
{
    public class OrtakDAL
    {
        internal SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; database=UrunYonetimiAdoNet; Integrated Security=True;"); // veritabanımın bulunduğu server bilgisini connection string olarak burada tanımlıyorum.

        internal void ConnectionKontrol()//Veritabanı bağlantımızı kontrol edecek olan metot
        {
            if (_connection.State == ConnectionState.Closed)//Eğer veritabanı bağlantımızın durumu kapalı ise
            {
                _connection.Open();//Veritabanı bağlantısını aç
            }
        }

        public DataTable GetDataTable(string sqlSorgu)
        {
            DataTable dt = new DataTable();

            ConnectionKontrol();

            SqlCommand command = new SqlCommand(sqlSorgu, _connection);

            SqlDataReader reader = command.ExecuteReader();

            dt.Load(reader); // veritabanından okuduğumuz kayıtları boş datatable ye yüklüyoruz.

            reader.Close(); // veritabanından okuyucuyu kapat
            _connection.Close(); // veritabanı bağlantısını kapat
            command.Dispose(); // sql komut nesnesini yoket

            return dt;
        }

    }
}
