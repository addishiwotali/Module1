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

    }
}