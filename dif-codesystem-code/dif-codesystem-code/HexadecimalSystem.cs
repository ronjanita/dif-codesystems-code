using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dif_codesystem_code
{
    class HexadecimalSystem
    {
        public string hexadecimal = "";
        public HexadecimalSystem(int returnDecValue)
        {
            ToHex(returnDecValue);
        }
        public void ToHex(int returnDecValue)
        {
            int[] hexadecimalnumbers = { 256, 16, 1 };
            foreach(int valuehexadecimal in hexadecimalnumbers)
            {
                int count = returnDecValue / valuehexadecimal;
                switch(count)
                {
                    case 15:
                        hexadecimal += "F";
                        break;
                    case 14:
                        hexadecimal += "E";
                        break;
                    case 13:
                        hexadecimal += "D";
                        break;
                    case 12:
                        hexadecimal += "C";
                        break;
                    case 11:
                        hexadecimal += "B";
                        break;
                    case 10:
                        hexadecimal += "A";
                        break;
                    case 9:
                        hexadecimal += "9";
                        break;
                    case 8:
                        hexadecimal += "8";
                        break;
                    case 7:
                        hexadecimal += "7";
                        break;
                    case 6:
                        hexadecimal += "6";
                        break;
                    case 5:
                        hexadecimal += "5";
                        break;
                    case 4:
                        hexadecimal += "4";
                        break;
                    case 3:
                        hexadecimal += "3";
                        break;
                    case 2:
                        hexadecimal += "2";
                        break;
                    case 1:
                        hexadecimal += "1";
                        break;
                    case 0:
                        hexadecimal += "0";
                        break;
                }
                returnDecValue -= count * valuehexadecimal;
            }
        }
        public static int ToDec(string userInput)
        {
            int decimalValue = 0;
            int[] hexadecimalnumbers = { 256, 16, 1 };

            for (int currentPositionOfHexa = 0; currentPositionOfHexa < userInput.Length; currentPositionOfHexa++)  //schleife die durch alle hexadecimal zeicehn geht
            {
                char currentChar = userInput[currentPositionOfHexa];
                int currentDigit= 0;

                if (currentChar >= '0' && currentChar <= '9')  //wandelt zeichen direkt in zahl um
                {
                    currentDigit = currentChar - '0';
                }
                else if (currentChar >= 'A' && currentChar <= 'F')  
                {
                    currentDigit = currentChar - 'A' + 10;
                }
                else if (currentChar >= 'a' && currentChar <= 'f')  // wandelt A in 10 um, B in 11 und so weiter, sowohll gross wie auch klein buchstaben
                {
                    currentDigit = currentChar - 'a' + 10;
                }
                decimalValue += currentDigit * hexadecimalnumbers[hexadecimalnumbers.Length - userInput.Length + currentPositionOfHexa];  //berechnung dezimalwert
            }
            return decimalValue;  //rückgabe endergebnis ( dezimalwert)
        }
    }
}
