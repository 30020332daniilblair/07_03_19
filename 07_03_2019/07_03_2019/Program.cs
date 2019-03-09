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

            Console.WriteLine("Welcome to Dans billion Doller give away");
            Console.WriteLine("All you have to do is guess the right number and you win a billion dollers! (: ");
            Console.WriteLine("Be warned though you only get one chance...");


            int number = (1);
            Console.WriteLine("Please guess a number between 0-11");
            int user = int.Parse(Console.ReadLine());

            string message = "";

            if (user == number)
            {
                 message = ("CONGRATULATIONS! YOU HAVE WON A BILLION DOLLERS!");
                
            }

            else if (user > number)
            {
                 message = ("sorry but your guess was to high.       ...GAME OVER...");
                
            }

            else if (user < number)
            {
                 message = ("sorry but your guess was to low.         ...GAME OVER...");
                
            }
            else 
            {
                 message = ("Sorry we did not understand that command");
                
            }
            Console.WriteLine(message);
            Console.ReadLine(); 
            


            

                        
                       



           


        }
    }
}
