using System;

class Methods
{
    //simple possible:no return type,no parameter
    public void print() => Console.WriteLine("hello there!");

    //no return type, give some argument
    public void print(string name) => Console.WriteLine("hello there!, " + name);

    //one return type,,multiple argument
    public string print(string name, byte age)
    {
        //string detail ="i am " + name + " my age " + age + " year old";
        // another way to write string
        string detail = $"i am  {name}.  my age  {age} year old";
        return detail;
    }
    //optional argument
    public string Greet(string name, string salutation = "mr.") => $"hello, {salutation} {name}";

    public void EvenAndOddd(byte num)
    {
        if (num%2==0)
        {
            Console.WriteLine("the number is even");
        }
        else{
            Console.WriteLine("the number is odd");
        }

    }
    public bool IsEven(int num)=>num%2==0;

}