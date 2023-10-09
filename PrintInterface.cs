using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTestProject
{
    public class PrintNumber : IprintInterface
    {
        public string PrintMessage(int startNumber, int endNumber)
        {
            string PrintMessage = string.Empty;
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    PrintMessage += (i + " is fizzbuzz;");
                }
                else if (i % 3 == 0)
                {
                    PrintMessage += (i + " is fizz;");
                }
                else if (i % 5 == 0)
                {
                    PrintMessage += (i + " is buzz;");
                }



            }
            return PrintMessage;
        }

        public string ReverseString(string inputString)
        {
            string result = string.Empty;
           var newresult = inputString.ToCharArray();
            for(int i = newresult.Length-1; i>=0; i--)
            {
                result += newresult[i];
            }

            return result;

        }
    }
}
