using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //ForEachLoop();
            //WhileLoop();
            DoWhileLoop();
            Console.ReadKey();
        }

        static void ForLoop()
        {
            int numberOfTacos = 10;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < numberOfTacos; numberOfTacos--)
            {
                Console.WriteLine($"I eat a taco and now I have {numberOfTacos} Tacos!");
                System.Threading.Thread.Sleep(100);
                Console.WriteLine("nom nom nom nom");
            }

            Console.WriteLine("Now I am sad because I have no more tacos.");
        }

        static void ForEachLoop()
        {
            string[] shrimp = {"Pineapple Shrimp", "Coconut Shrimp", "Blackened Shrimp", "Shrimp Gumbo", "Shrimp Parm", "Shrimp Cocktail", "Cajun Shrimp", "Shrimp Scampi"};

            foreach (var item in shrimp)
            {
                Console.WriteLine($"I like {item}.");
            }
        }

        static void WhileLoop()
        {
            int i = 0;

            while (i < 11)
            {
                Console.WriteLine($"i = {i}");
                i++;
            }
        }

        static void DoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"Hey there dooood. {i}");
                i++;
            } while (i > 10);
        }
    }
}
