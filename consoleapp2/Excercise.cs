using System;

class Excercise
{
    public void MaximumNumbers(int x, int y, int z)
    {
        int higher;
        if (x > y)
        {
            higher = x;
        }
        else
        {
            higher = y;
        }
        if (higher > z)
        {
            higher = higher;
        }
        else
        {
            higher = z;
        }
        Console.WriteLine(higher + " is greater");

    }
    public string LatterPrint(string Fname, string Lname)
    {
        string str = $" {Fname[0]}{Lname[0]}";

        return str.ToUpper();
    }
    public double GetMultply(double x, double y, double z = 1) => x * y * z;


    public void HashTag()
    {
        for (byte i = 1; i <= 5; i++)
        {
            for (byte j = 1; j <= i; j++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
    }

    public void NumberTag()
    {
        for (byte i = 1; i <= 5; i++)
        {
            for (byte j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine("");
        }
    }

    public void peramidTag()
    {
        byte space = 4;
        for (byte i = 1; i <= 9; i += 2)
        {
            for (byte j = 1; j <= space; j++)
            {
                Console.Write(" ");
            }
            space--;

            for (byte z = 1; z <= i; z++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }

}