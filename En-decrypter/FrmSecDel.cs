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
using SecureDelete;

namespace En_decrypter
{
    public partial class FrmSecDel : Form
    {
        public FrmSecDel()
        {
            InitializeComponent();
        }

        public string SecDelFile(String input)
        {
            string response = input + " has been deleted successfully!";

            /* Timeout/ pause program
            var task = Task.Run(() => SecDelFile(""));
            task.Wait(TimeSpan.FromSeconds(2));
            */

            try
            {
                FileAttributes attr = File.GetAttributes(input);

                if (attr.HasFlag(FileAttributes.Directory))
                    try
                    {
                        Delete.DeleteDirectoryWithoutDriveDetection(new DirectoryInfo(input), true);
                    }
                    catch (Exception)
                    {
                        response = "error: insufficient permissions processing " + input;
                    }
                else if (File.Exists(input))
                    try
                    {
                        Delete.DeleteFileWithoutDriveDetection(new FileInfo(input));
                    }
                    catch (Exception)
                    {
                        response = "error: insufficient permissions processing " + input;
                    }
                else
                    response = "error: " + input + " is an invalid input!";
            }
            catch (Exception)
            {
                response = "error: " + input + " is an invalid input!";
            }
            return response;

        }

        private void btnDelAsk_Click(object sender, EventArgs e)
        {
            boxResponse.Clear();
            if (boxInput.Text == "")
            {
                boxResponse.SelectionColor = true ? Color.Red : Color.Red;
                boxResponse.AppendText("The files shouldn't be empty");
            }

            string[] array = boxInput.Text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string response = "";
            string successfulMsgs = "";
            string errorMsgs = "";

            if (MessageBox.Show("Are you sure you want to delete those files and folders? \nYou won't be able to recover them!", "Security Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            boxInput.Clear();

            foreach (String item in array)
            {
                response = SecDelFile(item);
                if (response.Contains("success"))
                {
                    boxResponse.SelectionColor = true ? Color.Green : Color.Green;
                    successfulMsgs = successfulMsgs + response + "\n";
                    boxResponse.SelectionColor = true ? Color.Green : Color.Green;
                    boxResponse.AppendText(response + "\n");
                }
                else
                {
                    boxResponse.SelectionColor = true ? Color.Red : Color.Red;
                    errorMsgs = errorMsgs + "\n" + response;
                    boxResponse.SelectionColor = true ? Color.Red : Color.Red;
                    boxResponse.AppendText(response + "\n");
                    boxInput.AppendText(item + Environment.NewLine);
                }
            }

            boxResponse.Clear();
            if (successfulMsgs != "")
            {
                boxResponse.SelectionColor = true ? Color.Green : Color.Green;
                boxResponse.AppendText(successfulMsgs);
            }
            if (errorMsgs != "")
            {
                boxResponse.SelectionColor = true ? Color.Red : Color.Red;
                boxResponse.AppendText(errorMsgs);
            }

            //Scroll to end of Response box when finished
            try
            {
                boxResponse.Select(boxResponse.Text.Length - 1, boxResponse.Text.Length - 1);
                boxResponse.ScrollToCaret();
            }
            catch (Exception) { }
        }

        private void boxInput_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    boxInput.Text = boxInput.Text + Environment.NewLine + files[i];
                }
            }
            boxInput.Select(boxInput.Text.Length - 1, boxInput.Text.Length - 1);
            boxInput.ScrollToCaret();
            
        }

        private void boxInput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void boxInput_TextChanged(object sender, EventArgs e)
        {
            boxInput.Text = boxInput.Text.TrimStart();
            boxInput.Text = boxInput.Text.Replace("\r\n\r\n", "\r\n");
        }
    }
}
