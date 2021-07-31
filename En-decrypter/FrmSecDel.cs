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
    public partial class FrmSecDel : Form
    {
        public FrmSecDel()
        {
            InitializeComponent();
        }

        private void btnDelAsk_Click(object sender, EventArgs e)
        {


            /*
             * using SecureDelete;


            Delete.DeleteDirectory(new DirectoryInfo(@"F:\MyFolderOnHdd"), true);

            Delete.DeleteDirectoryWithoutDriveDetection(new DirectoryInfo(@"F:\MyFolderOnHdd"), true);

            Delete.DeleteFile(@"F:\aFile.jpg");

            Delete.DeleteFileWithoutDriveDetection(@"F:\aFile.jpg");
            */
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
        }

        private void boxInput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
