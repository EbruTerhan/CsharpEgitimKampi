﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ıf else

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine(" Şifre Doğru ");
            //}


            //else
            //{
            //    Console.WriteLine("Şifre Yanlış ");
            //}


            //string capital , country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı ");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı doğru ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}


            //int exam1, exam2, exam3, avarege;
            //string result ="Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarege = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + avarege);

            //if (avarege > 0 & avarege <= 50)
            //{
            //    result = "Sonuç vasat";

            //}
            //if (avarege > 50 & avarege <= 70)
            //{
            //    result = "Sonuç orta";

            //}
            //if(avarege > 70 & avarege <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if(avarege > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.Write(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız:");
            //city = Console.ReadLine();

            //if (city == "Adana" | city == "Ankara" | city == "Bursa" | city == "Trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.WriteLine("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();

            //if(username != "Admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz"); 
            //}

            #endregion

            #region mod işlemler 
            /*
                        int number;
                        number = 26;
                        int result = number % 5;
                        Console.WriteLine(result);
            */
            /*       Console.Write("Lütfen 1. sayıyı giriniz: ");
                   int number1 = int.Parse(Console.ReadLine());

                   Console.Write("Lütfen 2. sayıyı giriniz: ");
                   int number2 = int.Parse(Console.ReadLine());

                   int result = number1 % number2;
                   Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);
       */
            /*        Console.Write("Lütfen sayıyı giriniz: ");
                    int number = int.Parse(Console.ReadLine());

                    if (number % 2 == 0)
                    {
                        Console.Write("Sayı Çiftir ");
                    }
                    else
                    {
                        Console.Write("Sayı tektir ");
                    }
        */
            #endregion

            #region  char değişkenler ile karar yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion

            #region  örnek proje uygulaması 
            //Console.WriteLine("***** C# eğitim kampı restoran ***** ");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1-Ana Yemekler ");
            //Console.WriteLine("2-Çorbalar ");
            //Console.WriteLine("3-Pizzalar ");
            //Console.WriteLine("4-İçecekler ");
            //Console.WriteLine("5-Tatlılar ");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();



            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();  

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı ");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon ");
            //    Console.WriteLine("5-Patlıcan Musaka");
            //    Console.WriteLine("-----------Ana Yemekler----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası ");
            //    Console.WriteLine("-----------Çorbalar----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza ");
            //    Console.WriteLine("2-Margaritha ");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-----------Pizzallar----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-su");
            //    Console.WriteLine("-----------İçecekler----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Traliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("-----------Tatlılar----------");

            //    Console.WriteLine();

            //}

            #endregion

            #region Switch case
            //Console.Write("Lütfen Ay girişi yapınız:");
            //int mounthNumber = int.Parse(Console.ReadLine());

            //switch (mounthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 111: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}


            #endregion

            #region Switch Case hesap makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz:");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz:");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz:");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım" + result);
            //        break;


            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm " + result);
            //        break;
            //}


            #endregion

        }

    }
}
