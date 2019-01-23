using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BllPalindrome;
using ClassLibraryWord;

namespace WinPalindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOFD = new OpenFileDialog();
            DialogResult result = myOFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                PalindromeManagement myBLL = new PalindromeManagement();
                List<string> myList = 
                myBLL.getListPalindromeFromFile(myOFD.FileName);
                LstAll.DataSource = myList;
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            LstNotPalindrome.Items.Clear();
            LstPalindrome.Items.Clear();
            Palindrome myPalindrome = new Palindrome();
            foreach (string word in LstAll.Items)
            {
                bool result = myPalindrome.IsPalindrome(word);
                if (result)
                {
                    LstPalindrome.Items.Add(word);
                }
                else
                {
                    LstNotPalindrome.Items.Add(word);
                }
            }
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            LstNotPalindrome.Items.Clear();
            LstPalindrome.Items.Clear();
            Palindrome myPalindrome = new Palindrome();
            foreach (string word in LstAll.Items)
            {
                bool result = myPalindrome.IsPalindrome(word);
                if (result)
                {
                    LstNotPalindrome.Items.Add(word);
                }
                else
                {

                    LstPalindrome.Items.Add(word);
                }
            }
        }
    }
}
