using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //geriye değer döndümeyen metotlar
            //Customer ------> Listele,ekle,sil,güncelle
            //void -----> geriye değe döndürmeyen metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();














            #endregion

            #region Geiye değer döndürmeyen string  parametreli metotlar

            //void WriteMethod (string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");










            #endregion

            #region Geiye değer döndürmeyen int parametreli metotlar

            //void  Sum(int number1, int number2, int number3)
            //{
            //    int resault = number1 + number2 + number3;
            //    Console.WriteLine(resault);
            //}
            //Sum(4, 5, 6);


            #endregion

            #region geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string Name = "Ali";
            //    string surName = "Kaya";

            //    return Name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());








            #endregion

            #region  geriye değer döndüren string parametreli metotlar


            //string CountryCard(string CountryName, string Capital, string FlagColor)
            //{
            //    string CardInfo = (" - Ülke " + CountryName + " - Başkent: " + Capital + " " + " - Bayrak Rengi " + FlagColor);
            //    return CardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Girniz:");
            //x = Console.ReadLine();

            //Console.Write("Başkenti  Giriniz:");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye " , "Ankara" , "Kırmızı-beyaz"));
















            #endregion

            #region geriye değer döndüren int  parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int resualt = number1 + number2;
            //    return resualt;

            //}
            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));





            #endregion
            #region Örnek Uygulama

            //string ExamResault(string student, int exam1, int exam2, int exam3)
            //{
            //    int resault = (exam1 + exam2 + exam3) / 3;
            //    if (resault >= 50)
            //    {
            //        return student + " İsimli öğrenci sınavı geçti " + "Ortalama: " + resault;
            //    }
            //    else
            //    {
            //        return student + " İsimli öğrenci sınavı geçemedi " + "Ortalama: " + resault;
            //    }
            //}
            //Console.WriteLine(ExamResault("Ali", 25, 41, 55));
            //Console.WriteLine(ExamResault("Ayşe", 36, 88, 33));

            #endregion

            Console.Read();

        }
    }
}
