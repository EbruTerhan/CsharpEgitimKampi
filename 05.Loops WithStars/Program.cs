﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Loops_WithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yan yana 10 tane yıldız oluşturma
            //for (int i =1; i <=10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            #endregion

            #region Dik Üçgen 

            //for (int i =1; i <= 5; i++)
            //{
            //   for (int j =1;j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //   Console.WriteLine();         
            //}


            #endregion

            #region Ters dik üçgen
            //for (int i = 5;  i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve ters dik üçgen beraber
            //for (int i= 1; i<= 5; i++)
            //{
            //    for ( int j= 1; j<= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            // for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region  Baklava dilimi 
            //Üst kısım
            //int n = 5;
            //for ( int i = 1;  i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //     for (int k = 2; k <= 2 * i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            // //Alt kısım
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}


























            #endregion

            #region Piramit

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    // Boşluklar için 
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızlar için
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region ters piramit 

            //int n = 5;
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            #endregion























            Console.Read();
        }
    }
}
