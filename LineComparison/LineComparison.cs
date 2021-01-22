using System;
class LineComparison
{
    public static void Length_Comparision1()
    {
        double first_line_length = 0.0, second_line_length = 0.0;
        for (int length = 0; length < 2; length++)
        {
            Console.WriteLine("Read the Point P CO-Ordinates");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Read the Point Q Co-Ordinates");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            if (length == 0)
                first_line_length = (Math.Sqrt(x + y));
            if (length == 1)
                second_line_length = (Math.Sqrt(x + y));
        }
        if (first_line_length.Equals(second_line_length))
            Console.WriteLine("Both Lines are Equal in Length :" + " " + first_line_length);
        else
        {
            if (first_line_length > second_line_length)
                Console.WriteLine("First Line" + " " + first_line_length + "is greater then second line ");
            else
                Console.WriteLine("Second Line" + " " + second_line_length + " is greater then first line ");

        }
    }
    public static void Length_Comparision2()
    {
        double first_line_length = 0.0, second_line_length = 0.0;
        for (int length = 0; length < 2; length++)
        {
            Console.WriteLine("Read the Point P CO-Ordinates");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Read the Point Q Co-Ordinates");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            if (length == 0)
                first_line_length = (Math.Sqrt(x + y));
            if (length == 1)
                second_line_length = (Math.Sqrt(x + y));
        }
        Console.WriteLine("Difference Between Two Length" + " " +Math.Abs( first_line_length.CompareTo(second_line_length)));
    }

    static void Main(string[] args)
    {
        Random random = new Random();
        int check = random.Next(0, 2);
        if (check == 1)
            Length_Comparision1();
        else
            Length_Comparision2();
    }
}
   

