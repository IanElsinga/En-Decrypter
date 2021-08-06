using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using En_decrypter;

namespace en_decrypter
{
    //source: https://www.youtube.com/watch?v=vYDyGxoq9JU&t=270s

    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        Point lastPoint;

        frmStart FrmStart_Vrb = new frmStart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        frmPwdCreate FrmPwdCreate_Vrb = new frmPwdCreate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmSecDel FrmSecDel_Vrb = new FrmSecDel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        frmHashes FrmHashes_Vrb = new frmHashes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        frmAES FrmAES_Vrb = new frmAES() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        frmPGP FrmPGP_Vrb = new frmPGP() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        frmSettings frmSettings_Vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            menuTitle.Text = "Menu";
            this.PnlFormLoader.Controls.Clear();
            FrmStart_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmStart_Vrb);
            FrmStart_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            menuTitle.Text = "Menu";
            this.PnlFormLoader.Controls.Clear();
            FrmStart_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmStart_Vrb);
            FrmStart_Vrb.Show();

        }
        private void btnPwdCreate_Click(object sender, EventArgs e)
        {
            menuTitle.Text = "Password Generator";
            this.PnlFormLoader.Controls.Clear();
            FrmPwdCreate_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmPwdCreate_Vrb);
            FrmPwdCreate_Vrb.Show();
        }

        private void btnSecDel_Click(object sender, EventArgs e)
        {
            menuTitle.Text = "Secure Delete";
            this.PnlFormLoader.Controls.Clear();
            FrmSecDel_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmSecDel_Vrb);
            FrmSecDel_Vrb.Show();
        }
        private void btnHashes_Click(object sender, EventArgs e)
        {
            menuTitle.Text = "Hash Algorithms";
            this.PnlFormLoader.Controls.Clear();
            FrmHashes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHashes_Vrb);
            FrmHashes_Vrb.Show();
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            menuTitle.Text = "AES";
            this.PnlFormLoader.Controls.Clear();
            FrmAES_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmAES_Vrb);
            FrmAES_Vrb.Show();
            
        }
        private void btnPGP_Click(object sender, EventArgs e)
        {
            menuTitle.Text = "PGP";
            this.PnlFormLoader.Controls.Clear();
            FrmPGP_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmPGP_Vrb);
            FrmPGP_Vrb.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            menuTitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            frmSettings_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmSettings_Vrb);
            frmSettings_Vrb.Show();
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Make window moveable
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInvis_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Minimized;
        }
    }


}
