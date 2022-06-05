using System;

// // object oriented concept
// // defining class 
// //pascal casing: class and method
// //camel casing: member 
// namespace OOP;


    class Person
    {
        // member define:member, method
        // internal static string scientificName;
        public string personName; //camel casting
        public float heightInFt;
        public byte age;
        public string gender;

        /*public void SpeakLanguage()
        {
            Console.WriteLine(personName + "is speaking");
            // without console and return value
        }*/
        public string GetPersonDetails()
        {
            string nameDesc = "I am " + personName;
            string heightDesc = "my height is " + heightInFt + "Ft";
            string ageDesc = "I am " + age + " year old";
            string genderDesc = "I am " + gender;
            string personDesc = nameDesc + "\n" + heightDesc + "\n" + ageDesc + "\n" + genderDesc;
            return personDesc;
        }
    }