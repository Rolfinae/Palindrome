using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalPalindrome;

namespace BllPalindrome
{
    public class PalindromeManagement
    {
        public List<string> getListPalindromeFromFile(string pFileName)
        {
            FileTextReaderUtility myReader = new FileTextReaderUtility();
            List<string> readLines = myReader.ReadAllLines(pFileName);
            List<string> lineClean = new List<string>();
            foreach (string line in readLines)
            {
                string[] monTableau;
                line.Trim();
                monTableau = line.Split(',','(');
                lineClean.Add(monTableau[0].Trim());
            }
            return lineClean;
        }
    }
}
