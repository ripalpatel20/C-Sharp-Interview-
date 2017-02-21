using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter ship name?");
            string ship_name = System.Console.ReadLine();
            Console.WriteLine();
            drawArray b = new drawArray();
            player p = new player();
            p.Randomize();
            while (p.getHitCount() < 12)
            {
                b.displayArray(p.GetGrid());
                p.AskCoordinates(ship_name);
            }
            Console.WriteLine("Congratulations, " + ship_name + "! You Win!");
            Console.WriteLine("Thanks for playing!");
        }


    }
}
