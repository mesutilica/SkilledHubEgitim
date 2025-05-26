
Console.WriteLine("Hello, World!"); // kod yanına açıklama ekleme
                                    // Console.Write("Merhaba, Dünya! "); // bu kodlar  yorum satırı yapıldı, artık çalışmaz!
                                    //Console.Write(" Muhasebe Programı");
                                    //Console.Read(); // ekrandan 1 karakter bekle
                                    //Console.ReadLine(); // ekrandan 1 satır bekle
                                    //Console.Write("Merhaba, Dünya! ");
 
//C# ta değişken tanımlama
//Tamsayı veri tipleri
byte plaka_kodu; // 0-255 arası değer alır, 1 byte yer kaplar
plaka_kodu = 34; // değişkene değer atama
Console.WriteLine(plaka_kodu); // değişkeni ekrana yazdırma

byte birSayi, birSayiDaha; // bir tiple birden fazla değişken tanımlama
birSayi = 3;
birSayiDaha = 255;
Console.WriteLine(birSayi); // 3
Console.WriteLine(birSayiDaha); // 5

sbyte sbyteTuru = 127;// +127 ile -128 arası değer alabilir
short kisa = 32767; //-32768 ile +32767 arası değer alabilir
ushort birazuzun = 65535; //0 - 65535
int tamsayi = -2147483648;//32bit 4byte +2147483647 -2147483648
uint uzuntamsayi = 4567892;// 0 - 4294967295
long dahauzuntamsayi = 9223372036854775807;
ulong enuzuntamsayi = 18446744073709551615;

//Kesirli Sayı Değişken Tipleri
float kesirliSayi = 4.5f; //4byte yer kaplar 6-7 basamak
double kesirliSayi2 = 4.5; //8byte yer kaplar 15 - 16 basamak

//Decimal Veri Tipi
decimal UrunFiyati = 5500; //12byte, duyarlı basamak 28 - 29

//Char Veri Tipi
char karakter = 'ç';//char sadece 1 tane değer alır ve tek tırnak içine yazılır

//String Veri Tipi
string degisken;
string degisken1, degisken2;
string metin = "string veri tipinde \n \t tüm karakterleri kullanabiliriz"; // \n metinde kendinden sonraki alanın bir alt satırdan devam etmesini, \t ise klavyeden tab tuşuna basmış gibi metni ileri iter
Console.WriteLine(metin);

//Boolean Veri Tipi
//Geriye true veya false dönen veri tipidir, 1byte lık yer kaplar
bool islemSonuc = true;

byte? kilo = null;//eğer bir değişkene başlangıç değeri olarak null vermek istersek veri tipinin yanına ? koyarız
kilo = 66;

short kdv = 20;

int tamsayi2 = 118;

long tamsayi_2;//değişken tanımlamak için değişkenin veri tipini ve adını yazmalıyız
tamsayi_2 = -18000000000;
tamsayi2 = 18;

//* Müşteri id'sini tutacak bir değişken
string musteri_id = "A1213213213";

//* Bir ürünün satışta olup olmadığı bilgisini tutacak değişken
bool? isSatistami = null;
isSatistami = true;
//boolean
bool aktif = false;

//* Maaş bilgisini tutacak bir değişken
decimal asgariUcret = 22104.5645m;

//C# ta değişkenler bellekte stack ve heap adı verilen bölgelerde tutulur
//Değişkenler değer tipli ve referans tipli olmak üzere ikiye ayrılır

//var ile değişken oluşturma

var birdegisken = 18; //var ile oluşturulan değişkenlerde değişkenin veri tipi c# tarafından değişkene atanan değere göre otomatik algılanır
var strmetin = "string metin";
var sonuc = false;

Console.WriteLine("degisken: " + birdegisken.GetType());
Console.WriteLine("strmetin:" + strmetin.GetType());
Console.WriteLine("sonuc:" + sonuc.GetType());

sonuc = true;
// sonuc = 18; // var ile tanımlanan bir değişkenin türü sonradan değiştirilemez, ancak içindeki değer değiştirilebilir.
Console.WriteLine("sonuc:" + sonuc);

Console.WriteLine("object veri tipi:");
object nesne = "bu bir nesnedir"; // Bu değişken türüne her türden veri atanabilir.
Console.WriteLine(nesne + "-Tipi: " + nesne.GetType());
nesne = 18; // object ile tanımlanan nesne değiştirilebilir
Console.WriteLine(nesne + "-Tipi: " + nesne.GetType());


object a = 10; // tam sayı
object b = 'k'; // karakter
object c = "metin"; // string
object d = 12.9f; // float


//C# ta sabit tanımlama
const int kdvOrani = 18;//sabitleri const olarak tanımlayıp program içerisinde kullanabiliriz, sabitlerin değeri tanımlandığı yerde verilir sonradan değişmez
const int iskonto = 25;
//kdvOrani = 20; // sabitlerin değeri sonradan değiştirilemez, bu satır hata verir


Console.WriteLine(tamsayi_2);
Console.WriteLine("Lütfen Bir Tuşa Basınız:");
var deger = Console.ReadLine();//bu komut ekrandan girilen 1 satırlık veriyi yakalamamızı sağlar
Console.WriteLine("Girdiğiniz Değer : " + deger);