
using System;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {

            var number = 200;
            if (number >=0 && number <= 100)
            {
                Console.WriteLine("number is between 0-100");
            }
            else if (number>100 && number<=200)
            {
                Console.WriteLine("number is between 101-200");
            }
            else if(number> 200 || number <0)
            {
                Console.WriteLine("number is less than 0 or greater than 200");
            }

            Console.ReadLine();
            
        }
    }
}
