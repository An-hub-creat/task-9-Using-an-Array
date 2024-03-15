using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 1;
        double b = -3;
        double c = 2;

        double[] solutions = SolveQuadratic(a, b, c);

        Console.WriteLine("x1 = " + solutions[0]);
        Console.WriteLine("x2 = " + solutions[1]);
    }

    static double[] SolveQuadratic(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        double[] solutions = new double[2];

        if (discriminant >= 0)
        {
            solutions[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
            solutions[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }
        else
        {
            // Complex roots, set both solutions to NaN
            solutions[0] = double.NaN;
            solutions[1] = double.NaN;
        }

        return solutions;
    }
}