			-- SQL SORGULAMA
-- Tablodaki t�m verileri �ekme
-- select * from Products
-- select * from Categories

-- Tablodaki baz� s�tunlar� �ekme
-- select ProductName, UnitPrice from Products

-- Tablodaki alanlara Alias(Takma isim) vererek �a��rma
-- select ProductName as [�r�n Ad�], UnitPrice as [�r�n Fiyat�] from Products

-- Tabloya Alias(Takma isim) vererek �a��rma
-- select p.ProductName as [�r�n Ad�], p.UnitPrice as [�r�n Fiyat�] from Products p
-- select kat.CategoryName as KategoriAd� from Categories kat

/*
	Select Top �fadesi
	Sorgu sonucunda t�m kay�tlar yerine belirli say�da kayd� �ekmemizi sa�lar

SELECT TOP (50) * FROM Products

select top (10) ProductName, UnitPrice, UnitsInStock from Products -- �r�nler tablosundan �stten 10 �r�n� se� ve ProductName, UnitPrice, UnitsInStock alanlar�n� getir

			Order by ile S�ralama

SELECT * FROM Products order by UnitsInStock asc --�r�nleri UnitsInStock alan�na g�re k���kten b�y��e do�ru s�ralayarak getir

SELECT * FROM Products order by UnitsInStock desc --�r�nleri UnitsInStock alan�na g�re b�y�kten k����e do�ru s�rala

			SQL Operat�rleri
	1-SQL Aritmetik Operat�rler

--Toplama (+)
SELECT 10 + 8
--��karma (-)
SELECT (30-12)
--�arpma (*)
SELECT 9 * 2
--B�lme (/)
SELECT 36 / 2
--Modulo (%)
SELECT 18 % 2

		2-SQL Kar��la�t�rma Operat�rleri

-- E�ittir (=)
SELECT * FROM Products WHERE UnitPrice = 18;

select * from Products where CategoryID = 3 -- CategoryID si 3 e e�it olanlar� getir.

select * from Products where ProductName = 'pavlova'

-- B�y�kt�r (>)

SELECT * FROM Products WHERE UnitPrice > 18;
 -- K���kt�r (<)
SELECT * FROM Products WHERE UnitPrice < 18;

SELECT * FROM Products WHERE UnitsInStock < 1;
-- B�y�k E�ittir (>=)

SELECT * FROM Products WHERE UnitPrice >= 18;

SELECT * FROM Products WHERE UnitsInStock >= 99;

-- K���k E�ittir (<=)

SELECT * FROM Products WHERE UnitPrice <= 18;

-- E�it De�ildir
-- SELECT * FROM Products WHERE UnitPrice <> 18;

SELECT * FROM Products WHERE UnitPrice != 18;

		3-Mant�ksal Operat�rler

-- And(&) Ve Operat�r� ile �oklu filtre
SELECT * FROM Products Where SupplierID = 1 and CategoryID = 1--Supplier(Tedarik�i) �r�nlerden SupplierID si 1 olan ve kategori �d si 1 olan �r�nleri getir

-- Or(|) Ve Operat�r� ile �oklu filtre
SELECT * FROM Products Where SupplierID = 1 or CategoryID = 1

-- Not(De�il) Operat�r�
SELECT * FROM Products Where not SupplierID = 1 and CategoryID = 1

		4-Di�er Operat�rler

-- SQL BETWEEN Operator�

SELECT * FROM Products WHERE UnitPrice BETWEEN 10 AND 20;

SELECT * FROM Products WHERE UnitPrice not BETWEEN 10 AND 20;

-- Like Operator� �le Arama, Filtreleme ��lemi

select * from Products where ProductName like 'a%' --�r�nlerden �r�n ad� a ile ba�layanlar� getir

SELECT * FROM Customers WHERE ContactName LIKE 'a%'; --M��terilerden ad� a ile ba�layanlar� getir

SELECT * FROM Customers WHERE ContactName LIKE '%a'; --M��terilerden ad� a ile bitenleri getir

SELECT * FROM Customers WHERE ContactName LIKE '%or%'; --M��terilerden ad� or i�erenleri getir

	SQL IN-Not IN Operator�
ilgili s�tunda istedi�imiz de�erleri i�erenleri in ile i�ermeyenleri not in
ile filtreleyebiliriz

SELECT * FROM Customers WHERE Country IN ('Germany', 'France', 'UK'); -- Customers tablosundaki m��terilerden Country kolonu 'Germany', 'France', 'UK' de�erlerini i�erenleri getir.

SELECT * FROM Customers WHERE Country Not IN ('Germany', 'France', 'UK');

-- �� i�e ili�kili veri okuma
select * from Customers where Country in (select Country from Suppliers)--M��terilerden Country alan�nda Suppliers(tedarik�i) tablosunun �lke alan�nda ge�enleri getir

		Tablodan veri okurken hesaplama
 * �r�n stoklar� eritildi�inde kazan�lacak para

select p.ProductName as [�r�n Ad�], p.UnitPrice as [�r�n Fiyat�], p.UnitsInStock as [Stok Miktar�], p.UnitsInStock * p.UnitPrice as [Toplam Kazan�]
from Products p

	-- SQL NULL De�erler
select ShipName, ShipRegion from Orders where ShipRegion is null --Sipari�lerden ShipName ve ShipRegion alanlar�n� ShipRegion alan� null olanlara g�re �ek

select ShipName, ShipRegion from Orders where ShipRegion is not null

	-- SQL SELECT DISTINCT Kullan�m� : Sorgu sonucunda kay�t tekrar�n� engellemeyi sa�lar
SELECT Country FROM Customers order by Country

SELECT DISTINCT Country FROM Customers

	-- SQL Joins �le Tablolarda Birle�ik Sorgu Olu�turma
-- SQL JOIN T�rleri
	1-(INNER) JOIN: Her iki tabloda da e�le�en de�erlere sahip kay�tlar� d�nd�r�r
	2-LEFT (OUTER) JOIN: Soldaki tablodan t�m kay�tlar� ve sa� tablodan e�le�en kay�tlar� d�nd�r�r
	3-RIGHT (OUTER) JOIN: Sa� tablodan t�m kay�tlar� ve soldaki tablodan e�le�en kay�tlar� d�nd�r�r
	4-FULL (OUTER) JOIN: Sol veya sa� tabloda bir e�le�me oldu�unda t�m kay�tlar� d�nd�r�r

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

-- Join ile ikiden fazla tablo birle�tirme
SELECT Orders.OrderID, Customers.ContactName, Shippers.CompanyName
FROM ((Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID);

-- SQL LEFT JOIN
select Customers.ContactName, Orders.OrderID --Customers tablosundan ContactName alan�n�, Orders tablosundan OrderID alan�n� getir
from Customers --Customers tablosundan
Left Join Orders --left join ile solda birle�tirme i�lemi yap�l�r ve Customers tablosunda olan ama orders tablosunda olmayan kay�tlar da getirilir, inner join den fark� budur inner join sadece e�le�en kay�tlar� getirir
on Customers.CustomerID = Orders.CustomerID --tablolar�m�z� ortak noktalar� olan CustomerID ye g�re e�le�tirdik
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
-- UNION komutu, iki veya daha fazla SELECT deyiminin sonu� k�mesini birle�tirmek i�in kullan�l�r.
SELECT City FROM Customers
UNION
SELECT City FROM Suppliers
ORDER BY City;

SELECT City FROM Customers
UNION All -- all tekrar eden kay�tlar� da getirir.
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
	Print 'Kay�t g�ncellendi'
 end try
 begin catch
	rollback transaction --e�er yukar�daki kodlarda hata olu�ursa de�i�iklikleri geri al
	Print 'Kay�t g�ncellenemedi hata olu�tu!'
 end catch
end
*/
	-- SQL Constraints(K�s�tlay�c�lar)
 --K�s�tlay�c� �e�itleri
 -- PRIMARY KEY Birincil anahtar k�s�tlay�c�

 -- FOREIGN KEY � YABANCI ANAHTAR KISITLAYICI

 -- UNIQUE Tekil alan k�s�tlay�c�s�

 -- truncate table kullanicilar

 -- Triggers-TET�KLEY�C�LER : yap�lan bir eylem sonras� ba�ka bir eylemin yap�lmas� tetiklenebilinir.
 /*
	MsSql de 2 �e�it tetikleyici vard�r
		1- Ard� s�ra tetikleyiciler;
		2- Yerine Tetikleyiciler ;
 

	-- STORED PROCEDURE (Sakl� Yordam) ve Fonksiyon Kullan�m�
-- Yeni Stored Procedure (Sakl� yordam olu�turma)
CREATE PROCEDURE sp_CalisanBolum --sp_CalisanBolum isminde bir SP olu�turduk
AS
BEGIN
select Bolumler.Bolum_adi, Calisanlar.Adi From Bolumler INNER JOIN
 Calisanlar ON Bolumler.Bolum_No = Calisanlar.Bolum_No
--sp_CalisanBolum �n yapaca�� i�lem i�in ilgili select kodunu yazd�k
END
GO

exec sp_CalisanBolum -- STORED PROCEDURE �al��t�rma

CREATE PROCEDURE sp_UrunListele
(@UrunSayisiParametresi int)--SP ye d��ar�dan gelecek �r�n say�s� parametresine g�re �r�nleri listeletece�iz
AS
BEGIN
select * from Urunler where Urun_Sayisi > @UrunSayisiParametresi
END

exec sp_UrunListele 18

-- SP G�ncelleme
Alter PROCEDURE sp_UrunListele
(@UrunSayisiParametresi int = 0)--SP ye d��ar�dan gelecek �r�n say�s� parametresine g�re �r�nleri listeletece�iz
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

	-- FONKS�YONLAR

-- Kullan�c� tan�ml� fonksiyonlar, kullan�c�lar taraf�ndan tan�mlanan tek bir de�er veya tablo d�nd�rmek i�in kullan�lan ili�kisel veritaban� nesneleridir.

	CREATE FUNCTION : Fonksiyon olu�turmak i�in kullan�l�r
	ALTER FUNCTION : Fonksiyonda de�i�iklik yapmaki�in kullan�l�r.
	DROP FUNCTION : Mevcut olan fonksiyonu silmek i�in kullan�l�r


CREATE FUNCTION UrunAdet(@urunAdi nvarchar(50))
RETURNS int
AS
BEGIN
DECLARE @urunAdedi int --veri tipi int olan bir de�i�ken olu�turduk
SET @urunAdedi=(SELECT Urun_Sayisi FROM Urunler WHERE Urun_Adi=@urunAdi)
RETURN @urunAdedi --select sorgusuyla bulunan urunadedi de�i�ken de�erini d�nd�r
END

-- Fonksiyon kullan�m�:
select dbo.UrunAdet('Bilgisayar') as UrunAdedi

-- Tablo De�erli Fonksiyonlar
create function fn_CalisanlariListele()
returns table
as
return select * from Calisanlar

-- Fonksiyon kullan�m�:
select * from fn_calisanlariListele()

	-- SQL Server Fonksiyonlar�
-- Sql String Fonksiyonlar�
SELECT Left('Left kullan�m�', 6)
SELECT Right('Left kullan�m�', 6)

SELECT Len('Len kullan�m�')

SELECT ProductName, Len(ProductName) as [�r�n ad� karakter say�s�] from Products

SELECT Lower('K���k HARFE �evir') as K���kHarf

SELECT ProductName, Lower(ProductName) as [�r�n ad�n� k���k harfe �evir], Len(ProductName) as [�r�n ad� karakter say�s�] from Products

SELECT Upper('B�y�k HARFE �evir') --Metni b�y�k harfe �eviren fonksiyon

SELECT ProductName, Upper(ProductName) as [�r�n ad�n� b�y�k harfe �evir] from Products

--AVG() Fonksiyonu : bir ifadenin ortalama de�erini d�nd�r�r.
SELECT AVG(UnitPrice) AS Ortalama�r�nFiyat� FROM Products;

SELECT Min(UnitPrice) AS EnD���k�r�nFiyat� FROM Products;
*/
SELECT Max(UnitPrice) AS EnY�ksek�r�nFiyat� FROM Products;
