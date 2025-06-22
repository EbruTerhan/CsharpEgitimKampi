using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü


            //string[] cities = {"Milano","Roma","Budapeşte","Ankara","İstanbul","Varşova"};

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 45, 785, 948, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);  
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion,

            #region Örnek Sınav Sistemi Uygulaması


            Console.WriteLine("***** C# Eğitim Kampi Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //öğrenci isimlerini ve not ortalamalaranı saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz:");
                studentNames[i] = Console.ReadLine();
                double totalExamResault = 0;


                //her öğrenci için 3 sınav girişi 

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double Value = double.Parse(Console.ReadLine());
                    totalExamResault += Value;/* notları topluyoruz*/
                    Console.WriteLine();

                }
                studentExamAvg[i] = totalExamResault / 3;
            }
            //Sınav ortalamalaı
            for (int i = 0; i < studentCount; i++)
            {
                
                Console.Write($" {studentNames[i]} isimli öğrencinin ortalaması {studentExamAvg[i]} ");

                //öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($" {studentNames[i]} adlı öğenci geçti");
                }
                else
                {
                    Console.WriteLine($" {studentNames[i]} adlı öğrenci dersten kaldı ");
                }
                Console.WriteLine("------------------------------");

            }








            #endregion
            Console.WriteLine();
        }
    }
}
