using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PgpCore;
using System.IO;

namespace En_decrypter
{
    public partial class frmPGP : Form
    {
        private bool isPublicKey = true;

        public frmPGP()
        {
            InitializeComponent();
        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "";

            if(boxKey.Text == "")
            {
                lblResponse.Text = "The Key shouldn't be empty!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            if (boxPlain.Text == "")
            {
                lblResponse.Text = "The PlainText shouldn't be empty!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            if(isPublicKey)
            {
                try
                {
                    using (PGP pgp = new PGP())
                    {
                        boxEnc.Text = pgp.EncryptArmoredString(boxPlain.Text, boxKey.Text);
                    }
                }
                catch(Exception)
                {
                    lblResponse.Text = "Something went wrong!";
                    lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                    return;
                }
            }
            else
            {
                if (boxPwd.Text == "")
                {
                    lblResponse.Text = "The Password shouldn't be empty!";
                    lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                    return;
                }
                try
                {
                    using (PGP pgp = new PGP())
                    {
                        boxEnc.Text = pgp.ClearSignArmoredString(boxPlain.Text, boxKey.Text, boxPwd.Text);
                            
                    }
                }
                catch (Exception)
                {
                    lblResponse.Text = "The used Key or Password is wrong!";
                    lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                    return;
                }
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "";

            if (boxKey.Text == "")
            {
                lblResponse.Text = "The Key shouldn't be empty!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }
            if (boxEnc.Text == "")
            {
                lblResponse.Text = "The Encrypted Text shouldn't be empty!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }
            lblResponse.Text = "Decryption Succesfull!";
            lblResponse.ForeColor = Color.FromArgb(0, 128, 43);

            if(isPublicKey)
            {
                try
                {
                    using (PGP pgp = new PGP())
                    {
                        if(pgp.VerifyClearArmoredString(boxEnc.Text, boxKey.Text))
                        {
                            lblResponse.Text = "String verified!";
                            lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
                            
                            string plainoutput = string.Join(' ', boxEnc.Text.Split(Environment.NewLine.ToCharArray()).Skip(3).ToArray());
                            if (plainoutput.Contains("-----BEGIN PGP SIGNATURE-----"))
                            {
                                boxPlain.Text = plainoutput.Remove(plainoutput.IndexOf("-----BEGIN PGP SIGNATURE-----"));
                            }
                            else
                            {
                                boxPlain.Text = plainoutput;
                            }
                        }
                        else
                        {
                            lblResponse.Text = "String is not veriefied!";
                            lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                        }
                    }
                }
                catch(Exception)
                {
                    lblResponse.Text = "The used Key is wrong!";
                    lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                    return;
                }
            }
            else
            {
                if (boxPwd.Text == "")
                {
                    lblResponse.Text = "The Password shouldn't be empty!";
                    lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                    return;
                }
                try
                {
                    using (PGP pgp = new PGP())
                    {
                        boxPlain.Text = pgp.DecryptArmoredString(boxEnc.Text, boxKey.Text, boxPwd.Text);
                    }
                }
                catch(Exception)
                {
                    lblResponse.Text = "The used Key or Password is wrong!";
                    lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                    return;
                }
            }
        }

        private void btnFileEnc_Click(object sender, EventArgs e)
        {

        }

        private void btnFileDec_Click(object sender, EventArgs e)
        {

        }

        private void btnSwitchKey_Click(object sender, EventArgs e)
        {
            if(isPublicKey)
            {
                isPublicKey = false;
                btnEnc.Text = "sign";
                btnFileEnc.Text = "sign file";
                btnDec.Text = "decrypt";
                btnFileDec.Text = "decrypt file";
                btnSwitchKey.Text = "use public Key";
            }
            else
            {
                isPublicKey = true;
                btnEnc.Text = "encrypt";
                btnFileEnc.Text = "encrypt file";
                btnDec.Text = "verify";
                btnFileDec.Text = "verify file";
                btnSwitchKey.Text = "use private key";
            }
        }

        private void btnCopyPlain_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(boxPlain.Text);
        }

        private void btnCopyEnc_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(boxPlain.Text);
        }
    }
}
