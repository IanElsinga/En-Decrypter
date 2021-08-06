
namespace en_decrypter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHashes = new System.Windows.Forms.Button();
            this.btnSecDel = new System.Windows.Forms.Button();
            this.btnPGP = new System.Windows.Forms.Button();
            this.btnAES = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPwdCreate = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnInvis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnHashes);
            this.panel1.Controls.Add(this.btnSecDel);
            this.panel1.Controls.Add(this.btnPGP);
            this.panel1.Controls.Add(this.btnAES);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnPwdCreate);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnHashes
            // 
            this.btnHashes.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnHashes, "btnHashes");
            this.btnHashes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHashes.Name = "btnHashes";
            this.btnHashes.UseVisualStyleBackColor = true;
            this.btnHashes.Click += new System.EventHandler(this.btnHashes_Click);
            // 
            // btnSecDel
            // 
            resources.ApplyResources(this.btnSecDel, "btnSecDel");
            this.btnSecDel.FlatAppearance.BorderSize = 0;
            this.btnSecDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSecDel.Name = "btnSecDel";
            this.btnSecDel.UseVisualStyleBackColor = true;
            this.btnSecDel.Click += new System.EventHandler(this.btnSecDel_Click);
            // 
            // btnPGP
            // 
            this.btnPGP.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPGP, "btnPGP");
            this.btnPGP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPGP.Name = "btnPGP";
            this.btnPGP.UseVisualStyleBackColor = true;
            this.btnPGP.Click += new System.EventHandler(this.btnPGP_Click);
            // 
            // btnAES
            // 
            this.btnAES.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAES, "btnAES");
            this.btnAES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAES.Name = "btnAES";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPwdCreate
            // 
            resources.ApplyResources(this.btnPwdCreate, "btnPwdCreate");
            this.btnPwdCreate.FlatAppearance.BorderSize = 0;
            this.btnPwdCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPwdCreate.Name = "btnPwdCreate";
            this.btnPwdCreate.UseVisualStyleBackColor = true;
            this.btnPwdCreate.Click += new System.EventHandler(this.btnPwdCreate_Click);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.profilePic);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // profilePic
            // 
            resources.ApplyResources(this.profilePic, "profilePic");
            this.profilePic.Name = "profilePic";
            this.profilePic.TabStop = false;
            this.profilePic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PnlFormLoader
            // 
            resources.ApplyResources(this.PnlFormLoader, "PnlFormLoader");
            this.PnlFormLoader.Name = "PnlFormLoader";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // menuTitle
            // 
            resources.ApplyResources(this.menuTitle, "menuTitle");
            this.menuTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuTitle.Name = "menuTitle";
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnInvis
            // 
            this.btnInvis.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnInvis, "btnInvis");
            this.btnInvis.Name = "btnInvis";
            this.btnInvis.TabStop = false;
            this.btnInvis.UseMnemonic = false;
            this.btnInvis.UseVisualStyleBackColor = true;
            this.btnInvis.Click += new System.EventHandler(this.btnInvis_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.btnInvis);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.menuTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Button btnPGP;
        private System.Windows.Forms.Button btnPwdCreate;
        private System.Windows.Forms.Button btnSecDel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInvis;
        private System.Windows.Forms.Button btnHashes;
    }
}

