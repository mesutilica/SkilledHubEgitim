using System;
using System.Collections.Generic;
using System.Data; // veritabanı işlemleri için gerekli
using System.Data.SqlClient; // ado.net kütüphaneleri

namespace WindowsFormsAppAdoNet
{
    public class ProductDal : OrtakDAL
    {
        public List<Product> GetAll()
        {
            var products = new List<Product>();

            ConnectionKontrol();

            SqlCommand command = new SqlCommand("select * from Urunler", _connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) // reader nesnesi içerisinde okunacak kayıt olduğu sürece
            {
                var product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UrunAdi = reader["UrunAdi"].ToString(),
                    StokMiktari = Convert.ToInt32(reader["StokMiktari"]),
                    UrunFiyati = Convert.ToDecimal(reader["UrunFiyati"]),
                    Durum = Convert.ToBoolean(reader["Durum"])
                };
                products.Add(product); // db den okunan ürünü listeye ekle
            }
            reader.Close(); // veritabanından okuyucuyu kapat
            _connection.Close(); // veritabanı bağlantısını kapat
            command.Dispose(); // sql komut nesnesini yoket

            return products;
        }
    }
}
