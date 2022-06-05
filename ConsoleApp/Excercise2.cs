
using System;

class TimePeriod
{

    private double seconds;
    private int value = 0;
    private int time;


//for question 1
    public double Hours
    {

        get
        {
            return seconds;
        }
        set
        {

            seconds = value;

        }
    }
    public string GetTime()
    {
        return $"time is {seconds}";
    }
    // for question 2
    public int Time
    {
        get
        {
            return 6;
        }
    }

    //for qn part 2
    public static int MyStaticMethod(int x)
    {
        return x + 5;
    }




}

class TimeChange : TimePeriod
{

}
//for qn no.3
interface IMyInterface
{
    void  IChangeTime();
    void IAnotheFunction();

}
class ChangeTime:IMyInterface
{
    public void IChangeTime( )
    {
        Console.WriteLine("time not occor in line no.62 ");
    }
    public void IAnotheFunction()
    {
        Console.WriteLine("this is another function using interface");
    }
}