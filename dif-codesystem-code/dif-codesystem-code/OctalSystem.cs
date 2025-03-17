

namespace dif_codesystem_code
{
    public class OctalSystem
    {
        public string octal= "";
        public OctalSystem(int returnDecValue)
        {
            ToOctal(returnDecValue);
        }
        public void ToOctal(int returnDecValue)
        {
            int[] octalnumbers = { 64, 8, 1 };
            foreach(int valueoctal in octalnumbers)
            {
                int count = returnDecValue / valueoctal;
                switch (count)
                {
                    case 7:
                        octal += "7";
                        break;
                    case 6:
                        octal += "6";
                        break;
                    case 5:
                        octal += "5";
                        break;
                    case 4:
                        octal += "4";
                        break;
                    case 3:
                        octal += "3";
                        break;
                    case 2:
                        octal += "2";
                        break;
                    case 1:
                        octal += "1";
                        break;
                    default:
                        octal += "0";
                        break;
                }
                returnDecValue -= count * valueoctal;  //z.b. returnDecValue = 100 - valueoctal = 64 mal count = 1 ----> 100- (64 * 1)
            }
        }
        public static int ToDec(string userInput)
        {

        }
    }
}
