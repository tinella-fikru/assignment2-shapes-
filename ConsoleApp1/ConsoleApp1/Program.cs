namespace ConsoleApp1
{
    interface Ishape
    {
        public double calcArea()
        {
            return 0.0;
        }
        public double calcPerimeter()
        {
            return 0.0;
        }
    }

    class circle : Ishape
    {
        static readonly double pi = 3.14;
        public double radius { get; set; }

        public double calcArea()
        {
            double area = pi * radius * radius;
            return area;
        }
        public double calcPerimeter()
        {
            double peri = 2 * pi * radius;
            return peri;
        }
    }
    class rectangle : Ishape
    {
        public double width { get; set; }
        public double length { get; set; }
        public double calcArea()
        {
            double area = width * length;
            return area;
        }
        public double calcPerimeter()
        {
            double peri = 2 * (width + length);
            return peri;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            circle c = new();
            c.radius = 8;
            rectangle r = new();
            r.length = 45;
            r.width = 98;
            Console.WriteLine("the area of the circle is:" + c.calcArea().ToString());
            Console.WriteLine("the perimeter of the circle is:" + c.calcPerimeter().ToString());
            Console.WriteLine("the area of the rectangle is:" + r.calcArea().ToString());
            Console.WriteLine("the perimeter of the rectangle is:" + r.calcPerimeter().ToString());

        }


    }

}

