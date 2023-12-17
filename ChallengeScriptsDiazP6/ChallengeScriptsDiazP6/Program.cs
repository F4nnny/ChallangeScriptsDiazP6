using System;
using System.Globalization;

class Challenges
{
    public static void Main()
    {
        Console.WriteLine("The sum of 1 and 5 is:" + Sum(1, 5));
        Console.WriteLine("There are " + Converter(5) + "seconds in 5 minutes");
        Console.WriteLine("The number is: " + PlusOne(23));
        Console.WriteLine("The power is: " + Power(230, 10));
        Console.WriteLine("15 years old is the same as " + Age(15) + "days old");
        Console.WriteLine("When the base of the base is 4 and the height is 6, then the area is " + Triangle(4, 6));
        int inputNumber = 5;
        bool result = LessThanOrEqualToZero(inputNumber);

        if (result)
        {
            Console.WriteLine($"inputNumber) <= 5; true");
        }
        else
        {
            Console.WriteLine($"(inputNumber) <=5; false");
        }

        Console.WriteLine("77 plus 33 is less than 100, this statement is " + LessThan100(77, 33));
        Console.WriteLine("5478239 is equal to 5478239, this statement is " + EqualTo(5478239, 5478239));
        Console.WriteLine("1 is equal to 6, this statement is " + IsEqual(1, 6));
        Console.WriteLine(GiveMeSomething("is wrong..."));
        Console.WriteLine("False is " + Reverse(false));
        Console.WriteLine("24 hours is also " + howManySeconds(24) + "seconds");
        Console.WriteLine("A polygon with 12 sides has " + sumPolygon(12) + " degree internal angle");
        Console.WriteLine("The name is " + nameString("John"));
        Console.WriteLine(And(true, false));
        Console.WriteLine("There were " + points(3, 13) + " points scored during the game");
        Console.WriteLine("With a width of 12 and a length of 23 then the perimeter is " + findPerimeter(12, 23));
        Console.WriteLine(helloName("Daniel"));
        Console.WriteLine("If there are 5 chickens, 12 cows, and 9 pigs, then there are " + animals(5, 12, 9) + " total legs");
        Console.WriteLine("The football team had 11 wins, 2 draws, and 3 losses, so the team has points" + footballPoints(11, 2, 3));
        Console.WriteLine("This month is " + monthName(12));
        int[] minMax = { 12, -77, 555, 89 };
        Console.WriteLine("The max for the array 12, -77, 555, 89 is " + findMinMax(minMax));
        int[] numbers { 2, 34, -22, 7, -1 };
        Console.WriteLine("The sum of the absolute values of 2, 34, -22, 7, -1 is " + getAbsSum(numbers));
        Console.WriteLine(" The base number 6 multiplied by the exponent 4 has a product of " + calculateExponent(6, 4);
        int[] lengths = { 0, 11, -9, 12, 5 };
        Console.WriteLine("The array 0, 11, -9, 12, 5 multiplied by the length gives the new array " + MulitplyByLength(lengths));
        Console.WriteLine("The hamming distance for the line abcdefgg and abcdefgh is " + HammingDistance("abcdefgg", "abcdefgh"));
    }

    public static int Converter(int minute)
    {
        int sec = minute * 60;
        return sec;
    }

    public static int Sum(int a, int b)
    {
        int c = a + b;
        return c;
    }

    public static int PlusOne(int number)
    {
        int n = number + 1;
        return n;
    }

    public static int Power(int v, int c)
    {
        int p = v * c;
        return p;
    }

    public static int Age(int year)
    {
        int days;
        days = year * 365;
        return days;
    }

    public static int Triangle(int b, int h)
    {
        int a = (b * h) / 2;
        return a;
    }

    public static bool LessThanOrEqualToZero(int number)
    {
        return number <= 5;
    }

    public static bool LessThan100(int a, int b)
    {
        int c = a + b;
        if (c < 100)
        {
            return true;
        }
        return false;
    }

    public static bool EqualTo(int a, int b)
    {
        if (a == b)
        {
            return true;
        }
        return false;
    }

    public static bool IsEqual(int a, int b)
    {
        if (a == b)
        {
            return false;
        }
        return false;
    }

    public static string GiveMeSomething(string s)
    {
        string something = ("Something ");
        s = (something + s);
        return s;
    }

    public static bool Reverse(bool b)
    {
        return b;
    }

    public static int howManySeconds(int s)
    {
        return s * 3600;
    }

    public static int sumPolygon(int p)
    {
        return (p - 2) * 180;
    }

    public static string nameString(string first)
    {
        string last = ("Edabit");
        return first + last;
    }

    public static bool And(bool a, bool b)
    {
        if (a && b == true) return true;
        else return false;
    }

    public static int points(int o, int t)
    {
        o = o * 2; t = t * 3;
        return o + t;
    }

    public static int findPerimeter(int w, int l)
    {
        int p = (2 * w) + (2 + l);
        return p;
    }

    public static string helloName(string name)
    {
        return "Hello " + name + "!";
    }

    public static int animals(int chicken, int cow, int pig)
    {
        return (chicken * 2) + (cow * 4) + (pig * 4);
    }

    public static int footballPoints(int w, int d, int l)
    {
        return (w * 3) + d + (l * 0);
    }

    public static string monthName(int m)
    {
        return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(m);
    }

    public static int findMinMax(int[] a)
    {
        int b = a.Min();
        int c = a.Max();
        Console.WriteLine("This min is " + b);
        return c;
    }

    public static int getAbsSum(int[] absNumbers)
    {
        int a = Math.Abs(absNumbers[0]);
        int b = Math.Abs(absNumbers[1]);
        int c = Math.Abs(absNumbers[2]);
        int d = Math.Abs(absNumbers[3]);
        int e = Math.Abs(absNumbers[4]);
        return a + b + c + d + e;
    }

    public static int calculateExponent(int b, int e)
    {
        return (int)math.Pow(b, e);
    }

    public static int MultiplyBylength(int[] l)
    {
        int a = l[0] * l.Length;
        int b = l[1] * l.Length;
        int c = l[2] * l.Length;
        int d = l[3] * l.Length;
        int e = l[4] * l.Length;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        return e;
    }

    public static int MultiplyBylength(int[] l)
    {
        int count = 0;

        if (first.Length > second.Length || first.Length < second.Length) { throw new ArgumentExpectation(); }
        else if (first.Length == 0 || second.Length == 0) { count = 0; }
        else if (first == second) { count = 0; }
        else
        {
            for (int i = 0; i < firstLength; i++)
            {
                if (first[i] != second[i])
                {
                    count++;
                }
            }
        }
    }
    return count;
}

