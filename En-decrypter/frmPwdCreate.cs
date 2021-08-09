using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace En_decrypter
{
    public partial class frmPwdCreate : Form
    {
        public frmPwdCreate()
        {
            InitializeComponent();
            btnPwdCreate_Click(this, null);
        }

        private void btnPwdCreate_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "";
            int pwdLength = 20;
            try
            {
                pwdLength = Convert.ToInt16(boxPwdLength.Text);
            }
            catch (Exception)
            {
                lblResponse.Text = "The Passwordlength must be a number!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            string valid = "";
            if (checkLowercase.Checked)
            {
                valid += "abcdefghijklmnopqrstuvwxyz";
            }
            if (checkUppercase.Checked)
            {
                valid += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (checkNumbers.Checked)
            {
                valid += "1234567890";
            }
            if (checkSpecialChar.Checked)
            {
                valid += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            }
            if (valid == "")
            {
                lblResponse.Text = "You need to check at least one box!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
            }
            else
            {
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < pwdLength--)
                {
                    res.Append(valid[rnd.Next(valid.Length)]);
                }
                boxPwdCreate.Text = res.ToString();
            }
        }

        private void btnPwdCopy_Click(object sender, EventArgs e)
        {
            if (boxPwdCreate.Text != "")
            {
                Clipboard.SetText(boxPwdCreate.Text);
                lblResponse.Text = "Successfully copied password to Clipboard";
                lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
            }
        }

        private void boxPwdLength_TextChanged(object sender, EventArgs e)
        {
            btnPwdCreate_Click(this, null);
        }

        private void checkLowercase_CheckStateChanged(object sender, EventArgs e)
        {
            btnPwdCreate_Click(this, null);
        }

        private void checkUppercase_CheckStateChanged(object sender, EventArgs e)
        {
            btnPwdCreate_Click(this, null);
        }

        private void checkNumbers_CheckStateChanged(object sender, EventArgs e)
        {
            btnPwdCreate_Click(this, null);
        }

        private void checkSpecialChar_CheckStateChanged(object sender, EventArgs e)
        {
            btnPwdCreate_Click(this, null);
        }
        private void frmPwdCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
