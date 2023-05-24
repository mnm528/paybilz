using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayBill
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Enter the bill amount?");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your bill is: " + i * 25);
            Console.Read();
        }
    }
}
