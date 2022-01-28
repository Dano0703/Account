using System;

namespace Account
{
    internal class Account
    {
       private string name; //instance variable

        //metho that sets the account name in the object
        public void SetName(string accountName)
        {
            name = accountName; //stroes the account name
        }

        //method that retrievs the account name from the object
        public string GetName()
        {
            return name; //returns name's value to this method's caller
        }
    }

}
