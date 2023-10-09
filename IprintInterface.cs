using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTestProject
{
   public interface IprintInterface
    {
        string PrintMessage(int startNumber, int endNumber);

        string ReverseString(string inputString);
    }
}
