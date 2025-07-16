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


        

        public int Add(Product product)
        {
            int sonuc = 0;
            ConnectionKontrol();
            SqlCommand command = new SqlCommand(
                "Insert into Urunler values(@UrunAdi,@UrunFiyati,@StokMiktari,@Durum)", _connection);
            command.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
            command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
            command.Parameters.AddWithValue("@Durum", product.Durum);
            sonuc = command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            return sonuc;
        }

        public int Update(Product product)
        {
            int sonuc = 0;
            ConnectionKontrol();
            SqlCommand command = new SqlCommand(
                "Update Urunler set UrunAdi=@UAdi, UrunFiyati=@UrunFiyati, StokMiktari=@StokMiktari, Durum=@Durum where Id=@id", _connection);
            command.Parameters.AddWithValue("@UAdi", product.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
            command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
            command.Parameters.AddWithValue("@Durum", product.Durum);
            command.Parameters.AddWithValue("@id", product.Id);
            sonuc = command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            return sonuc;
        }

        public int Delete(int id)
        {
            int sonuc = 0;
            ConnectionKontrol();
            SqlCommand command = new SqlCommand(
                "Delete From Urunler where Id=@id", _connection);
            
            command.Parameters.AddWithValue("@id", id);
            sonuc = command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            return sonuc;
        }

    }
}
