﻿using System;
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

            Console.WriteLine("Please enter the end-number system(B, O, D, H):");
            string UserInputEndNumberSystem = Console.ReadLine();

            Console.WriteLine("Please enter your number based code:");
            string UserInput = Console.ReadLine();
            ShowEcryptedCode(UserInputStartNumberSystem, UserInputEndNumberSystem, UserInput);
        }
        public static void ShowEcryptedCode(string startNumberSystem, string endNumberSystem, string UserInput)
        {
            string returnEncryptedText;
            int returnDecValue=0;

            switch (startNumberSystem)
            {
                case "B":
                    
                    returnDecValue = BinarySystem.ToDec(UserInput);
                    break;

                case "O":
                    OctalSystem.ToDec();
                    break;

                case "D":
                    DecimalSystem.ToDec();
                    break;

                case "H":
                    Hexadecimal.ToDec();
                    break;
            }

            switch (endNumberSystem)
            { 
                case "B":
                    //returnEncryptedText = BinarySystem.ToBinary(returnDecValue);
                    BinarySystem binarySystemConverted = new BinarySystem(returnDecValue);
                    Console.WriteLine($"Here is your newly encrypted code based on the binary system: {binarySystemConverted.binary} ");
                    break;

                case "O":
                    OctalSystem octalSystem = new OctalSystem();
                    Console.WriteLine($"Here is your newly encrypted code based on the octal system: {octalSystem.ToOct} ");
                    break;

                case "D":
                    DecimalSystem decimalSystem = new Decimalsystem();
                    Console.WriteLine($"Here is your newly encrypted code based on the decimal system: {decimalSystem.ToDec} ");
                    break;

                case "H":
                    HexadecimalSystem hexadecimalSystem = new HexadecimalSystem();
                    Console.WriteLine($"Here is your newly encrypted code based on the hexadecimal system: {hexadecimalSystem.ToHex}");
                    break;
            }

        }
    }
}