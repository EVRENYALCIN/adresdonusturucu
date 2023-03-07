using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_MetinCevirici
{
    public partial class AdresDonusturucu : Form
    {
        public AdresDonusturucu()
        {
            InitializeComponent();
        }
        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            txtBuyukAdres.Text = ConvertTurkishCharactersToEnglishUpper(RemoveExtraSpaces(txtAdres.Text)).ToUpper();
            txtKucukAdres.Text = ConvertTurkishCharactersToEnglishLower(RemoveExtraSpaces(txtAdres.Text)).ToLower();
        }
        static string ConvertTurkishCharactersToEnglishUpper(string input)
        {
            string output = input;
            output = output.Replace("ç", "C");
            output = output.Replace("ğ", "G");
            output = output.Replace("ı", "I");
            output = output.Replace("i", "I");
            output = output.Replace("ö", "O");
            output = output.Replace("ş", "S");
            output = output.Replace("ü", "U");
            output = output.Replace("Ç", "C");
            output = output.Replace("Ğ", "G");
            output = output.Replace("I", "I");
            output = output.Replace("İ", "I");
            output = output.Replace("Ö", "O");
            output = output.Replace("Ş", "S");
            output = output.Replace("Ü", "U");
            return output;
        }
        static string ConvertTurkishCharactersToEnglishLower(string input)
        {
            string output = input;
            output = output.Replace("ç", "c");
            output = output.Replace("ğ", "g");
            output = output.Replace("ı", "i");
            output = output.Replace("ö", "o");
            output = output.Replace("ş", "s");
            output = output.Replace("ü", "u");
            output = output.Replace("Ç", "c");
            output = output.Replace("Ğ", "g");
            output = output.Replace("I", "i");
            output = output.Replace("İ", "i");
            output = output.Replace("Ö", "o");
            output = output.Replace("Ş", "s");
            output = output.Replace("Ü", "u");
            return output;
        }
        static string RemoveExtraSpaces(string input)
        {
            return Regex.Replace(input, @"\s+", " ");
        }
    }
}
