using System;
class Program
{
    // Method for solving the system of equations
    static void Solve(double a1, double b1, double a2, double b2,
                      double c1, double c2)
    {
        double d = a1 * b2 - a2 * b1;
        double x = (c1 * b2 - c2 * b1) / d;
        double y = (a1 * c2 - a2 * c1) / d;
        Console.WriteLine("c1 = " + c1 + ", c2 = " + c2);
        Console.WriteLine("x = " + x + ", y = " + y);
        Console.WriteLine();
    }
    static void Main()
    {
        // Fixed coefficients
        double a1 = 2;
        double b1 = 1;
        double a2 = 1;
        double b2 = -1;
        // Test 1
        Solve(a1, b1, a2, b2, 5, 1);
        // Test 2
        Solve(a1, b1, a2, b2, 7, 1);
        // Test 3
        Solve(a1, b1, a2, b2, 10, 2);
    }
}
