			-- SQL SORGULAMA
-- Tablodaki tüm verileri çekme
-- select * from Products
-- select * from Categories

-- Tablodaki bazý sütunlarý çekme
-- select ProductName, UnitPrice from Products

-- Tablodaki alanlara Alias(Takma isim) vererek çaðýrma
-- select ProductName as [Ürün Adý], UnitPrice as [Ürün Fiyatý] from Products

-- Tabloya Alias(Takma isim) vererek çaðýrma
-- select p.ProductName as [Ürün Adý], p.UnitPrice as [Ürün Fiyatý] from Products p
-- select kat.CategoryName as KategoriAdý from Categories kat

/*
	Select Top Ýfadesi
	Sorgu sonucunda tüm kayýtlar yerine belirli sayýda kaydý çekmemizi saðlar

SELECT TOP (50) * FROM Products

select top (10) ProductName, UnitPrice, UnitsInStock from Products -- Ürünler tablosundan üstten 10 ürünü seç ve ProductName, UnitPrice, UnitsInStock alanlarýný getir

			Order by ile Sýralama

SELECT * FROM Products order by UnitsInStock asc --Ürünleri UnitsInStock alanýna göre küçükten büyüðe doðru sýralayarak getir

SELECT * FROM Products order by UnitsInStock desc --Ürünleri UnitsInStock alanýna göre büyükten küçüðe doðru sýrala

			SQL Operatörleri
	1-SQL Aritmetik Operatörler

--Toplama (+)
SELECT 10 + 8
--Çýkarma (-)
SELECT (30-12)
--Çarpma (*)
SELECT 9 * 2
--Bölme (/)
SELECT 36 / 2
--Modulo (%)
SELECT 18 % 2

		2-SQL Karþýlaþtýrma Operatörleri

-- Eþittir (=)
SELECT * FROM Products WHERE UnitPrice = 18;

select * from Products where CategoryID = 3 -- CategoryID si 3 e eþit olanlarý getir.

select * from Products where ProductName = 'pavlova'

-- Büyüktür (>)

SELECT * FROM Products WHERE UnitPrice > 18;
 -- Küçüktür (<)
SELECT * FROM Products WHERE UnitPrice < 18;

SELECT * FROM Products WHERE UnitsInStock < 1;
-- Büyük Eþittir (>=)

SELECT * FROM Products WHERE UnitPrice >= 18;

SELECT * FROM Products WHERE UnitsInStock >= 99;

-- Küçük Eþittir (<=)

SELECT * FROM Products WHERE UnitPrice <= 18;

-- Eþit Deðildir
-- SELECT * FROM Products WHERE UnitPrice <> 18;

SELECT * FROM Products WHERE UnitPrice != 18;

		3-Mantýksal Operatörler

-- And(&) Ve Operatörü ile çoklu filtre
SELECT * FROM Products Where SupplierID = 1 and CategoryID = 1--Supplier(Tedarikçi) Ürünlerden SupplierID si 1 olan ve kategori ýd si 1 olan ürünleri getir

-- Or(|) Ve Operatörü ile çoklu filtre
SELECT * FROM Products Where SupplierID = 1 or CategoryID = 1

-- Not(Deðil) Operatörü
SELECT * FROM Products Where not SupplierID = 1 and CategoryID = 1

		4-Diðer Operatörler

-- SQL BETWEEN Operatorü

SELECT * FROM Products WHERE UnitPrice BETWEEN 10 AND 20;

SELECT * FROM Products WHERE UnitPrice not BETWEEN 10 AND 20;

-- Like Operatorü Ýle Arama, Filtreleme Ýþlemi

select * from Products where ProductName like 'a%' --Ürünlerden ürün adý a ile baþlayanlarý getir

SELECT * FROM Customers WHERE ContactName LIKE 'a%'; --Müþterilerden adý a ile baþlayanlarý getir

SELECT * FROM Customers WHERE ContactName LIKE '%a'; --Müþterilerden adý a ile bitenleri getir

SELECT * FROM Customers WHERE ContactName LIKE '%or%'; --Müþterilerden adý or içerenleri getir

	SQL IN-Not IN Operatorü
ilgili sütunda istediðimiz deðerleri içerenleri in ile içermeyenleri not in
ile filtreleyebiliriz

SELECT * FROM Customers WHERE Country IN ('Germany', 'France', 'UK'); -- Customers tablosundaki müþterilerden Country kolonu 'Germany', 'France', 'UK' deðerlerini içerenleri getir.

SELECT * FROM Customers WHERE Country Not IN ('Germany', 'France', 'UK');

-- Ýç içe iliþkili veri okuma
select * from Customers where Country in (select Country from Suppliers)--Müþterilerden Country alanýnda Suppliers(tedarikçi) tablosunun ülke alanýnda geçenleri getir

		Tablodan veri okurken hesaplama
 * Ürün stoklarý eritildiðinde kazanýlacak para

select p.ProductName as [Ürün Adý], p.UnitPrice as [Ürün Fiyatý], p.UnitsInStock as [Stok Miktarý], p.UnitsInStock * p.UnitPrice as [Toplam Kazanç]
from Products p

	-- SQL NULL Deðerler
select ShipName, ShipRegion from Orders where ShipRegion is null --Sipariþlerden ShipName ve ShipRegion alanlarýný ShipRegion alaný null olanlara göre çek

select ShipName, ShipRegion from Orders where ShipRegion is not null

	-- SQL SELECT DISTINCT Kullanýmý : Sorgu sonucunda kayýt tekrarýný engellemeyi saðlar
SELECT Country FROM Customers order by Country

SELECT DISTINCT Country FROM Customers

	-- SQL Joins Ýle Tablolarda Birleþik Sorgu Oluþturma
-- SQL JOIN Türleri
	1-(INNER) JOIN: Her iki tabloda da eþleþen deðerlere sahip kayýtlarý döndürür
	2-LEFT (OUTER) JOIN: Soldaki tablodan tüm kayýtlarý ve sað tablodan eþleþen kayýtlarý döndürür
	3-RIGHT (OUTER) JOIN: Sað tablodan tüm kayýtlarý ve soldaki tablodan eþleþen kayýtlarý döndürür
	4-FULL (OUTER) JOIN: Sol veya sað tabloda bir eþleþme olduðunda tüm kayýtlarý döndürür

	-- SQL INNER JOIN
select * from Products
select * from Categories

select ProductName, UnitsInStock, CategoryName
from Products
join
Categories
on Products.CategoryID = Categories.CategoryID

SELECT Orders.OrderID, Customers.ContactName, Orders.OrderDate
FROM Orders
INNER JOIN
Customers ON Orders.CustomerID=Customers.CustomerID;

-- Join ile ikiden fazla tablo birleþtirme
SELECT Orders.OrderID, Customers.ContactName, Shippers.CompanyName
FROM ((Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID);

-- SQL LEFT JOIN
select Customers.ContactName, Orders.OrderID --Customers tablosundan ContactName alanýný, Orders tablosundan OrderID alanýný getir
from Customers --Customers tablosundan
Left Join Orders --left join ile solda birleþtirme iþlemi yapýlýr ve Customers tablosunda olan ama orders tablosunda olmayan kayýtlar da getirilir, inner join den farký budur inner join sadece eþleþen kayýtlarý getirir
on Customers.CustomerID = Orders.CustomerID --tablolarýmýzý ortak noktalarý olan CustomerID ye göre eþleþtirdik
order by Customers.ContactName

-- SQL RIGHT JOIN
SELECT Orders.OrderID, Employees.LastName, Employees.FirstName
FROM Orders
RIGHT JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY Orders.OrderID;

-- SQL FULL OUTER JOIN
SELECT Customers.ContactName, Orders.OrderID
FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.ContactName;

-- SQL UNION
-- UNION komutu, iki veya daha fazla SELECT deyiminin sonuç kümesini birleþtirmek için kullanýlýr.
SELECT City FROM Customers
UNION
SELECT City FROM Suppliers
ORDER BY City;

SELECT City FROM Customers
UNION All -- all tekrar eden kayýtlarý da getirir.
SELECT City FROM Suppliers
ORDER BY City;

-- SQL GROUP BY
SELECT Country FROM Customers
GROUP BY Country;

--Hata Denetimi
BEGIN TRY
	SELECT 4/0
END TRY
BEGIN CATCH
	SELECT
	ERROR_NUMBER() AS Hata_Numarasi,
	ERROR_SEVERITY() AS Hata_Duzeyi,
	ERROR_STATE() AS Hata_Durum_No,
	ERROR_LINE() AS Hata_Satir_No,
	ERROR_MESSAGE() AS Hata_Mesaj
END CATCH


create database Bilisim
go
use bilisim
CREATE TABLE Bolumler(
Bolum_No int NOT NULL,
Bolum_Adi nchar(50) NULL,
PRIMARY KEY (Bolum_No))

create table Calisanlar(
TC_No nvarchar(11) not null,
Adi nvarchar(100) not null,
Bolum_No int null,
Cinsiyet nchar(1) null
primary key (TC_No),
foreign key (Bolum_No) references Bolumler(Bolum_No)
)
create table Urunler(
Urun_No int not null,
Urun_Adi nvarchar (50) not null,
Urun_Sayisi int null,
Urun_Fiyati decimal(18,2) null,
Bolum_No int NOT NULL,
primary key (Urun_No),
foreign key (Bolum_No) references Bolumler(Bolum_No)
)
create table Satislar(
Satis_No int not null,
Urun_No int null,
Calisan_TC_No nvarchar(11) null,
Miktar int null,
Fiyat decimal(18,2) null,
Tarih Date null,
primary key (Satis_No),
foreign key (Urun_No) references Urunler(Urun_No),
foreign key (Calisan_TC_No) references Calisanlar(TC_No)
)

-- Commit ve Rollback
begin
begin try
 begin transaction
	update Calisanlar set Adi = 'Ali' where TC_No = '987654321'
	update Bolumler Set Bolum_Adi = 'Ev Aleti' where Bolum_No = 15
	commit tran
	Print 'Kayýt güncellendi'
 end try
 begin catch
	rollback transaction --eðer yukarýdaki kodlarda hata oluþursa deðiþiklikleri geri al
	Print 'Kayýt güncellenemedi hata oluþtu!'
 end catch
end
*/
	-- SQL Constraints(Kýsýtlayýcýlar)
 --Kýsýtlayýcý Çeþitleri
 -- PRIMARY KEY Birincil anahtar kýsýtlayýcý

 -- FOREIGN KEY – YABANCI ANAHTAR KISITLAYICI

 -- UNIQUE Tekil alan kýsýtlayýcýsý

 -- truncate table kullanicilar

 -- Triggers-TETÝKLEYÝCÝLER : yapýlan bir eylem sonrasý baþka bir eylemin yapýlmasý tetiklenebilinir.
 /*
	MsSql de 2 çeþit tetikleyici vardýr
		1- Ardý sýra tetikleyiciler;
		2- Yerine Tetikleyiciler ;
 

	-- STORED PROCEDURE (Saklý Yordam) ve Fonksiyon Kullanýmý
-- Yeni Stored Procedure (Saklý yordam oluþturma)
CREATE PROCEDURE sp_CalisanBolum --sp_CalisanBolum isminde bir SP oluþturduk
AS
BEGIN
select Bolumler.Bolum_adi, Calisanlar.Adi From Bolumler INNER JOIN
 Calisanlar ON Bolumler.Bolum_No = Calisanlar.Bolum_No
--sp_CalisanBolum ün yapacaðý iþlem için ilgili select kodunu yazdýk
END
GO

exec sp_CalisanBolum -- STORED PROCEDURE Çalýþtýrma

CREATE PROCEDURE sp_UrunListele
(@UrunSayisiParametresi int)--SP ye dýþarýdan gelecek ürün sayýsý parametresine göre Ürünleri listeleteceðiz
AS
BEGIN
select * from Urunler where Urun_Sayisi > @UrunSayisiParametresi
END

exec sp_UrunListele 18

-- SP Güncelleme
Alter PROCEDURE sp_UrunListele
(@UrunSayisiParametresi int = 0)--SP ye dýþarýdan gelecek ürün sayýsý parametresine göre Ürünleri listeleteceðiz
AS
BEGIN
select * from Urunler where Urun_Sayisi > @UrunSayisiParametresi
END

CREATE PROCEDURE sp_BolumEkle
(
@BolumAdi nvarchar(50)
)
AS
BEGIN
INSERT INTO Bolumler(Bolum_Adi) VALUES (@BolumAdi)
END

-- KULLANIMI
exec sp_BolumEkle 'Aksesuar'

	-- FONKSÝYONLAR

-- Kullanýcý tanýmlý fonksiyonlar, kullanýcýlar tarafýndan tanýmlanan tek bir deðer veya tablo döndürmek için kullanýlan iliþkisel veritabaný nesneleridir.

	CREATE FUNCTION : Fonksiyon oluþturmak için kullanýlýr
	ALTER FUNCTION : Fonksiyonda deðiþiklik yapmakiçin kullanýlýr.
	DROP FUNCTION : Mevcut olan fonksiyonu silmek için kullanýlýr


CREATE FUNCTION UrunAdet(@urunAdi nvarchar(50))
RETURNS int
AS
BEGIN
DECLARE @urunAdedi int --veri tipi int olan bir deðiþken oluþturduk
SET @urunAdedi=(SELECT Urun_Sayisi FROM Urunler WHERE Urun_Adi=@urunAdi)
RETURN @urunAdedi --select sorgusuyla bulunan urunadedi deðiþken deðerini döndür
END

-- Fonksiyon kullanýmý:
select dbo.UrunAdet('Bilgisayar') as UrunAdedi

-- Tablo Deðerli Fonksiyonlar
create function fn_CalisanlariListele()
returns table
as
return select * from Calisanlar

-- Fonksiyon kullanýmý:
select * from fn_calisanlariListele()

	-- SQL Server Fonksiyonlarý
-- Sql String Fonksiyonlarý
SELECT Left('Left kullanýmý', 6)
SELECT Right('Left kullanýmý', 6)

SELECT Len('Len kullanýmý')

SELECT ProductName, Len(ProductName) as [Ürün adý karakter sayýsý] from Products

SELECT Lower('Küçük HARFE Çevir') as KüçükHarf

SELECT ProductName, Lower(ProductName) as [Ürün adýný küçük harfe çevir], Len(ProductName) as [Ürün adý karakter sayýsý] from Products

SELECT Upper('Büyük HARFE Çevir') --Metni büyük harfe çeviren fonksiyon

SELECT ProductName, Upper(ProductName) as [Ürün adýný büyük harfe çevir] from Products

--AVG() Fonksiyonu : bir ifadenin ortalama deðerini döndürür.
SELECT AVG(UnitPrice) AS OrtalamaÜrünFiyatý FROM Products;

SELECT Min(UnitPrice) AS EnDüþükÜrünFiyatý FROM Products;
*/
SELECT Max(UnitPrice) AS EnYüksekÜrünFiyatý FROM Products;
