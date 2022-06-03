using System;
namespace Array;
class Work
{

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