using System;

namespace question_3
{
    class player
    {
        char[,] Grid = new char[10, 10];
        public int HitCount = 0;
        public int MissCount = 0;
        int x = 0;
        int y = 0;
       

        public int getHitCount()
        {
            return HitCount;
        }
        public int getMissCount()
        {
            return MissCount;
        }
        public void AskCoordinates(String ship_name)
        {
            Console.WriteLine("Enter X");
            string line = Console.ReadLine();
            int value;
            if (int.TryParse(line, out value))
            {
                x = value;
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }

            Console.WriteLine("Enter Y");
            line = Console.ReadLine();
            if (int.TryParse(line, out value))
            {
                y = value;
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }

            try
            {
                if (Grid[x, y].Equals('S'))
                {
                    Grid[x, y] = 'H';
                    Console.Clear();
                    if (HitCount != 11)
                    {
                        Console.WriteLine("Hit " + ship_name);
                        HitCount += 1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sunk " + ship_name);
                        HitCount = 11;
                        
                    }
                }
                else if(Grid[x, y].Equals('H'))
                {
                    Grid[x, y] = 'H';
                    Console.Clear();
                    Console.WriteLine("Already Selected!");
                   
                }
                
                else
                {
                    Grid[x, y] = 'M';
                    Console.Clear();
                    Console.WriteLine("Miss!");
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error: Please enter numbers between 0 and 9. (Inclusive)");
            }
        }
        public char[,] GetGrid()
        {
            return Grid;
        }
        public void SetGrid(int x, int y)
        {
            Grid[x, y] = 'S';
        }
        public void Randomize()
        {
            Random r = new Random(2);
            SetGrid(1, 2);
            SetGrid(2, 2);
            SetGrid(4, 3);
            SetGrid(4, 4);
            SetGrid(4, 5);
            SetGrid(5, 6);
            SetGrid(5, 4);
            SetGrid(5, 3);
            SetGrid(6, 1);
            SetGrid(6, 2);
            SetGrid(6, 3);
            SetGrid(6, 4);

        }
    }
}
