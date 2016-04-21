using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Text.RegularExpressions;
using System.IO;

namespace TextToBinary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_ToBinary_Click(object sender, RoutedEventArgs e)
        {
            if (!IsASCII(TextBox_Plaintext.Text))
            {
                TextBox_Binary.Text = "Only ASCII characters are supported.";
                return;
            }

            TextBox_Binary.Text = TextToBinary(TextBox_Plaintext.Text);
        }

        string TextToBinary(string text)
        {
            string result = "";

            foreach(char ch in text)
            {
                var charASCII_Code = (int)ch;
                var charInBinary = Convert.ToString(charASCII_Code, 2);
                //var charInBinary7bits = String.Format("{0:00000000}", charInBinary);
                var charInBinary7bits = charInBinary.PadLeft(7, '0');

                result += charInBinary7bits;
            }

            return result;
        }

        private void Button_ToPlain_Click(object sender, RoutedEventArgs e)
        {
            var userInput = TextBox_Binary.Text;
            var regex = @"^[01]+$";

            if(!Regex.IsMatch(userInput, regex) || userInput.Length % 7 != 0)
            {
                TextBox_Plaintext.Text = "Wrong input format. Try again.";
                return;
            }

            var plain = "";
            for (int index = 0; index < userInput.Length; index += 7)
            {
                var current_char_code_in_bin = userInput.Substring(index, 7);
                var current_char_code_in_dec = Convert.ToInt32(current_char_code_in_bin, 2);

                plain += ((char)current_char_code_in_dec).ToString();
            }

            TextBox_Plaintext.Text = plain;
        }

        public static bool IsASCII(string value)
        {
            // ASCII encoding replaces non-ascii with question marks, so we use UTF8 to see if multi-byte sequences are there
            return Encoding.UTF8.GetByteCount(value) == value.Length;
        }
    }
}
