using System;

namespace AccountTest
{
     class AccountTest
    {
        static void Main()
        {
            // Creates an Account object and assign it to myAccount
            Account myAccount = new Account();
            //dispaly myAccount's initial name (there isn't one yet)
            
            Console.WriteLine($"Initial name is: {myAccount().Getname()}");
            //prompt for and read the name then put the name in the object
            
            Console.Write("Enter Name:");//prompt
            string theName = Console.ReadLine(); //Reads the name
            myAccount().SetName(theName); //put theName in the myAccount object
           
            //display the name stored in the myAccount object
            Console.WriteLine($"myAccount's name is: {myAccount().GetName()}");

        }
    }
}
