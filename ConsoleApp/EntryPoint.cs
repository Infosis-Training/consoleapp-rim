using System;
using OOP;
using Collect;
class EntryPoint
{
    // create object(instantiating)
    public static void Main()
    {

        //     Person p1 = new();
        //     Person.scientificName ="homosapies";
        //     //Accessing instance member
        //     p1.personName = "Rim";
        //     p1.heightInFt = 6.1f;
        //     p1.age = 22;
        //     p1.gender = "male";
        //    string details= p1.GetPersonDetails();
        //    Console.WriteLine(details);

        // Collection coll = new();
        // coll.LearnArrays();

        // Basics b = new();
        // b.LearnLoops();

        // Methods m = new();
        // m.print();
        // m.print("rim");

        // string detail = m.print("rim", 20);
        // Console.Write(detail);

        // Console.WriteLine(m.Greet("sudip", "Dr."));
        // Console.WriteLine(m.Greet("sudip"));
        // m.EvenAndOddd(5);


        // Excercise1 e = new();
        // e.HashTag();
        // Console.WriteLine(e);

        // e.NumberTag();
        // Console.WriteLine(e);

        // e.peramidTag();
        // Console.WriteLine(e);

        // e.MaximumNumbers(80, 90, 10);
        // Console.WriteLine(e);

        // string latter = e.LatterPrint("bishnu", "Rawal");
        // Console.WriteLine(latter);

        // double mult = e.GetMultply(5.6, 6.7);
        // Console.WriteLine(mult);
        // ExceptionHandling eh = new();
        // double result = eh.Compute(1, 2, -2);
        // Console.WriteLine(result);


        // Properties prop = new();
        // prop.Name = "RM"; //Set
        // String s = prop.Name; //Get
        // Console.WriteLine(s);
        // prop.Addres ="butwal";

        // TimePeriod tp = new();
        // tp.Hours = 7;
        // tp.GetTime();
        // Console.WriteLine(tp.GetTime());

        // TimeChange tc = new();

        // Console.WriteLine(tc.Time);
        // // Console.WriteLine(tc.Time);
        // Console.WriteLine(TimePeriod.MyStaticMethod(20));

        // ChangeTime ch = new();
        // ch.IChangeTime();
        // ch.IAnotheFunction();

        // Generics g = new();
        // g.sum<float>(34, 45);
        // g.sum<string>("rim", "sudip");

        Exercise4 ex = new();
        ex.FetchData();

    }

}