using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //var result = Add2(20,10);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1,number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,4));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }
        static void Add() {
            Console.WriteLine("Added!");
        }   
        static int Add2(int number1,int number2=30)// number2ye değer verilmez ise default değer olarak 30u kullan anlamına gelir.
        {
            return number1+number2;
        }
        static int Add3(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        // out ve ref keywordleri mantıgı aynıdır. ref keywordünü kullanırken number1 değişkeni tanımlı olmalı fakat out için böyle bi kural yok.

        static int Multiply(int number1,int number2)
        {
            return number1*number2;
        }

        // Method overloading 
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }

        // params keywordü ile diziyi method olarak gönderebiliyoruz.
        // yukarıda gönderdiğimiz 1 int number parametresine yerleşmiş oldu.
        static int Add4(int number,params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
