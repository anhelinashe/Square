using System;
using System.Drawing;
using System.Transactions;
namespace Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user!");
            Console.WriteLine("Select a type of figure: square,triangle,rectangle,circle");
            string figure = Console.ReadLine(); ;
            if (figure == "square")
            {
                Console.WriteLine("Enter size:");
                float size = float.Parse(Console.ReadLine());
                size = size * size;
                Console.WriteLine($"Area:{size}");
            }
            if (figure == "circle")
            {
                Console.WriteLine("Enter radius:");
                float radius = float.Parse(Console.ReadLine());
                float Square = 3.14f * (radius * radius);
                Console.WriteLine($"Area:{Square}");
            }
            if (figure == "triangle")
            {
                Console.WriteLine("Enter the base: ");
                float baseLength = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height: ");
                float height = float.Parse(Console.ReadLine());
                float area = baseLength * height/2;

                Console.WriteLine($"Area:{area}");
            }
            if (figure == "rectangle")
            {
                Console.WriteLine("Enter the firstside: ");
                float firstside = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the secondside: ");
                float secondside = float.Parse(Console.ReadLine());
                float area1 = firstside * secondside;
                Console.WriteLine($"Area:{area1}");


            }
        }
    }

}
