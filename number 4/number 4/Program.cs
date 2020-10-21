using System;

namespace number_4
{
    class Point
    {
        string name;
        int x, y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Enter a letter of Point:");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }
}
