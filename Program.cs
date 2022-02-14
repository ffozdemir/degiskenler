using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;          //1 byte
            sbyte b = 5;         //1 byte

            short c = 5;         //2 byte
            ushort z = 5;        //2 byte

            Int16 i16 = 2;       //2 byte
            int i = 2;           //4 byte
            Int32 i32 = 2;       //4 byte
            Int64 i64 = 2;       //8 byte

            uint ui = 2;         //4 byte
            long l = 4;          //8 byte
            ulong ul = 4;        //16 byte
        
        //REEL SAYILAR
            float f = 123.01f;         //4 byte
            double d = 101.05;        //8 byte
            decimal de = 123.04m;      //16 byte

            char ch = (char)55 ;       //2 byte
            string str = "Furkan";//Sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 5.2;

            //STRING İFADELER

            string strl = string.Empty;
            strl= "Furkan Özdemir";
            string ad = "Furkan";
            string soyad = "Özdemir";
            string tamIsim = ad + " " + soyad;

            //INTEGER TANIMLAMA ŞEKİLLERİ

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //DEĞİŞKEN DÖNÜŞÜMLERİ

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); //Çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Çıktısı 40
            
            int int22 = int20+ int.Parse(str20); //çıktısı 40
            
            //DATETIME

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
        
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //SAAT

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

                   }
    }
}
