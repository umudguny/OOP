using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            
            
            ProductManager productManager = new ProductManager();   
            productManager.Add();   
            productManager.Update();   


            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "Umut";
            customer.LastName = "Güney";


            Customer customer2 = new Customer
            {
                City="İstanbul",FirstName="Engin",LastName="Demiroğ",Id=2 

            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();

        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }
        public void Update() 
        {
            Console.WriteLine("Customer Updated");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated");
        }
    }
}
