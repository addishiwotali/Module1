namespace Module1;

class Program
{
    static void Main(string[] args)
    {
        static double AreaOfACircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        Console.WriteLine("Enter radius of a circle:");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area of a circle is {AreaOfACircle(radius)}");

        Console.WriteLine("-------------------------");
        
        

        static double AreaOfTriangle(double baseLength, double height)
        {
            var bH = baseLength * height;
            var area = bH / 2;
            return area;
        }

        Console.WriteLine("Enter height of a triangle:");

        double height = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter length of a triangle:");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine($"Area of triangle is {AreaOfTriangle(baseLength, height)}");
        

       Console.WriteLine("--------------------------");

        static double AreaOfRectangle(double width, double height)
        {
            var area = width * height;
            return area;
        }

        Console.WriteLine($"Enter width of a rectangle:");
        
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Enter height of an rectangle:");
        
        double lenght = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine($"Area of rectangle is {AreaOfRectangle(width,height)}");
        
        
        Console.WriteLine("--------------------------");

        
        static double AreaOfSquare(double side)
        {
            var area = side * side;
            return area;
        }

        Console.WriteLine($"Enter width of a square:");
        
        double side = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine($"Area of square is {AreaOfSquare(side)}");
        
    }
}

