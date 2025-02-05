﻿using System;
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
        private bool smtWentWrong = false;
        private bool createKeyPair = false;

        public frmPGP()
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
                    lblResponse.Text = "Encryption Succesfull!";
                    lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
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
                try
                {
                    using (PGP pgp = new PGP())
                    {
                        boxEnc.Text = pgp.ClearSignArmoredString(boxPlain.Text, boxKey.Text, boxPwd.Text);
                    }
                    lblResponse.Text = "Signing Succesfull!";
                    lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
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
                            lblResponse.Text = "String is not verified!";
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
                lblResponse.Text = "Decryption Succesfull!";
                lblResponse.ForeColor = Color.FromArgb(0, 128, 43);

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
            lblResponse.Text = "";

            if (boxKey.Text == "")
            {
                lblResponse.Text = "The Key shouldn't be empty!";
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

            if (isPublicKey)
            {
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
                    using (PGP pgp = new PGP())
                    {
                        using (FileStream inputFileStream = new FileStream(filepath, FileMode.Open))
                        using (Stream outputFileStream = File.Create(outfilepath))
                        using (Stream publicKeyStream = new MemoryStream(Encoding.ASCII.GetBytes(boxKey.Text)))
                            pgp.EncryptStream(inputFileStream, outputFileStream, publicKeyStream);
                    }
                    lblResponse.Text = "Encryption Succesfull!\n File has been safed to " + outfilepath;
                    lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
                    smtWentWrong = false;
                }
                catch (Exception)
                {
                    delFile(outfilepath, false);
                    lblResponse.Text = "Something went wrong!";
                    lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                    smtWentWrong = true;
                    return;
                }
                if (!smtWentWrong && checkDelFileAU.Checked)
                {
                    delFile(filepath, true);
                }
            }
            else
            {
                string outfilepath = filepath + ".SIGNED";

                string tmpfilename = filename;
                int i = 1;
                while (File.Exists(dirpath + "\\" + tmpfilename + ".SIGNED"))
                {
                    tmpfilename = i + "_" + filename;
                    i++;
                }
                outfilepath = dirpath + "\\" + tmpfilename + ".SIGNED";

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
                        outfilepath = dirpath + "\\" + ranfilename + ".SIGNED";
                    }
                    while (File.Exists(outfilepath));
                }

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
                        using (FileStream inputFileStream = new FileStream(filepath, FileMode.Open))
                        using (Stream outputFileStream = File.Create(outfilepath))
                        using (Stream publicKeyStream = new MemoryStream(Encoding.ASCII.GetBytes(boxKey.Text)))
                            pgp.ClearSignStream(inputFileStream, outputFileStream, publicKeyStream, boxPwd.Text);
                    }
                    lblResponse.Text = "Signation Succesfull!\n File has been safed to " + outfilepath;
                    lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
                    smtWentWrong = false;
                }
                catch (Exception)
                {
                    delFile(outfilepath, false);
                    lblResponse.Text = "The used Key or Password is wrong!";
                    lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                    smtWentWrong = true;
                    return;
                }
                if (!smtWentWrong && checkDelFileAU.Checked)
                {
                    delFile(filepath, true);
                }
            }
        }

        private void btnFileDec_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "";

            if (boxKey.Text == "")
            {
                lblResponse.Text = "The Key shouldn't be empty!";
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

            lblResponse.Text = "Decryption Succesfull!";
            lblResponse.ForeColor = Color.FromArgb(0, 128, 43);

            string dirpath = Path.GetDirectoryName(filepath);
            string filename = Path.GetFileName(filepath);

            if (isPublicKey)
            {
                if (filename.Contains(".SIGNED"))
                {
                    filename = filename.Remove((filename.Length - 7));
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
                    using (PGP pgp = new PGP())
                    {
                        using (FileStream inputFileStream = new FileStream(filepath, FileMode.Open))
                        using (Stream publicKeyStream = new MemoryStream(Encoding.ASCII.GetBytes(boxKey.Text)))
                            if (pgp.VerifyClearStream(inputFileStream, publicKeyStream))
                        {
                            lblResponse.Text = "File verified!";
                            lblResponse.ForeColor = Color.FromArgb(0, 128, 43);

                            string plainoutput;
                            var fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                            {
                                plainoutput = streamReader.ReadToEnd();
                            }
                            plainoutput = string.Join(' ', plainoutput.Split(Environment.NewLine.ToCharArray()).Skip(3).ToArray());
                            if (plainoutput.Contains("-----BEGIN PGP SIGNATURE-----"))
                            {
                                plainoutput = plainoutput.Remove(plainoutput.IndexOf("-----BEGIN PGP SIGNATURE-----"));
                            }
                            using (Stream outstream = new FileStream(outfilepath, FileMode.OpenOrCreate, FileAccess.Write))
                            {
                                outstream.Write(Encoding.ASCII.GetBytes(plainoutput));
                            }
                                smtWentWrong = false;
                        }
                        else
                        {
                            lblResponse.Text = "File is not verified!";
                            lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                            smtWentWrong = true;
                        }
                    }
                }
                catch (Exception)
                {
                    delFile(outfilepath, false);
                    lblResponse.Text = "The used Key is wrong!";
                    lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                    smtWentWrong = true;
                    return;
                }
                if (!smtWentWrong && checkDelFileAU.Checked)
                {
                    delFile(filepath, true);
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

                if (filename.Contains(".ENCRYPTED"))
                {
                    filename = filename.Remove((filename.Length - 10));
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
                    using (PGP pgp = new PGP())
                    {
                        using (FileStream inputFileStream = new FileStream(filepath, FileMode.Open))
                        using (Stream outputFileStream = File.Create(outfilepath))
                        using (Stream publicKeyStream = new MemoryStream(Encoding.ASCII.GetBytes(boxKey.Text)))
                            pgp.DecryptStream(inputFileStream, outputFileStream, publicKeyStream, boxPwd.Text);
                    }
                    lblResponse.Text = "Decryption Succesfull!\n File has been safed to " + outfilepath;
                    lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
                    smtWentWrong = false;
                }
                catch (Exception)
                {
                    delFile(outfilepath, false);
                    lblResponse.Text = "The used Key or Password is wrong!";
                    lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                    smtWentWrong = true;
                    return;
                }
                if (!smtWentWrong && checkDelFileAU.Checked)
                {
                    delFile(filepath, true);
                }
            }
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
            if (boxPlain.Text != "")
            {
                Clipboard.SetText(boxPlain.Text);
                lblResponse.Text = "Successfully copied text to Clipboard";
                lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
            }
        }

        private void btnCopyEnc_Click(object sender, EventArgs e)
        {
            if (boxEnc.Text != "")
            {
                Clipboard.SetText(boxEnc.Text);
                lblResponse.Text = "Successfully copied text to Clipboard";
                lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
            }
        }

        private void btnPasteEnc_Click(object sender, EventArgs e)
        {
            boxEnc.Text = Clipboard.GetText();
        }

        private void btnPastePlain_Click(object sender, EventArgs e)
        {
            boxPlain.Text = Clipboard.GetText();
        }

        private void btnPasteKey_Click(object sender, EventArgs e)
        {
            boxKey.Text = Clipboard.GetText();
        }

        private void boxKey_TextChanged(object sender, EventArgs e)
        {
            if (boxKey.Text.Contains("PUBLIC KEY") && !isPublicKey)
            {
                btnSwitchKey_Click(this, null);
            }
            else if (boxKey.Text.Contains("PRIVATE KEY") && isPublicKey)
            {
                btnSwitchKey_Click(this, null);
            }
        }

        private void btnKeyFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog file = new OpenFileDialog())
                {
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        using (var streamReader = new StreamReader(file.FileName, Encoding.ASCII))
                        {
                            boxKey.Text = streamReader.ReadToEnd();
                        }
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
            boxKey.Select(boxKey.Text.Length - 1, boxKey.Text.Length - 1);
            boxKey.ScrollToCaret();
        }

        private void boxKey_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void boxKey_DragDrop(object sender, DragEventArgs e)
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
                            boxKey.Text = streamReader.ReadToEnd();
                        }
                    }
                }
                else if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {
                    boxKey.Text = (string)e.Data.GetData(DataFormats.StringFormat);
                }
            }
            catch (Exception exception)
            {
                lblResponse.Text = "The selected file is invalid!" + exception;
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }
            boxKey.Select(boxKey.Text.Length - 1, boxKey.Text.Length - 1);
            boxKey.ScrollToCaret();
        }

        private void boxEnc_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
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

        private void boxPlain_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.StringFormat))
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

        private void btnCreateKeypair_Click(object sender, EventArgs e)
        {
            string outfilepath = "";

            if (createKeyPair == false)
            {
                btnKeyFile.Text = "name";

                lblResponse.Text = "Please enter a username/email and password and click 'generate Key pair again'";
                lblResponse.ForeColor = Color.FromArgb(0, 128, 43);

                createKeyPair = true;
                return;
            }
            else
            {

                try
                {
                    using (FolderBrowserDialog folder = new FolderBrowserDialog())
                    {
                        //folder.Description = "Select a folder ";
                        if (folder.ShowDialog() == DialogResult.OK)
                        {
                            outfilepath = folder.SelectedPath;
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
            }

            string fileplus = "";
            int i = 1;
            while (File.Exists(outfilepath + "\\" + fileplus + "privateKey.asc") || File.Exists(outfilepath + "\\" + fileplus + "publicKey.asc"))
            {
                fileplus = i + "_";
                i++;
            }

            try
            {
                using (PGP pgp = new PGP())
                {
                    pgp.GenerateKey(outfilepath + "\\" + fileplus + "publicKey.asc", outfilepath + "\\" + fileplus + "privateKey.asc", boxKey.Text, boxPwd.Text);
                }
                lblResponse.Text = "Successfully created Keyfiles. \nThe files have been safed to " + outfilepath;
                lblResponse.ForeColor = Color.FromArgb(0, 128, 43);
            }
            catch (Exception)
            {
                lblResponse.Text = "Insufficient permissions safing files to " + outfilepath;
                lblResponse.ForeColor = Color.FromArgb(128, 0, 0);
                return;
            }

            btnKeyFile.Text = "Key";
            createKeyPair = false;
        }
    }
}
