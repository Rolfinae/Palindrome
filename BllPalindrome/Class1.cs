using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                string text = line;
                text = Regex.Replace(text, @"\(.*\)", "");
                text = Regex.Replace(text, @"\s", " ");
                string[] monTableau;
                text.Trim();
                monTableau = text.Split(',');
                lineClean.Add(monTableau[0].Trim());
            }
            return lineClean;
        }
    }
}
