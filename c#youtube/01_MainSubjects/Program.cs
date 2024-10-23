using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkenler
            //    //double number = 12.25;
            //    //Console.WriteLine(number);


            //    double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //    applePrice =21.45;
            //    orangePrice = 45.14;
            //    strawberryPrice = 54.50;
            //    potatoPrice = 12.0;
            //    tomatoPrice = 25.99;

            //    Console.WriteLine("------------FİYAT lİSTESİ------------");
            //    Console.WriteLine("Elma: " + applePrice + "Tl");
            //    Console.WriteLine("Portakal: " + orangePrice + "Tl");
            //    Console.WriteLine("Çilek: " + strawberryPrice + "Tl");
            //    Console.WriteLine("Patates: " + potatoPrice + "Tl");
            //    Console.WriteLine("Domates: " + tomatoPrice + "Tl");

            //    double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //    appleGram = 1.245;
            //    orangeGram = 2.450;
            //    strawGram = 0;
            //    potatoGram = 10.879;
            //    tomatoGram = 3.345;

            //    double appleTotalPrice, orangeTotalPrice, strawTotalPrice, potatoTotalPrice, tomatoTotalPrice;

            //    appleTotalPrice = applePrice * appleGram;
            //    orangeTotalPrice = orangePrice * orangeGram;
            //    strawTotalPrice = strawberryPrice * strawGram;
            //    potatoTotalPrice= potatoGram* potatoPrice;
            //    tomatoTotalPrice = tomatoGram * tomatoPrice;
            //    Console.WriteLine();
            //    Console.WriteLine();

            //    Console.WriteLine("---------FİŞ-------------");
            //    Console.WriteLine("Elma:" +appleTotalPrice + " Tl");
            //    Console.WriteLine("Portakal:" +orangeTotalPrice + " Tl");
            //    Console.WriteLine("Çilek:" +strawTotalPrice + " Tl");
            //    Console.WriteLine("Patates:" +potatoTotalPrice + " Tl");
            //    Console.WriteLine("Domates:" +tomatoTotalPrice + " Tl");
            //    double totalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //    Console.WriteLine("Toplam Tutar: " + (appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice));

            //    Console.WriteLine("Toplam Tutar: "+ totalPrice);


            #endregion



            #region Char Değişkenler
            //sezar şifreleme : her bir karakterin alfabedeki o harften 3 karakter sonra
            //olan yazılır a ise d yazılır.

            //char harf = 'a';
            //char symbol = '₺';
            //Console.WriteLine(symbol);


            #endregion


            #region klavyeden veri girişleri string değişkenler


            //Console.WriteLine("Yolcu Bilgi Ekranı");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerIdentityNumber,departure,arrival;

            //Console.WriteLine();

            //Console.Write("Yolcu Adı: ");
            //passengerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadı");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine("Yolcu: "+passengerName+ " "+passengerSurname) ;
            //Console.WriteLine();

            //Console.Write("Kalkış Yeri:");
            //departure=Console.ReadLine();

            //Console.Write("Varış Yeri ");
            //arrival=Console.ReadLine();

            //Console.WriteLine("Kalkış Yeri: " + departure +" "+ "Varış Yeri: "+ arrival);

            #endregion


            #region klavyeden tam sayı girişi ve dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Ayakkabı sayısı:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Bilgisayar sayısı: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Sandalye sayısı: ");
            //chairCount = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Tv sayısı: ");
            //tvCount = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("------Fiş------");
            //Console.WriteLine();
            //Console.WriteLine("Ayakkabı: " + shoesCount + " * " + shoesPrice + " = " + (shoesPrice * shoesCount));
            //Console.WriteLine("Bilgisayar: " + computerCount + " * " + computerPrice + " = " + (computerPrice * computerCount));
            //Console.WriteLine("Sandalye: " + chairCount + " * " + chairPrice + " = " + (chairPrice * chairCount));
            //Console.WriteLine("Televizyon: " + tvCount + " * " + tvPrice + " = " + (tvPrice * tvCount));

            //int totalPrice = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);

            //Console.WriteLine("Toplam fiyat: " + totalPrice);

            #endregion

            #region klavyeden ondalıklı sayı girişi

            //double exam1, exam2, exam3;

            //Console.Write("1.Sınav notunuz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("2.Sınav notunuz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.Sınav notunuz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //double result= (exam1+exam2+exam3)/ 3;

            //Console.WriteLine(result);

            #endregion



            #region klavyeden karakter girişi

            //char gender;
            //Console.Write("Karakter seçimi yapın: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine(gender);













            #endregion
            Console.Read();
        }
    }
}
