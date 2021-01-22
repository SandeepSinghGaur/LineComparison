using System;
class LineComparison
{
    static void Main(string[] args)
    {

        Console.WriteLine("Read the Point P CO-Ordinates");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Read the Point Q Co-Ordinates");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        int x = (x2 - x1) * (x2 - x1);
        int y = (y2 - y1) * (y2 - y1);
        double length = (Math.Sqrt(x + y));
        Console.WriteLine("Distance between P and Q is :" + " " + length);

    }
}
