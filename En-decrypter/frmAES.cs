using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace En_decrypter
{
    public partial class frmAES : Form
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int BlockSize = 128;
        private bool smtWentWrong = false;

        public frmAES()
        {
            InitializeComponent();
        }


        private void delFile(string input, bool ask)
        {

            if (ask && MessageBox.Show("Are you sure you want to delete " + input + "? \nYou won't be able to recover it!", "Security Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            new FrmSecDel().SecDelFile(input);
        }
        private void btnEnc_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "";

            if (boxPwd.Text == "")
            {
                lblResponse.Text = "The Password shouldn't be empty!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }
            if (boxPlain.Text == "")
            {
                lblResponse.Text = "The PlainText shouldn't be empty!";
                lblResponse.ForeColor = Color.FromArgb(128,0,0);
                return;
            }
            byte[] bytes = Encoding.Unicode.GetBytes(boxPlain.Text);
            //Encrypt
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = SHA256.Create();
            crypt.BlockSize = BlockSize;
            crypt.Key = hash.ComputeHash(Encoding.UTF8.GetBytes(boxPwd.Text));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }

                boxEnc.Text = Convert.ToBase64String(memoryStream.ToArray());
            }
            lblResponse.Text = "Encryption Succesfull!";
            lblResponse.ForeColor = Color.FromArgb(0,128,43);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "";

            if (boxPwd.Text == "")
            {
                lblResponse.Text = "The Password shouldn't be empty!";
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
            try
            {
                byte[] bytes = Convert.FromBase64String(boxEnc.Text);
                SymmetricAlgorithm crypt = Aes.Create();
                HashAlgorithm hash = SHA256.Create();
                crypt.Key = hash.ComputeHash(Encoding.UTF8.GetBytes(boxPwd.Text));
                crypt.IV = IV;

                using (MemoryStream memoryStream = new MemoryStream(bytes))
                {
                    using (CryptoStream cryptoStream =
                       new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        byte[] decryptedBytes = new byte[bytes.Length];
                        cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                        boxPlain.Text = Encoding.Unicode.GetString(decryptedBytes);

                    }
                }
            }
            catch (Exception)
            {
                lblResponse.Text = "The used Password is wrong!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
            }
        }

        private void btnFileEnc_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "";

            if (boxPwd.Text == "")
            {
                lblResponse.Text = "The Password shouldn't be empty!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            string filepath = "";
            try
            {
                using (OpenFileDialog file = new OpenFileDialog())
                {
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        filepath = file.FileName;
                    }
                    else
                    {
                        lblResponse.Text = "You have to select a file!";
                        lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                        return;
                    }
                }
            }
            catch(Exception)
            {
                lblResponse.Text = "The selected file is invalid!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            if(filepath=="")
            {
                lblResponse.Text = "The selected file is invalid!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            byte[] bytes = System.IO.File.ReadAllBytes(filepath);

            string dirpath = Path.GetDirectoryName(filepath);
            string filename = Path.GetFileName(filepath);
            string outfilepath = filepath + ".ENCRYPTED";

            string tmpfilename = filename;
            int i = 1;
            while (File.Exists(dirpath + "\\" + tmpfilename + ".ENCRYPTED"))
            {
                tmpfilename = i + "_" + filename;
                i++;
            }
            outfilepath = dirpath + "\\" + tmpfilename + ".ENCRYPTED";

            if (checkRandomFileName.Checked)
            {
                //write original filename to end of file
                //writer.Write("\nENCRYPTEDFILENAME\n" + filename);
                //create random filename

                string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                StringBuilder res = new StringBuilder();
                do
                {
                    Random rnd = new Random();
                    int rannum = rnd.Next(5, 15);
                    while (0 < rannum--)
                    {
                        res.Append(valid[rnd.Next(valid.Length)]);
                    }
                    string ranfilename = res.ToString();
                    outfilepath = dirpath + "\\" + ranfilename + ".ENCRYPTED";
                }
                while (File.Exists(outfilepath));
            }
            try
            {
                using (SymmetricAlgorithm crypt = Aes.Create())
                using (FileStream fileStream = File.OpenRead(filepath))
                using (FileStream outFile = File.Create(outfilepath))
                {

                    HashAlgorithm hash = SHA256.Create();
                    crypt.BlockSize = BlockSize;
                    crypt.Key = hash.ComputeHash(Encoding.UTF8.GetBytes(boxPwd.Text));
                    crypt.IV = IV;

                    using (var cryptoStream =
                new CryptoStream(outFile, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                            fileStream.CopyTo(cryptoStream);
                    }
                }
                lblResponse.Text = "Encryption Succesfull!\n File has been safed to " + outfilepath;
                lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
                smtWentWrong = false;
            }
            catch(Exception)
            {
                delFile(outfilepath, false);
                lblResponse.Text = "Insufficient permissions safing file to " + outfilepath;
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                smtWentWrong = true;
            }
            if (!smtWentWrong && checkDelFileAU.Checked)
            {
                delFile(filepath, true);
            }

        }

        private void btnFileDec_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "";

            if (boxPwd.Text == "")
            {
                lblResponse.Text = "The Password shouldn't be empty!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            string filepath = "";
            try
            {
                using (OpenFileDialog file = new OpenFileDialog())
                {
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        filepath = file.FileName;
                    }
                    else
                    {
                        lblResponse.Text = "You have to select a file!";
                        lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                lblResponse.Text = "The selected file is invalid!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            if (filepath == "")
            {
                lblResponse.Text = "The selected file is invalid!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            string dirpath = Path.GetDirectoryName(filepath);
            string filename = Path.GetFileName(filepath);
            if(filename.Contains(".ENCRYPTED"))
            {
                filename = filename.Remove((filename.Length-10));
            }
            else
            {
                lblResponse.Text = "The file does not have the expected extension!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            string tmpfilename = filename;
            int i = 1;
            while (File.Exists(dirpath + "\\" + tmpfilename))
            {
                tmpfilename = i + "_" + filename;
                i++;
            }
            string outfilepath = dirpath + "\\" + tmpfilename;

            try
            {
                SymmetricAlgorithm crypt = Aes.Create();
                HashAlgorithm hash = SHA256.Create();
                crypt.Key = hash.ComputeHash(Encoding.UTF8.GetBytes(boxPwd.Text));
                crypt.IV = IV;

                using (SymmetricAlgorithm cipher = Aes.Create())
                using (FileStream fileStream = File.OpenRead(filepath))
                using (FileStream outFile = File.Create(outfilepath))
                {
                    using (var cryptoStream =
                        new CryptoStream(outFile, crypt.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        fileStream.CopyTo(cryptoStream);
                    }
                }
                smtWentWrong = false;
            }
            catch (Exception)
            {
                delFile(outfilepath, false);
                lblResponse.Text = "The used Password is wrong!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                smtWentWrong = true;
            }
            if (!smtWentWrong && checkDelFileAU.Checked)
            {
                delFile(filepath, true);
            }
        }
        private void boxPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopy1_Click(object sender, EventArgs e)
        {
            if (boxPlain.Text != "")
            {
                Clipboard.SetText(boxPlain.Text);
                lblResponse.Text = "Successfully copied text to Clipboard";
                lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
            }
        }

        private void btnCopy2_Click(object sender, EventArgs e)
        {
            if (boxEnc.Text != "")
            {
                Clipboard.SetText(boxEnc.Text);
                lblResponse.Text = "Successfully copied text to Clipboard";
                lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
            }
        }

        private void btnPastePlain_Click(object sender, EventArgs e)
        {
            boxPlain.Text = Clipboard.GetText();
        }

        private void button1_Click(object sender, EventArgs e) //btnPasteEnc
        {
            boxEnc.Text = Clipboard.GetText();
        }

        private void boxEnc_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void boxPlain_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    foreach (string file in files)
                    {
                        using (var streamReader = new StreamReader(file, Encoding.ASCII))
                        {
                            boxPlain.Text = streamReader.ReadToEnd();
                        }
                    }
                }
                else if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {
                    boxPlain.Text = (string)e.Data.GetData(DataFormats.StringFormat);
                }
            }
            catch (Exception)
            {
                lblResponse.Text = "The selected file is invalid!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }
            boxPlain.Select(boxPlain.Text.Length - 1, boxPlain.Text.Length - 1);
            boxPlain.ScrollToCaret();
        }

        private void boxEnc_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    foreach (string file in files)
                    {
                        using (var streamReader = new StreamReader(file, Encoding.ASCII))
                        {
                            boxEnc.Text = streamReader.ReadToEnd();
                        }
                    }
                }
                else if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {
                    boxEnc.Text = (string)e.Data.GetData(DataFormats.StringFormat);
                }
            }
            catch (Exception)
            {
                lblResponse.Text = "The selected file is invalid!";
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }
            boxEnc.Select(boxEnc.Text.Length - 1, boxEnc.Text.Length - 1);
            boxEnc.ScrollToCaret();
        }

        private void boxPlain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
