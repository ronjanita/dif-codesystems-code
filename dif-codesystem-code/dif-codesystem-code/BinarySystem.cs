using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dif_codesystem_code
{
    internal class BinarySystem
    {

        public  BinarySystem(int returnDecValue)
        {
            ToBinary(returnDecValue);
        }
        public static int ToBinary(int returnDecValue)
        {
            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };
            string binary = "";
            foreach (int value in binarynumbers)
            {
                if (returnDecValue >= value)
                {
                    binary += "1";
                    returnDecValue -= value;
                }
                else
                {
                    binary += "0";
                }
            }
            return returnDecValue;
        }
        public static  int ToDec(string UserInput)
        {
            int decimalValue = 0;
            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };

            for (int biteValue = 0; biteValue < UserInput.Length; biteValue++)
            {
                if (UserInput[biteValue] == '1')
                {
                    decimalValue += binarynumbers[biteValue];
                }
            }
            return decimalValue;

        }
    }
}
