using System;
using System.Collections.Generic;

public class SuperList : List<double>
{
    public (double Min, double Max) GetMinMax1()
    {
        double min = double.MaxValue;
        double max = double.MinValue;

        foreach (double number in this)
        {
            if (number < min)
                min = number;

            if (number > max)
                max = number;
        }

        return (min, max);
    }

    public (double Min, double Max) GetMinMax2()
    {
        MinMaxPair pair = new MinMaxPair();
        foreach (double number in this)
        {
            if (number < pair.Min)
                pair.Min = number;

            if (number > pair.Max)
                pair.Max = number;
        }

        return (pair.Min, pair.Max);
    }
       public (double Min, double Max) GetMinMax3()
    {
        double min = double.MaxValue;
        double max = double.MinValue;

        foreach (double number in this)
        {
            if (number < min)
                min = number;

            if (number > max)
                max = number;
        }

        return (min, max);
    }

    public (double Minimum, double Maximum) GetMinMax4()
    {
        double minimum = double.MaxValue;
        double maximum = double.MinValue;

        foreach (double number in this)
        {
            if (number < minimum)
                minimum = number;

            if (number > maximum)
                maximum = number;
        }

        return (minimum, maximum);
    }

    private class MinMaxPair
    {
        public double Min { get; set; } = double.MaxValue;
        public double Max { get; set; } = double.MinValue;
    }
}