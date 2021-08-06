using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace En_decrypter
{
    public partial class frmHashes : Form
    {
        private bool isString = true;

        public frmHashes()
        {
            InitializeComponent();
            comboHashes.SelectedIndex = 0;
        }

        private void boxInput_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(boxInput.Text))
            {
                isString = false;
            }
            else
            {
                isString = true;
            }

            if (isString)
            {
                btnHash.Text = "Hash text";
            }
            else
            {
                btnHash.Text = "Hash file";
            }
        }

        private void boxInput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void boxInput_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    foreach (string file in files)
                    {
                        boxInput.Text = file;
                    }
                }
                else if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {
                    boxInput.Text = (string)e.Data.GetData(DataFormats.StringFormat);
                }
            }
            catch (Exception) { }
            boxInput.Select(boxInput.Text.Length - 1, boxInput.Text.Length - 1);
            boxInput.ScrollToCaret();
        }
        private void btnHash_Click(object sender, EventArgs e)
        {
            int id = (int)comboHashes.SelectedIndex;

            boxResponse.Clear();

            if (id ==-1)
            {
                boxResponse.SelectionColor = true ? Color.Red : Color.Red;
                boxResponse.AppendText("You have to select a hashing algorithm!");
                return;
            }

            switch (id)
            {
                case 0: //SHA512
                    {
                        var sha512 = SHA512.Create();
                        var inputBytes = Encoding.ASCII.GetBytes(boxInput.Text); 
                        if (isString == false)
                        {
                            inputBytes = File.ReadAllBytes(boxInput.Text);
                        }
                        var hash = sha512.ComputeHash(inputBytes);
                        var sb = new StringBuilder();
                        for (var i = 0; i < hash.Length; i++)
                        {
                            sb.Append(hash[i].ToString("X2"));
                        }
                        boxResponse.Text = sb.ToString();
                    break;
                    }
                    
                case 1: //SHA256
                    {
                        var sha256 = SHA256.Create();
                        var inputBytes = Encoding.ASCII.GetBytes(boxInput.Text);
                        if (isString == false)
                        {
                            inputBytes = File.ReadAllBytes(boxInput.Text);
                        }
                        var hash = sha256.ComputeHash(inputBytes);
                        var sb = new StringBuilder();
                        for (var i = 0; i < hash.Length; i++)
                        {
                            sb.Append(hash[i].ToString("X2"));
                        }
                        boxResponse.Text = sb.ToString();
                        break;
                    }
                case 2: //SHA1
                    {
                        var sha1 = SHA1.Create();
                        var inputBytes = Encoding.ASCII.GetBytes(boxInput.Text);
                        if (isString == false)
                        {
                            inputBytes = File.ReadAllBytes(boxInput.Text);
                        }
                        var hash = sha1.ComputeHash(inputBytes);
                        var sb = new StringBuilder();
                        for (var i = 0; i < hash.Length; i++)
                        {
                            sb.Append(hash[i].ToString("X2"));
                        }
                        boxResponse.Text = sb.ToString();
                        break;
                    }
                case 3: //MD5
                    {
                        var md5 = MD5.Create();
                        var inputBytes = Encoding.ASCII.GetBytes(boxInput.Text);
                        if (isString == false)
                        {
                            inputBytes = File.ReadAllBytes(boxInput.Text);
                        }
                        var hash = md5.ComputeHash(inputBytes);
                        var sb = new StringBuilder();
                        for (var i = 0; i < hash.Length; i++)
                        {
                            sb.Append(hash[i].ToString("X2"));
                        }
                        boxResponse.Text = sb.ToString();
                        break;
                    }                
            }
        }
    }
}
