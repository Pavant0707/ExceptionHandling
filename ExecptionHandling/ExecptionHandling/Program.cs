using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExecptionHandling
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Enter the digit");
            //    int i = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter the digit");
            //    int j = Convert.ToInt32(Console.ReadLine());
            //    if (i != 0)
            //    {
            //        int c = i % j;
            //        Console.WriteLine(c);
            //    }
            //    else
            //    {
            //        throw new Exception("enter the digit ");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("dd");
            //}
            //try
            //{
            //    Console.WriteLine("enter");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    if (a > 0 && a < 1000)
            //    {
            //        Console.WriteLine("entred value is  ");

            //    }
            //    else
            //    {
            //        throw new Exception("no");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //try
            //{
            //    int[] a = { 1, 2, 3 };
            //    int sum = 0;
            //    {
            //        if (a.Length > 0)
            //        {
            //            for (int i = 0; i < a.Length; i++)
            //            {
            //                sum = sum + a[i];
            //                Console.WriteLine(sum);
            //            }
            //        }
            //        else
            //        {
            //            throw new Exception("it is empty ");
            //        }
            //    }

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    if (n != 0)
            //    {
            //        Console.WriteLine(Math.Sqrt(n));
            //    }
            //    else
            //    {
            //        throw new Exception("enter the non negitive number");
            //    }
            //}
            //catch(ArithmeticException e){
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter the string");
            //string str = Console.ReadLine();
            //try
            //{
            //    String name = "";
            //    throw new NullReferenceException("its null pointer");

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //String upStr=str.ToUpper();
            //Console.WriteLine(upStr);

           
           
            try
            {
                if (Regex.IsMatch("17/02/2024", @"^\d{0,2}[/]\d{0,2}[/]\d{2,4}"))
                {
                    Console.WriteLine("a");
                }
                else
                {
                    throw new FormatException("w");
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
      


    }
    }

