using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dif_codesystem_code
{
    internal class BinarySystem
    {
        public static string conToBin = "";
        public static string conToDec = "";

        public BinarySystem(int returnDecValue)
        {
            ToBinary(returnDecValue);
        }
        public static void ToBinary(int returnDecValue)
        {
            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };
            string binary = " ";
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
        }
        public ToDec(string UserInput)
        {

        }
    }
}
