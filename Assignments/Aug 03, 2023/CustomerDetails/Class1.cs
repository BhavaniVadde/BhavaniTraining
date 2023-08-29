using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDetails
{
   public class Customer
    {
     
        public string Name { get; set; }
        public string Email  { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Product { get; set; }
        public void PrintDetails()
        {
            Console.WriteLine("Customer Details:");
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Email:" + Email);
            Console.WriteLine("Phone:" + Phone);
            Console.WriteLine("Address:" + Address);
            Console.WriteLine("Product:" + Product);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Console.WriteLine("Enter Customer Name: ");
            customer.Name = Console.ReadLine();

            Console.WriteLine("Enter Customer Email: ");
            customer.Email = Console.ReadLine();

            Console.WriteLine("Enter Customer Phone: ");
            customer.Phone = Console.ReadLine();

            Console.WriteLine("Enter Customer Address: ");
            customer.Address = Console.ReadLine();

            Console.WriteLine("Enter Product Name: ");
            customer.Product = Console.ReadLine();

            Console.WriteLine();
            customer.PrintDetails();

        }
    }
}
