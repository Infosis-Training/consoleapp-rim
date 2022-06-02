using System;

class Methods
{
    //simple possible:no return type,no parameter
    public void print()
    {
        Console.WriteLine("hello there!");
    }
    //no return type, give some argument
    public void printName(string name)
    {
        Console.WriteLine("hello there!, " + name);
    }
}