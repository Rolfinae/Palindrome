using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalPalindrome
{
    public class FileTextReaderUtility
    {
        public List<string> ReadAllLines(string pFileName)

        {
            if (string.IsNullOrEmpty(pFileName))
            {
                throw new ArgumentException();
            }
            return File.ReadAllLines(pFileName).ToList();
        }
    }
}
