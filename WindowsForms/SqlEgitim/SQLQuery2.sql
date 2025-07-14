				-- CRUD ÝÞLEMLERÝ
-- Tablolara kayýt ekleme, kayýtlarý çekme, kayýt güncelleme ve silme iþlemlerine kýsaca C(create) R(read) U(update) D(delete) deriz.
-- Tabloya Veri Ekleme
--Insert Into Personel (PersonelID, Adi, Soyadi) values (1, 'Memet', 'Ali')
--Eklenen Verileri Çekme
--select * from Personel
--Tabloda Tüm Alanlara Veri Ekleme
--Insert Into Personel values (3, 'Memati', 'Baþ', null, null, null)
--Tabloda Güncelleme Yapma
--update Personel set Adi ='Alp', Soyadi = 'Arslan' where PersonelID = 2
-- Kayýt silme
--delete from Personel where PersonelID = 3

-- Veritabanýnýn Yedeðini Alma
-- BACKUP DATABASE OrnekDb TO DISK = 'D:\DBYedek.bak';

-- Veritabanýný Yedekten Geri Yükleme
/*
USE master; -- Geri yükleme iþlemi için master veritabanýný kullanýyoruz
GO
RESTORE DATABASE OrnekDb
FROM DISK = 'D:\DBYedek.bak'
WITH REPLACE; -- Mevcut veritabanýný deðiþtirir
*/
-- Tablodaki Tüm Verileri Silme
-- TRUNCATE TABLE personel;
-- select * from Personel

-- Tabloyu silme
-- Drop TABLE personel;

