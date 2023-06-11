// See https://aka.ms/new-console-template for more information
//int deger=2;
//string degisken=null;
//string Degisken=null;
//string degisken_veri=null;
Console.WriteLine("");
byte b =5; // bekllekte 1 byte yer kaplar
sbyte c=5; // bellekte 1 byte yer kaplar

short s=5; // bellekte 2 byte yer kaplar
ushort us=5; // bellekte 2 byte yer kaplar

Int16 i16=2; // 2 byte yer kaplar
int i=2; // 4 byte yer kaplar
Int32 i32=2; // 4 byte yer kaplar
Int64 i64=2; // 8 byte yer kaplar

uint ui=2; //4 byte yer kaplar
long l=4; // 8 byte

ulong l4=4; //8 byte

// Reel Sayılar
float f=5; // 4 byte

double d=5; // 8 byte

decimal de=5; //16 byte

char ch='2'; // 2 byte
string str="Hakan"; // sınırsız

bool b1=true; // 
bool b2=false; //

DateTime dt= DateTime.Now; // Şimdiki tarihi getirir
Console.WriteLine(dt);

// object her türden veriyi atayabilirsiniz.
object o1="x";
object o2='y';
object o3=4;
object o4=4.3;

// string ifadeler

string str1=string.Empty;
str1="Hakan Topcu";
string ad="Hakan";
string soyad="Topcu";
string tamisim=ad+ " "+soyad;

// int ifadeler

int in1=5;
int in2=3;
int in3=in1*in2;

//boolean

bool bool1=10<2;

//Değişken Dönüşümleri
string str20="20";
int int20=20;

string yeniDeger=str20+int20.ToString();

Console.WriteLine(yeniDeger); // Çıktısı 2020

// int dönüşümleri
int int21=int20+Convert.ToInt32(str20);
Console.WriteLine(int21); // Çıktısı 40

int int22=int20+int.Parse(str20); // Çıktısı 40

// Datetime 

string datetime=DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string hour=DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);

