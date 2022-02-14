
using System;



calc calculator = new calc();

try
{
    Console.WriteLine("--Testing ADD!");
    Console.WriteLine("5 + 5 = " + calculator.Add(5, 5));
    Console.WriteLine("-------------------- Virker!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
    Console.WriteLine("-------------------- Virker IKKE!");
}

Console.WriteLine("--Testing SUBTRACT!");
Console.WriteLine("10 - 5 = " + calculator.Subtract(10, 5));
Console.WriteLine("-------------------- Virker!");

try
{
    Console.WriteLine("--Testing MULTIPLY!");
    Console.WriteLine("-10 * 0 = " + calculator.Multiply(-10, 0));
    Console.WriteLine("-------------------- Virker!");
}
catch (Exception ex)
{
    Console.WriteLine("-------------------- Virker IKKE!");
    Console.WriteLine(ex.ToString());
}

try
{
    Console.WriteLine("--Testing DIVIDE!");
    Console.WriteLine("10 * 0 = " + calculator.Divide(0, 0));
    Console.WriteLine("-------------------- Virker!");
}
catch (Exception ex)
{
    Console.WriteLine("-------------------- Virker IKKE!");
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("--Testing POWER!");
Console.WriteLine("2 to the power of 5 = " + calculator.Power(2, 5));


public class calc
{
    public double Add(double a, double b)
    {
        return a + b;   
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {

        if (a == 0)
        {
            return 0;
        }
        else if (b == 0)
        {
            return 0;
        }

        else {

            return a / b;
        }
        

    }

    public double Power(double x, double exp)
    {
        return Math.Pow(exp, x);
    }
}