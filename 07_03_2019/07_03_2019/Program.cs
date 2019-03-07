using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_03_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Churr bro. Chuck in a number.");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Chuck in a second num bro ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            { Console.WriteLine($"{num1} is larger then  {num2}");
                Console.ReadLine(); }
            else if (num1 == num2)
            { Console.WriteLine("the two numbers you have enetered are equal"); }

            else 
                       { Console.WriteLine($"{num2} is greater then {num1}"); }
            Console.ReadLine(); */
            //Task 2 //
            Random rand = new Random();
            int number = rand.Next(1, 11);
            Console.WriteLine("Please guess a number between 1-10");
            int user = int.Parse(Console.ReadLine());
            
            if (user > number)
            { Console.WriteLine("Sorry but your guesss was to high")}
            Console.ReadLine();
            else (user == number)



            

                        
                       



           


        }
    }
}
