using System;
using System.Collections.Generic;
using System.Linq;

class Linq
{
    //language integfrated language
    int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9 };
    public void LearnLINQ()
    {
        //get odd number
        var oddnumbers = numbers.Where(number => number % 2 == 1);
        //get multiply by 3
        var multiple = numbers.Where(number => number % 3 == 0);
        //get square of all element
        var squares = numbers.Select(x => x * x);
        //get square of odd number
        var oddSquares = numbers.Where(number => number % 2 == 1).Select(x => x * x);

    }


    
}