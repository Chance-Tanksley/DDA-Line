using DDA_Line;
using System;
using System.Drawing;

namespace DDA
{
    class Program
    {
        static void Main(string[] args)
        {
            string userIntput;
            int x0 = 0;
            int y0 = 0;
            int x1 = 0;
            int y1 = 0;
            Random rnd = new Random();

            //USER INPUT AND VALIDATION FOR POINT 1
            Console.WriteLine("Please enter an interger for the x cooridinate of a point");
            userIntput = Console.ReadLine();
            while (!int.TryParse(userIntput, out _))
            {
                Console.WriteLine("Please enter an interger");
                Console.ReadLine();
            }
            x0 = int.Parse(userIntput);
            Console.WriteLine("Please enter another interger for the y cooridinate of a point");
            userIntput = Console.ReadLine();
            while (!int.TryParse(userIntput, out _))
            {
                Console.WriteLine("Please enter an interger");
                Console.ReadLine();
            }
            y0 = int.Parse(userIntput);

            //USER INPUT AND VALIDATION FOR POINT 2
            Console.WriteLine("Please enter an interger for the x cooridinate of a point");
            userIntput = Console.ReadLine();
            while (!int.TryParse(userIntput, out _))
            {
                Console.WriteLine("Please enter an interger");
                Console.ReadLine();
            }
            x1 = int.Parse(userIntput);
            Console.WriteLine("Please enter another interger for the y cooridinate of a point");
            userIntput = Console.ReadLine();
            while (!int.TryParse(userIntput, out _))
            {
                Console.WriteLine("Please enter an interger");
                Console.ReadLine();
            }
            y1 = int.Parse(userIntput);
            Console.Clear();

            Line line = new Line(x0, y0, x1, y1);


            line.Draw();
            Console.ReadKey();
            line.Collapse();
            Console.ReadKey();

            //Randomizing input for Perturb
            x0 = rnd.Next(0,10);
            y0 = rnd.Next(0,10);
            x1 = rnd.Next(0,10);
            y1 = rnd.Next(0,10);

            line.Perturb(x0, y0, x1, y0);
            line.Draw();
            Console.ReadKey();

            line.Collapse();





        }
    }
}