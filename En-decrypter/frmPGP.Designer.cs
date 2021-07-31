
namespace En_decrypter
{
    partial class frmPGP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPGP));
            this.checkRandomFileName = new System.Windows.Forms.CheckBox();
            this.btnFileDec = new System.Windows.Forms.Button();
            this.checkDelFileAU = new System.Windows.Forms.CheckBox();
            this.btnFileEnc = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnEnc = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblEncTxt = new System.Windows.Forms.Label();
            this.boxEnc = new System.Windows.Forms.TextBox();
            this.lblPlainTxt = new System.Windows.Forms.Label();
            this.boxPlain = new System.Windows.Forms.TextBox();
            this.boxKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxPwd = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSwitchKey = new System.Windows.Forms.Button();
            this.btnCopyPlain = new System.Windows.Forms.Button();
            this.btnCopyEnc = new System.Windows.Forms.Button();
            this.btnPastePlain = new System.Windows.Forms.Button();
            this.btnPasteEnc = new System.Windows.Forms.Button();
            this.btnPasteKey = new System.Windows.Forms.Button();
            this.btnKeyFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkRandomFileName
            // 
            this.checkRandomFileName.AutoSize = true;
            this.checkRandomFileName.Location = new System.Drawing.Point(285, 45);
            this.checkRandomFileName.Name = "checkRandomFileName";
            this.checkRandomFileName.Size = new System.Drawing.Size(141, 19);
            this.checkRandomFileName.TabIndex = 29;
            this.checkRandomFileName.Text = "use random file name";
            this.checkRandomFileName.UseVisualStyleBackColor = true;
            // 
            // btnFileDec
            // 
            this.btnFileDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDec.Location = new System.Drawing.Point(379, 91);
            this.btnFileDec.Name = "btnFileDec";
            this.btnFileDec.Size = new System.Drawing.Size(78, 34);
            this.btnFileDec.TabIndex = 28;
            this.btnFileDec.Text = "verify file";
            this.btnFileDec.UseVisualStyleBackColor = true;
            this.btnFileDec.Click += new System.EventHandler(this.btnFileDec_Click);
            // 
            // checkDelFileAU
            // 
            this.checkDelFileAU.AutoSize = true;
            this.checkDelFileAU.Location = new System.Drawing.Point(285, 68);
            this.checkDelFileAU.Name = "checkDelFileAU";
            this.checkDelFileAU.Size = new System.Drawing.Size(125, 19);
            this.checkDelFileAU.TabIndex = 27;
            this.checkDelFileAU.Text = "delete file after use";
            this.checkDelFileAU.UseVisualStyleBackColor = true;
            // 
            // btnFileEnc
            // 
            this.btnFileEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileEnc.Location = new System.Drawing.Point(285, 91);
            this.btnFileEnc.Name = "btnFileEnc";
            this.btnFileEnc.Size = new System.Drawing.Size(78, 34);
            this.btnFileEnc.TabIndex = 26;
            this.btnFileEnc.Text = "encrypt file";
            this.btnFileEnc.UseVisualStyleBackColor = true;
            this.btnFileEnc.Click += new System.EventHandler(this.btnFileEnc_Click);
            // 
            // btnDec
            // 
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDec.Location = new System.Drawing.Point(144, 91);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(78, 34);
            this.btnDec.TabIndex = 25;
            this.btnDec.Text = "verify";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnEnc
            // 
            this.btnEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnc.Location = new System.Drawing.Point(22, 91);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(78, 34);
            this.btnEnc.TabIndex = 24;
            this.btnEnc.Text = "encrypt";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(22, 130);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(0, 15);
            this.lblResponse.TabIndex = 23;
            // 
            // lblEncTxt
            // 
            this.lblEncTxt.AutoSize = true;
            this.lblEncTxt.Location = new System.Drawing.Point(22, 319);
            this.lblEncTxt.Name = "lblEncTxt";
            this.lblEncTxt.Size = new System.Drawing.Size(87, 15);
            this.lblEncTxt.TabIndex = 20;
            this.lblEncTxt.Text = "Encrypted Text:";
            // 
            // boxEnc
            // 
            this.boxEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxEnc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxEnc.Location = new System.Drawing.Point(22, 337);
            this.boxEnc.Multiline = true;
            this.boxEnc.Name = "boxEnc";
            this.boxEnc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxEnc.Size = new System.Drawing.Size(504, 127);
            this.boxEnc.TabIndex = 19;
            // 
            // lblPlainTxt
            // 
            this.lblPlainTxt.AutoSize = true;
            this.lblPlainTxt.Location = new System.Drawing.Point(22, 161);
            this.lblPlainTxt.Name = "lblPlainTxt";
            this.lblPlainTxt.Size = new System.Drawing.Size(60, 15);
            this.lblPlainTxt.TabIndex = 18;
            this.lblPlainTxt.Text = "Plain Text:";
            // 
            // boxPlain
            // 
            this.boxPlain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxPlain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxPlain.Location = new System.Drawing.Point(22, 179);
            this.boxPlain.Multiline = true;
            this.boxPlain.Name = "boxPlain";
            this.boxPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxPlain.Size = new System.Drawing.Size(504, 127);
            this.boxPlain.TabIndex = 17;
            // 
            // boxKey
            // 
            this.boxKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxKey.Location = new System.Drawing.Point(22, 26);
            this.boxKey.Margin = new System.Windows.Forms.Padding(2);
            this.boxKey.Multiline = true;
            this.boxKey.Name = "boxKey";
            this.boxKey.Size = new System.Drawing.Size(200, 26);
            this.boxKey.TabIndex = 30;
            this.boxKey.TextChanged += new System.EventHandler(this.boxKey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Password/ Passphrase";
            // 
            // boxPwd
            // 
            this.boxPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxPwd.Location = new System.Drawing.Point(22, 71);
            this.boxPwd.Margin = new System.Windows.Forms.Padding(2);
            this.boxPwd.Name = "boxPwd";
            this.boxPwd.Size = new System.Drawing.Size(201, 16);
            this.boxPwd.TabIndex = 32;
            // 
            // btnSwitchKey
            // 
            this.btnSwitchKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchKey.Location = new System.Drawing.Point(285, 21);
            this.btnSwitchKey.Name = "btnSwitchKey";
            this.btnSwitchKey.Size = new System.Drawing.Size(147, 23);
            this.btnSwitchKey.TabIndex = 34;
            this.btnSwitchKey.Text = "use private Key";
            this.btnSwitchKey.UseVisualStyleBackColor = true;
            this.btnSwitchKey.Click += new System.EventHandler(this.btnSwitchKey_Click);
            // 
            // btnCopyPlain
            // 
            this.btnCopyPlain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnCopyPlain.FlatAppearance.BorderSize = 0;
            this.btnCopyPlain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPlain.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopyPlain.Location = new System.Drawing.Point(464, 275);
            this.btnCopyPlain.Name = "btnCopyPlain";
            this.btnCopyPlain.Size = new System.Drawing.Size(45, 31);
            this.btnCopyPlain.TabIndex = 35;
            this.btnCopyPlain.Text = "copy";
            this.btnCopyPlain.UseVisualStyleBackColor = false;
            this.btnCopyPlain.Click += new System.EventHandler(this.btnCopyPlain_Click);
            // 
            // btnCopyEnc
            // 
            this.btnCopyEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnCopyEnc.FlatAppearance.BorderSize = 0;
            this.btnCopyEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyEnc.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopyEnc.Location = new System.Drawing.Point(464, 433);
            this.btnCopyEnc.Name = "btnCopyEnc";
            this.btnCopyEnc.Size = new System.Drawing.Size(45, 31);
            this.btnCopyEnc.TabIndex = 36;
            this.btnCopyEnc.Text = "copy";
            this.btnCopyEnc.UseVisualStyleBackColor = false;
            this.btnCopyEnc.Click += new System.EventHandler(this.btnCopyEnc_Click);
            // 
            // btnPastePlain
            // 
            this.btnPastePlain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnPastePlain.FlatAppearance.BorderSize = 0;
            this.btnPastePlain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPastePlain.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPastePlain.Location = new System.Drawing.Point(464, 179);
            this.btnPastePlain.Name = "btnPastePlain";
            this.btnPastePlain.Size = new System.Drawing.Size(45, 31);
            this.btnPastePlain.TabIndex = 37;
            this.btnPastePlain.Text = "paste";
            this.btnPastePlain.UseVisualStyleBackColor = false;
            this.btnPastePlain.Click += new System.EventHandler(this.btnPastePlain_Click);
            // 
            // btnPasteEnc
            // 
            this.btnPasteEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnPasteEnc.FlatAppearance.BorderSize = 0;
            this.btnPasteEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteEnc.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPasteEnc.Location = new System.Drawing.Point(464, 337);
            this.btnPasteEnc.Name = "btnPasteEnc";
            this.btnPasteEnc.Size = new System.Drawing.Size(45, 31);
            this.btnPasteEnc.TabIndex = 38;
            this.btnPasteEnc.Text = "paste";
            this.btnPasteEnc.UseVisualStyleBackColor = false;
            this.btnPasteEnc.Click += new System.EventHandler(this.btnPasteEnc_Click);
            // 
            // btnPasteKey
            // 
            this.btnPasteKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnPasteKey.FlatAppearance.BorderSize = 0;
            this.btnPasteKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteKey.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPasteKey.Location = new System.Drawing.Point(175, 26);
            this.btnPasteKey.Name = "btnPasteKey";
            this.btnPasteKey.Size = new System.Drawing.Size(47, 26);
            this.btnPasteKey.TabIndex = 39;
            this.btnPasteKey.Text = "paste";
            this.btnPasteKey.UseVisualStyleBackColor = false;
            this.btnPasteKey.Click += new System.EventHandler(this.btnPasteKey_Click);
            // 
            // btnKeyFile
            // 
            this.btnKeyFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.btnKeyFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKeyFile.Location = new System.Drawing.Point(22, 3);
            this.btnKeyFile.Name = "btnKeyFile";
            this.btnKeyFile.Size = new System.Drawing.Size(87, 23);
            this.btnKeyFile.TabIndex = 40;
            this.btnKeyFile.Text = "Key";
            this.btnKeyFile.UseVisualStyleBackColor = false;
            this.btnKeyFile.Click += new System.EventHandler(this.btnKeyFile_Click);
            // 
            // frmPGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(552, 487);
            this.Controls.Add(this.btnKeyFile);
            this.Controls.Add(this.btnPasteKey);
            this.Controls.Add(this.btnPasteEnc);
            this.Controls.Add(this.btnPastePlain);
            this.Controls.Add(this.btnCopyEnc);
            this.Controls.Add(this.btnCopyPlain);
            this.Controls.Add(this.btnSwitchKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxPwd);
            this.Controls.Add(this.boxKey);
            this.Controls.Add(this.checkRandomFileName);
            this.Controls.Add(this.btnFileDec);
            this.Controls.Add(this.checkDelFileAU);
            this.Controls.Add(this.btnFileEnc);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblEncTxt);
            this.Controls.Add(this.boxEnc);
            this.Controls.Add(this.lblPlainTxt);
            this.Controls.Add(this.boxPlain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPGP";
            this.Text = "frmPGP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkRandomFileName;
        private System.Windows.Forms.Button btnFileDec;
        private System.Windows.Forms.CheckBox checkDelFileAU;
        private System.Windows.Forms.Button btnFileEnc;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblEncTxt;
        private System.Windows.Forms.TextBox boxEnc;
        private System.Windows.Forms.Label lblPlainTxt;
        private System.Windows.Forms.TextBox boxPlain;
        private System.Windows.Forms.TextBox boxKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxPwd;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSwitchKey;
        private System.Windows.Forms.Button btnCopyPlain;
        private System.Windows.Forms.Button btnCopyEnc;
        private System.Windows.Forms.Button btnPastePlain;
        private System.Windows.Forms.Button btnPasteEnc;
        private System.Windows.Forms.Button btnPasteKey;
        private System.Windows.Forms.Button btnKeyFile;
    }
}