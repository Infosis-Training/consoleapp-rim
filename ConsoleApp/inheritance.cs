namespace OOP;
class African : Person
{

}

class Asian : Person
{

}

class Nepalies : Asian, ICulture
{
   public void SpeakLang()
    {
       
    }
}
//inherite from base class
//implement interface
//multilevel inheritance 
//single inheritance 
//multiple inheritance  doest not support in C# that whay we can use interface
interface ICulture
{
    void SpeakLang();

}