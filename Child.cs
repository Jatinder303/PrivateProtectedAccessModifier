using System;

namespace PrivateProtectedAccessModifier
{
    class Child : Parent
    {

        public void showValue()
        {
            // Trying to access value 
            // Inside a derived class 

            Console.WriteLine("Value = " + value);
            // value is accesible 
        }
    }
}
