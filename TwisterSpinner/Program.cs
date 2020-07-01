using System;
using System.Runtime.CompilerServices;

namespace TwisterSpinner
{
    class Program
    {
        static void Main(string[] args)
        {
             
            var myArray = new string[] {"Left Foot Red", "Left Foot Green", "Left Foot Blue", "Left Foot Yellow", "Right Foot Red", "Right Foot Green", "Right Foot Blue", "Right Foot Yellow", "Left Hand Red", "Left Hand Green", "Left Hand Blue", "Left Hand Yellow", "Right Hand Red", "Right Hand Green", "Right Hand Blue", "Right Hand Yellow"};
            Console.WriteLine("Lets get TWISTED!");
            string userInput;
            do
            {
                PrintRandomArr(myArray);
                Console.WriteLine("Would you like to spin again? y or n");
                userInput = Console.ReadLine();
            } while (userInput == "y");

            
            
        } 
        
        public static void PrintRandomArr(string[] myArray)
        {

            var random = new Random();
            var randoString = random.Next(0, myArray.Length - 1);
            Console.WriteLine($"{myArray [randoString]}");







        } 
        

    }   
        
}
