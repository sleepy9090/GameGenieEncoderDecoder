using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGenieEncoderDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNesEncode_Click(object sender, EventArgs e)
        {

        }

        private void buttonNesDecode_Click(object sender, EventArgs e)
        {

        }

        private void buttonGbGgEncode_Click(object sender, EventArgs e)
        {

        }

        private void buttonGbGgDecode_Click(object sender, EventArgs e)
        {

        }

        private void buttonSnesEncode_Click(object sender, EventArgs e)
        {
            string address = textBoxSnesAddress.Text;
            string value = textBoxSnesValue.Text;
            string raw = value + address;
            if (raw.Length != 8)
            {
                MessageBox.Show("Address must be 6 characters and value must be 2 characters, 0-9, A-F", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Genie genie = new Genie();
                string code = genie.EncryptSnesAddressAndValueToCode(raw);
                textBoxSnesCode.Text = code;
            }
        }

        private void buttonSnesDecode_Click(object sender, EventArgs e)
        {
            string code = textBoxSnesCode.Text;
            if (code.Length != 8)
            {
                MessageBox.Show("Code must be 8 characters, 0-9, A-F", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Genie genie = new Genie();
                string decoded = genie.DecryptSnesCodeToAddressAndValue(code);
                string decodedAddress = decoded.Substring(2, 6);
                string decodedValue = decoded.Substring(0, 2);

                textBoxSnesAddress.Text = decodedAddress;
                textBoxSnesValue.Text = decodedValue;
            }
            
        }

        private void buttonGenMdEncode_Click(object sender, EventArgs e)
        {
            string address = textBoxGenMdAddress.Text;
            string value = textBoxGenMdValue.Text;
            string raw = address + value;
            if (raw.Length != 8)
            {
                MessageBox.Show("Address must be 6 characters and value must be 4 characters, 0-9, A-Z (not I, O, Q, or U)", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Genie genie = new Genie();
                string code = genie.EncryptGenMDAddressAndValueToCode(raw);

                textBoxGenMdCode.Text = code;
            }
        }

        private void buttonGenMdDecode_Click(object sender, EventArgs e)
        {
            string code = textBoxGenMdCode.Text;
            if (code.Length != 8)
            {
                MessageBox.Show("Code must be 8 characters, 0-9, A-Z (not I, O, Q, or U)", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Genie genie = new Genie();
                string decoded = genie.DecryptGenMDCodeToAddressAndValue(code);
                string decodedAddress = decoded.Substring(0, 6);
                string decodedValue = decoded.Substring(6, 4);

                textBoxGenMdAddress.Text = decodedAddress;
                textBoxGenMdValue.Text = decodedValue;
            }
        }
    }
}
