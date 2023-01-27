using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Binary_Text_Convertor
{
    public partial class Binary_And_Text_Conversion : Form
    {
        public Binary_And_Text_Conversion()
        {
            InitializeComponent();
        }

        private void Convert_to_Text_btn_Click(object sender, EventArgs e)
        {
            string tempString = "";
            string Character = System.Text.RegularExpressions.Regex.Replace(BinaryDigitsTbx.Text, "[^01]", "");

            byte[] Bytes = new byte[(Character.Length / 8) - 1 + 1];

            for (int i = 0; i <= Bytes.Length - 1; i++)
            {
                Bytes[i] = Convert.ToByte(Character.Substring(i * 8, 8), 2);
            }

            tempString = (string)(System.Text.ASCIIEncoding.ASCII.GetString(Bytes));

            TextDisplayTbx.Text = tempString;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            BinaryDigitsTbx.Text = String.Empty;
            TextDisplayTbx.Text = String.Empty;
        }

        private void Convert_To_Binary_btn_Click(object sender, EventArgs e)
        {
            string tempString = "";
            System.Text.StringBuilder txtBuilder = new System.Text.StringBuilder();

            foreach (byte Character in System.Text.ASCIIEncoding.ASCII.GetBytes(TextDisplayTbx.Text))
            {
                txtBuilder.Append(Convert.ToString(Character, 2).PadLeft(8, '0'));
                txtBuilder.Append(" ");
            }

            tempString = txtBuilder.ToString().Substring(0, txtBuilder.ToString().Length - 0);

            BinaryDigitsTbx.Text = tempString;
        }
    }
}
