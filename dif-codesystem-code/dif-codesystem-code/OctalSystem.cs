

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
            int decimalValue = 0;
            int[] octalnumbers = { 64, 8, 1 };
            for (int positionSingleOctalDigit = 0; positionSingleOctalDigit < userInput.Length; positionSingleOctalDigit++)
            {
                int currentDigit = userInput[positionSingleOctalDigit] - '0';  //aktuelles zeichgen wir din ganzzahl umgewandelt und kovertiert das z4eichenin entsprechenden integer wert
                if (currentDigit >= 0 && currentDigit <= 7)  //überprüfung der gültigkeit des oktalwertes also ob es zwischen 0 und 7 mal vorkjommt
                {
                    decimalValue += currentDigit * octalnumbers[positionSingleOctalDigit];  //berechnung der finalen dezimalzahl
                }
            }
            return decimalValue;
        }
    }
}
