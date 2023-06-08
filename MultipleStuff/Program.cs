using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
             SuperList superList = new SuperList { 2.5, 1.3, 4.7, 3.1, 2.8, 5.2 };

        double min1, max1;
        superList.GetMinMax1(out min1, out max1);
        Console.WriteLine($"1 - Min: {min1}, Max: {max1}");

        var minMax2 = superList.GetMinMax2();
        Console.WriteLine($"2 - Min: {minMax2.Min}, Max: {minMax2.Max}");

        var (min3, max3) = superList.GetMinMax3();
        Console.WriteLine($"3 - Min: {min3}, Max: {max3}");

        var (minimum, maximum) = superList.GetMinMax4();
        Console.WriteLine($"4 - Min: {minimum}, Max: {maximum}");
        }
    }
}
