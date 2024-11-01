using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        private static int totalLemonadePrice;
        private static int totalPizzaPrice;
        private static string totalLemonadePries;

        static void Main(string[] args, int totalLemonadePrice)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");


            #endregion


            #region  String Değişkenler

            //string 
            //Değişken_türü değişken_adı ;

            //string name;
            //name = "Aleyna";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Özer";
            //customerSurname = "Usta";
            //customerPhone = "05454530840";
            //customerEmail = "ozerusta@gmail.com";
            //district = "Bayrampaşa";
            //city = "İstanbul";

            //Console.WriteLine("****Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi:  " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------------");


            //Console.WriteLine();


            //customerName = "Aleysu";
            //customerSurname = "Kay";
            //customerPhone = "530 868 20 52";
            //customerEmail = "kaynakalina@gmail.com";
            //district = "Beylikdüzü";
            //city = "İstanbul";

            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi:  " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------------");





            #endregion

            #region Int Değişkenler
            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice= 15;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("---Kola: " + cokePrice + "TL");
            Console.WriteLine("---su: " + waterPrice  + "TL");
            Console.WriteLine("---kızartma: " + friesPrice + "TL");
            Console.WriteLine("---pizza: " + pizzaPrice + "TL");
            Console.WriteLine("---limonata: " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice ;
            int totalPizzaCount;
            int totalLemonadeCount;


            hamburgerCount = 3;
            cokeCount=3;
            waterCount=3;
            friesCount =1;
            pizzaCount =0;
            lemonadeCount =0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePries + "TL");



            #endregion
            Console.Read();



        }
    }
}




//Yazdırma Komutları
//Değşkenkler
 //(kaç tane yediğini hesaplarken count ekliyoruz fiyatta price kullanıyoruz)