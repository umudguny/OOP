using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Integer

            int number1 = 10;
            Console.WriteLine(number1);
            Console.WriteLine("Number is {0}", number1);

            // hatalı
            //int number1 = 10000000000
            //int number1 = -2147483649

            // Max ve Min değer
            //int number1 = 2147483647
            //int number1 = -2147483648


            //LONG
            
            long number2 = 2147483648;
            Console.WriteLine("Number is {0}", number2);
            
            //long number2 = 9223372036854775807
            //long number2 = -9223372036854775808
            
            //SHORT


            //Bir diğer tam sayı tutan veri tipimiz ise shorttur.
            //int veri tipi 32 bit , long veri tipi 64 bitlik alan kapsarken short veri tipi 16 bitlik bir alanı kapsar.
            //Short tipinde bir değişkenin alabileceği maksimum ve minimum değerler aşağıda verilmiştir.
            short number3 = 32767;
            //short number4 = -32768;
            Console.WriteLine("Number is {0}", number3);


            // BYTE
            //Byte veri tipi bellekte 8 bit yer kaplar.
            //0 ile 255 dahil olmak üzere bu aralıktaki sayıları tutabilir.
            byte number5 = 255;
            Console.WriteLine("Number is {0}", number5);


            //BOOLEAN

            //Mantıksal bir veri tipidir.
            //Değişken olarak true veya false tutar.
            //Koşullu ifadelerde sıklıkla kullanılır.
            bool condition = false;
            bool condition1 = true;


            //Char 

            //String dediğimiz daha sonra göreceğimiz veri tipide aslında bir karakter dizisidir.
            char character = 'A';
            Console.WriteLine("Character is : {0}", (int)character);

            //Double veri tipi ile tam sayıları tutmanın yanı sıra ondalıklı sayılarıda tutabiliriz.
            double number6 = 10;
            double number7 = 10.4;
            Console.WriteLine("Number is {0}", number6);
            Console.WriteLine("Number is {0}", number7);

            //DECİMAL

            //Decimal veri tipi virgülden sonra daha fazla basamak tutan ondalıklı sayıları tutmak için kullanabileceğimiz bir veri tipidir.
            //Özellikle para birimi gibi verileri tutarken kullanılır.
            
            decimal number8 = 10.4m;// m decimal değer olduğunu belirtir.
            Console.WriteLine("Number is {0}", number8);

            //Var Keyword
            //Bir değişken değildir fakat herhangi bir değişkeni tutmak için kullanırız.
           
            var number9 = 10;
            number9 = 'A'; 

        }
    }
}
