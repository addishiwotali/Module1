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

        Console.WriteLine(AreaOfACircle(5));

        static double AreaOfTriangle(double baseLength, double height)
        {
            var bH =  baseLength * height;
            var area = bH / 2;
            return area;
        }
        Console.WriteLine(AreaOfTriangle(10,5));




        static double AreaOfRectangle(double width, double height)
        {
            var area = width * height;
            return area;
        }
        Console.WriteLine(AreaOfRectangle(10,5));



        static double AreaOfSquare(double side)
        {
            var area = side * side;
            return area;
        }
        Console.WriteLine(AreaOfSquare(10));
    } 
    
}

