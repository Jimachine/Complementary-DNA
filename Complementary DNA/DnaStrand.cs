using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementary_DNA
{
    public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            string output = null;

            foreach (char c in dna)
            {
                if (c == 'A')
                {
                    output += 'T';
                }
                else if (c == 'T')
                {
                    output += 'A';
                }
                else if (c == 'C')
                {
                    output += 'G';
                }
                else if (c == 'G')
                {
                    output += 'C';
                }
            }
            return output;
        }
    }
}
