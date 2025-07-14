-- sql de tek satýrlýk yorum için 2 tire kulanýlýr
/*
çoklu yorum satýrý
için
yine / * * / kullanýlýr.
*/

/*
	* SQL komutlarý kullaným amaçlarýna göre üç genel kategoriye ayrýlýr. Bunlar:
		1-Veri Tanýmlama Dili (DDL- Data Definition Language): Tablo oluþturma, deðiþtirme ve silme iþlemleri için kullanýyoruz.
		2-Veri Ýþleme Dili (DML Data Manipulation Language): Veri girmek, deðiþtirmek, silmek ve verileri almak için kullanýlan komutlarý
		3-Veri Kontrol Dili (DCL-Data Control Language): Veritabaný kullanýcýsý veya rolü ile ilgili izinlerin düzenlenmesini saðlar. 
*/
			-- SQL KOMUTLARI
--Temel Sql Komutlarý
--Sql Komutlarýyla Veritabaný oluþturma
-- create database OrnekDb -- komutu çalýþtýrmak için üst menüden execute veya kýsayolu f5

--Veritabaný isim deðiþtirme
--alter database OrnekDb Modify name=OrnekDatabase

--Veritabaný silme
--drop database OrnekDatabase

--Sql Kod ile Veritabanýna Tablo Ekleme
/*
create database OrnekDb
go
use OrnekDb -- oluþturulan ornekdb veritabanýný kullan
go
CREATE TABLE Personel (PersonelID int, Adi varchar(50), Soyadi varchar(50)); -- ornekdb veritabana Personel adýnda tablo ekle

use OrnekDb --ornekdb veritabanýný kullan
go --sonraki adýma geç
create table Ogrenciler (Id int not null, Adi varchar(50) not null, Soyadi
varchar(50) null); --tabloyu verdiðimiz alanlara göre oluþtur alanlarýn boþ geçilme durumlarýný da kulandýk

-- Sql ile tabloda deðiþiklik yapma
Alter Table Personel Add Email varchar(250)

Alter Table Personel Alter Column Email varchar(50)

Alter Table Personel Add Ders varchar(50), Konu varchar(50) -- Tek seferde 1 den fazla kolon ekleme

Alter Table Personel Alter Column PersonelId int not null

ALTER TABLE Personel DROP COLUMN Email;

ALTER TABLE Personel ALTER COLUMN Soyadi nvarchar(75);
*/
ALTER TABLE Personel ADD TCNo varchar(11);
