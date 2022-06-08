using System;
using System.Collections.Generic;

namespace Collect;
class Collection
{
    internal void LearnArrays()
    {
        //10 =array assigmentin 1 dimension 
        byte[] ages = new byte[20];
        ages[0] = 23;
        ages[1] = 30;
        //anothr way to assign 1D array
        byte[] number = { 64, 36, 65 };

        // 20 2D or multi dim array
        decimal[,] mat = new decimal[3, 4];
        mat[0, 0] = 563;
        mat[0, 1] = 456;

        double[,] table = { { 2, 3 }, { 4, 5 } };

        // jagged array
        string[][] semNames = new string[3][];
        string[] FirstSemNames = { "hari", "ram" };
        string[] SecondSemNames = { "bishnu", "rim", "sudip" };
        semNames[0] = FirstSemNames;
        semNames[1] = SecondSemNames;
        Console.WriteLine(semNames[0][0]);
        Console.WriteLine(semNames[1][1]);
        Console.WriteLine(semNames[1][2]);

    }

    internal void LearnBuiltInCollection()
    {
        List<int> numbers = new();
        numbers.Add(23);
        numbers.Add(24);
        numbers.Add(25);
        numbers.Add(26);
        numbers.Remove(23);
        //stack and queue

        Stack<string> names = new();
        names.Push("fghjhj");
        names.Push("fghjhj");
        names.Pop();

        Queue<double> bill = new();
        bill.Enqueue(23.32);
        bill.Enqueue(50.32);
        bill.Dequeue();

        Dictionary<string, byte> data = new();
        data.Add("rim", 22);
        data.Add("sudip", 23);
        data.Add("suraj", 20);
        data.Add("keshav", 24);
}


}