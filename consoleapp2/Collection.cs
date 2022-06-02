using System;
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
        string[] FirstSemNames={"hari","ram"};
        string[] SecondSemNames={"bishnu","rim","sudip"};
        semNames[0] =FirstSemNames;
        semNames[1] =SecondSemNames;
         Console.WriteLine(semNames[0][0]);
        Console.WriteLine(semNames[1][1]);
         Console.WriteLine(semNames[1][2]);
        
    }
}