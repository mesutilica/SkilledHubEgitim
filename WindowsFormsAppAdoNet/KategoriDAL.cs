using System;
using System.Collections.Generic;
using System.Data; // veritabanı işlemleri için gerekli
using System.Data.SqlClient; // ado.net kütüphaneleri

namespace WindowsFormsAppAdoNet
{
    public class KategoriDAL : OrtakDAL
    {
        public int Add(Category category)
        {
            int sonuc = 0;
            ConnectionKontrol();
            SqlCommand command = new SqlCommand(
                "Insert into Kategoriler (Name, Description, CreateDate, Durum) values (@Name, @Description, @CreateDate, @Durum)", _connection);
            command.Parameters.AddWithValue("@Name", category.Name);
            command.Parameters.AddWithValue("@Description", category.Description);
            command.Parameters.AddWithValue("@CreateDate", category.CreateDate);
            command.Parameters.AddWithValue("@Durum", category.Durum);
            sonuc = command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            return sonuc;
        }

        public int Update(Category category)
        {
            int sonuc = 0;
            ConnectionKontrol();
            SqlCommand command = new SqlCommand(
                "Update Kategoriler set Name=@Name, Description=@Description, CreateDate=@CreateDate, Durum=@Durum where Id=@KatId", _connection);
            command.Parameters.AddWithValue("@Name", category.Name);
            command.Parameters.AddWithValue("@Description", category.Description);
            command.Parameters.AddWithValue("@CreateDate", category.CreateDate);
            command.Parameters.AddWithValue("@Durum", category.Durum);
            command.Parameters.AddWithValue("@KatId", category.Id);
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
                "Delete From Kategoriler where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            sonuc = command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            return sonuc;
        }

        public Category Find(int id)
        {
            Category category = null;
            ConnectionKontrol();
            SqlCommand command = new SqlCommand(
                "select * From Kategoriler where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            var reader = command.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    category.Id = reader.GetInt32(0);
                    category.Name = reader.GetString(1);
                    category.Description = reader.GetString(2);
                    category.Durum = reader.GetBoolean(3);
                    category.CreateDate = reader.GetDateTime(4);
                }
            }
            command.Dispose();
            _connection.Close();
            return category;
        }

    }
}
