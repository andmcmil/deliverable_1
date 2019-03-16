using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_1
{
    class CurrencyProgram
    {
        static void Main(string[] args)
        { //Ask for first number
            Console.WriteLine("Input a number");
            double a = Convert.ToDouble(Console.ReadLine());
            //Ask for second number
            Console.WriteLine("Input a second number");
            double b = Convert.ToDouble(Console.ReadLine());
            //Ask for third number
            Console.WriteLine("Input a third number");
            double c = Convert.ToDouble(Console.ReadLine());
           
            //Total all three numbers and return the result
            double total = a + b + c;
            Console.WriteLine("The total of all 3 numbers is " + total);

            //Find the average of the numbers
            double avg = total / 3;
            Console.WriteLine("The average amount is " + avg);
      


            //Find Maximum/Largest of the numbers
            if (a > b && a > c)
            Console.WriteLine("The largest number is " + a);
            else if (b > a && b > c)
                Console.WriteLine("The largest number is " + b);
            else Console.WriteLine("The largest number is " + c);

            //Find Minimum/Smallest of the numbers
            if (a < b && a < c)
                Console.WriteLine("The smallest number is " + a);
            else if (b < a && b < c)
                Console.WriteLine("The smallest number is " + b);
            else Console.WriteLine("The smallest number is " + c);



            //Display total amount in currency formats of various countries: United States, Sweden, Japan, and Thailand
            Double RoundedTotal = Math.Round(total, 2);
            Double WholeTotal = Math.Round(total,0);
            //Converts output to UTF8 Standard
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //US
            Console.WriteLine("The United States Currency amount is " + "$" + RoundedTotal);
            //Swedish
            Console.WriteLine("The Sweden Currency amount is " + RoundedTotal + " kr");
            //Japanese
            Console.WriteLine("The Japan Currency amount is " + "¥" + WholeTotal);
            //Thai
            Console.WriteLine("The Thailand Currency amount is " + "฿" + RoundedTotal);

            Console.ReadKey();


        }
    }
}
