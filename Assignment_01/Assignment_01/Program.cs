using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your address");
            string address = Console.ReadLine();
            Console.WriteLine("enter your contract_number");
            int contract_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I am " + name);
            Console.WriteLine(" my age is " + age);
            Console.WriteLine(" my present address is  " + address);
            Console.WriteLine(" my contract_number here  " + address);
            Console.ReadKey();
        }
    }
}
