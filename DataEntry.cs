
using Array;
class Mainfunction
{

    public static void Main()
    {
         Work h = new();
         h.HashTag();
         Console.WriteLine(h);


         Work w = new();
         w.NumberTag();
         Console.WriteLine(w);


         Work y = new();
         y.peramidTag();
         Console.WriteLine(y);

        Methods m = new();
       m.MaximumNumbers(80, 90, 10);
       Console.WriteLine(m);
       string latter= m.LatterPrint("Bishnu", "Rawal");
        Console.WriteLine(latter);
    }

}