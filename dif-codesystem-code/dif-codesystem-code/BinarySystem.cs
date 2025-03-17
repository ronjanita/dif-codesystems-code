

namespace dif_codesystem_code
{
    public class BinarySystem
    {
        public string binary="";
        public  BinarySystem(int returnDecValue)
        {
            ToBinary(returnDecValue);

        }
        public void ToBinary(int returnDecValue)
        {
            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };   // needed to initialize the binary number
            foreach (int value in binarynumbers)  //used to go through every single value of the befdore created bianrynumbers array, for each value it checks if returnDecValue is greate ror ewqual to current binary value
            {
                if (returnDecValue >= value)
                {
                    binary += "1";   //if its greater 1 gets  output
                    returnDecValue -= value;
                }
                else
                {
                    binary += "0";  //if its smaller or equaol a 0 gets outpiut
                }
            }
        }
        public static int ToDec(string userInput)
        {
            int decimalValue = 0;
            int[] binarynumbers = { 128, 64, 32, 16, 8, 4, 2, 1 };

            for (int biteValue = 0; biteValue < userInput.Length; biteValue++)
            {
                if (userInput[biteValue] == '1')
                {
                    decimalValue += binarynumbers[biteValue];
                }
            }
            return decimalValue;
        }
    }
}
