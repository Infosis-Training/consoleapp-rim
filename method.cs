using System;

class Methods
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

        return str;
    }
}