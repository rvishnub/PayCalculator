using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pay Calculator");

            decimal hours;
            Console.WriteLine("Enter your hours: ");
            hours = Convert.ToDecimal(Console.ReadLine());
            //you can also say string hoursWorked = Console.ReadLine and then convert it to decimal
            //you can do hours = Decimal.Parse(hoursWorked) then do the math

            decimal ratePerHour;
            Console.WriteLine("Enter your rate of pay:");
            ratePerHour = Convert.ToDecimal(Console.ReadLine());

            decimal pay;
            pay = Decimal.Round(hours * ratePerHour, 2);

            Console.WriteLine("Your total pay is $" + pay);
            //you could have done ("Your total pay is: ${0}", pay) {0} IS A PLACEHOLDER
            //you could have done ("Your total pay is: ${0} and you are great.", pay) {0} IS A PLACEHOLDER
            //you could say ("Your pay is {0} and {1}", pay, foo) and define foo as a string

            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }
    }
}