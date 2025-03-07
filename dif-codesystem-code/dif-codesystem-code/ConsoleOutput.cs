using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dif_codesystem_code
{
    internal class ConsoleOutput
    {
        public ConsoleOutput()
        {
            GetInput();
        }
        public static void GetInput()
        {
            Console.WriteLine("Welcome to this encryption program, where you are able to encrypt your number based code, into a new number based code system.");
            Console.WriteLine("Explanation: First, you select the number system that your input is based on. Second you select the nu,mber system you want your text to get encrypted to. Latly you enter the number code you want ot encrypt. Press enter and your newly encrypted number code get displayed!");
            Console.WriteLine("The available number systems are: binary(B), octal(O), decimal(D) and hexadecimal(H).");

            Console.WriteLine("Please enter the start-number system(B, O, D, H):");
            string UserInputStartNumberSystem = Console.ReadLine();   
            
            switch (UserInputStartNumberSystem)
            {
                case "B";

            }
            Console.WriteLine("Please enter the end-number system(B, O, D, H):");
            string UserInputEndNumberSystem = Console.ReadLine();       //if else logik machen? oder mit schleife arbieten? 
            Console.WriteLine("Please enter your number based code:");
            string UserInput = Console.ReadLine();      //if else logik machen? oder mit schleife arbieten? 
        }
    }
}
//public static string GetInput() { ... }
//public static string GetStartSystem() { ... }
//public static string GetZielSystem() { ... }
//public static void DisplayResult(string result) { ... }
