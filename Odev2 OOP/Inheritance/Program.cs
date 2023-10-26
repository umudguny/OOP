using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Engin"},
                new Student{FirstName="Umut"},
                new Person{FirstName="Salih"}
            };
            foreach (Person person in persons) 
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        // ***bir nesneyi bir kez inheritence alabiliyoruz birden fazla implement edebiliyoruz.
        // Classların tek başına anlamı vardır.İnterfacelerin yoktur.
        
        class Customer : Person// Customer ebeveyni Persondır.
        {
            public string City {  get; set; }   
        }
        class Student : Person
        {
            public string Department { get; set; }
        }
        //*** İnterfaceler inheritence mantıgıyla da kullanabildiği için genelde interface tercih etmeliyiz galiba.
    }
}
