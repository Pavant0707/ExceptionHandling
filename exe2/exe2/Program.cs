using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Enter the number:");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(num);               
            //}catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("aa");
            //}
            try
            {
                Console.WriteLine("enter the String");
                 string str = Console.ReadLine();
               // String str ="";
                //Console.WriteLine(str.ToUpper());
                if (string.IsNullOrEmpty(str))
                {
                    throw new NullReferenceException("exe");
                }
                else
                {
                    Console.WriteLine(str.ToUpper());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //try
            //{
            //    int[] a = new int[2];
            //    a[0] = 1;
            //    a[1] = 2;
            //    a[2] = 3;
            //    foreach(int i in a)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //string path11 = @"C:\FileProg\Program.txt";
            ////File.Create(path11);
            //File.WriteAllText(path11, "writing info ");
            //String str = File.ReadAllText(path11);
            //Console.WriteLine(str);
            //try
            //{
            //    File.OpenRead(path11);
            //    if (File.Exists(path11))
            //    {
            //        Console.WriteLine("file");
            //    }
            //    else
            //    {
            //        throw new IOException("no");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

        }
    }
}
