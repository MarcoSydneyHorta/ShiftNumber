using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftNumber
{
    class ShiftNum
    {
        static public string[] Solution(string[] arg, int k)
        {
            int tam = arg.Length;
            string[] argus = new string[tam];
            for (int i = 0; i < tam; i++)
            {
                if (i >= k)
                {

                    argus[i] = arg[i - k];
                }
                else
                {
                    argus[i] = arg[tam - k + i];
                }
            }

            return argus;
        }

    }
}
