//Fractions
using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
        // Step 5
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalVaule());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString()); // Copy and Paste from line 11 Change f#
        Console.WriteLine(f2.GetDecimalVaule()); // Copy and Paste from line 12 Change f#

        // Step 6
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString()); // Copy and Paste from line 11 Change f#
        Console.WriteLine(f3.GetDecimalVaule()); // Copy and Paste from line 12 Change f#

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString()); // Copy and Paste from line 11 Change f#
        Console.WriteLine(f4.GetDecimalVaule()); // Copy and Paste from line 12 Change f#

    }
}