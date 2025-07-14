				-- CRUD ��LEMLER�
-- Tablolara kay�t ekleme, kay�tlar� �ekme, kay�t g�ncelleme ve silme i�lemlerine k�saca C(create) R(read) U(update) D(delete) deriz.
-- Tabloya Veri Ekleme
--Insert Into Personel (PersonelID, Adi, Soyadi) values (1, 'Memet', 'Ali')
--Eklenen Verileri �ekme
--select * from Personel
--Tabloda T�m Alanlara Veri Ekleme
--Insert Into Personel values (3, 'Memati', 'Ba�', null, null, null)
--Tabloda G�ncelleme Yapma
--update Personel set Adi ='Alp', Soyadi = 'Arslan' where PersonelID = 2
-- Kay�t silme
--delete from Personel where PersonelID = 3

-- Veritaban�n�n Yede�ini Alma
-- BACKUP DATABASE OrnekDb TO DISK = 'D:\DBYedek.bak';

-- Veritaban�n� Yedekten Geri Y�kleme
/*
USE master; -- Geri y�kleme i�lemi i�in master veritaban�n� kullan�yoruz
GO
RESTORE DATABASE OrnekDb
FROM DISK = 'D:\DBYedek.bak'
WITH REPLACE; -- Mevcut veritaban�n� de�i�tirir
*/
-- Tablodaki T�m Verileri Silme
-- TRUNCATE TABLE personel;
-- select * from Personel

-- Tabloyu silme
-- Drop TABLE personel;

