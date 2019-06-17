using System;

//This code is same as the code private modifier but since the Access modifier for member value is ‘private protected’ it is now accessible inside the derived class or Parent namely Child. Any derived class that maybe present in another assembly will not be able to access these private protected members.

// C# Program to show use of  
// the private protected  
// Accessibility Level 
namespace PrivateProtectedAccessModifier
{
    // Driver Code 
    static class Program
    {
        // Main Method 
        static void Main(string[] args)
        {
            Parent obj = new Parent();

            // obj.value = 5; 
            // Also gives an error 

            // Use public functions to assign 
            // and use value of the member 'value' 
            obj.setValue(4);
            Console.WriteLine("Value = " + obj.getValue());
        }
    }
}
