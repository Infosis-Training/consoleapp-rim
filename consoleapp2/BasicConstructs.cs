using System;

class Basics
{
    // public static void Main1()
    // {
    //     // LearnConditionals(33);
    //     //LearnConditionals(60);
    //     LearnLoops();
    // }

    static void LearnConditionals(byte x)
    {

        if (x < 50)
        {
            Console.WriteLine(x + " is less then 50");
        }
        else if (x < 70)
        {

            Console.WriteLine(x + " is between then 50-70");
        }
        else
        {
            Console.WriteLine(x + " is greter then 70");
        }
    }
    internal void LearnSwitch()

    {
        string name = "rim";
        switch (name)
        {
            case "rim":
                // some code
                break;
            case "sudip":
                //some code
                break;
            case "suraj":

                break;
            default:

                break;
        }
    }

//
    internal void LearnLoops()
    {
    //    for (byte j = 1; j < 6; j++)
    //     {

    //         Console.WriteLine(j + ".NET Traning");
    //     }

        string[] names={"ramesh","keshav","bishnu"};

        foreach(string n in names)
        {
            Console.WriteLine(n);
        }

        // byte i = 1;
        //   while (i < 6)
        // {

        //     Console.WriteLine(i + ".NET Traning");
        //     i++;
        // }
    }

}