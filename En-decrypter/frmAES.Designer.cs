﻿
namespace En_decrypter
{
    partial class frmAES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAES));
            this.boxPlain = new System.Windows.Forms.TextBox();
            this.lblPlainTxt = new System.Windows.Forms.Label();
            this.lblEncTxt = new System.Windows.Forms.Label();
            this.boxEnc = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.boxPwd = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.btnEnc = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnFileEnc = new System.Windows.Forms.Button();
            this.checkDelFileAU = new System.Windows.Forms.CheckBox();
            this.btnFileDec = new System.Windows.Forms.Button();
            this.checkRandomFileName = new System.Windows.Forms.CheckBox();
            this.btnCopy1 = new System.Windows.Forms.Button();
            this.btnCopy2 = new System.Windows.Forms.Button();
            this.btnPastePlain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxPlain
            // 
            this.boxPlain.AllowDrop = true;
            this.boxPlain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxPlain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxPlain.Location = new System.Drawing.Point(22, 179);
            this.boxPlain.Multiline = true;
            this.boxPlain.Name = "boxPlain";
            this.boxPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxPlain.Size = new System.Drawing.Size(504, 127);
            this.boxPlain.TabIndex = 2;
            this.boxPlain.DragDrop += new System.Windows.Forms.DragEventHandler(this.boxPlain_DragDrop);
            this.boxPlain.DragEnter += new System.Windows.Forms.DragEventHandler(this.boxPlain_DragEnter);
            // 
            // lblPlainTxt
            // 
            this.lblPlainTxt.AutoSize = true;
            this.lblPlainTxt.Location = new System.Drawing.Point(22, 161);
            this.lblPlainTxt.Name = "lblPlainTxt";
            this.lblPlainTxt.Size = new System.Drawing.Size(60, 15);
            this.lblPlainTxt.TabIndex = 1;
            this.lblPlainTxt.Text = "Plain Text:";
            // 
            // lblEncTxt
            // 
            this.lblEncTxt.AutoSize = true;
            this.lblEncTxt.Location = new System.Drawing.Point(22, 319);
            this.lblEncTxt.Name = "lblEncTxt";
            this.lblEncTxt.Size = new System.Drawing.Size(87, 15);
            this.lblEncTxt.TabIndex = 3;
            this.lblEncTxt.Text = "Encrypted Text:";
            // 
            // boxEnc
            // 
            this.boxEnc.AllowDrop = true;
            this.boxEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxEnc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxEnc.Location = new System.Drawing.Point(22, 337);
            this.boxEnc.Multiline = true;
            this.boxEnc.Name = "boxEnc";
            this.boxEnc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxEnc.Size = new System.Drawing.Size(504, 127);
            this.boxEnc.TabIndex = 3;
            this.boxEnc.DragDrop += new System.Windows.Forms.DragEventHandler(this.boxEnc_DragDrop);
            this.boxEnc.DragEnter += new System.Windows.Forms.DragEventHandler(this.boxEnc_DragEnter);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(22, 32);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(60, 15);
            this.lblPwd.TabIndex = 5;
            this.lblPwd.Text = "Password:";
            // 
            // boxPwd
            // 
            this.boxPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxPwd.Location = new System.Drawing.Point(22, 50);
            this.boxPwd.Name = "boxPwd";
            this.boxPwd.Size = new System.Drawing.Size(200, 16);
            this.boxPwd.TabIndex = 1;
            this.boxPwd.TextChanged += new System.EventHandler(this.boxPwd_TextChanged);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(22, 123);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(0, 15);
            this.lblResponse.TabIndex = 6;
            // 
            // btnEnc
            // 
            this.btnEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnc.Location = new System.Drawing.Point(22, 80);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(78, 34);
            this.btnEnc.TabIndex = 4;
            this.btnEnc.Text = "encrypt";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // btnDec
            // 
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDec.Location = new System.Drawing.Point(144, 80);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(78, 34);
            this.btnDec.TabIndex = 5;
            this.btnDec.Text = "decrypt";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnFileEnc
            // 
            this.btnFileEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileEnc.Location = new System.Drawing.Point(286, 80);
            this.btnFileEnc.Name = "btnFileEnc";
            this.btnFileEnc.Size = new System.Drawing.Size(78, 34);
            this.btnFileEnc.TabIndex = 8;
            this.btnFileEnc.Text = "encrypt file";
            this.btnFileEnc.UseVisualStyleBackColor = true;
            this.btnFileEnc.Click += new System.EventHandler(this.btnFileEnc_Click);
            // 
            // checkDelFileAU
            // 
            this.checkDelFileAU.AutoSize = true;
            this.checkDelFileAU.Location = new System.Drawing.Point(286, 51);
            this.checkDelFileAU.Name = "checkDelFileAU";
            this.checkDelFileAU.Size = new System.Drawing.Size(125, 19);
            this.checkDelFileAU.TabIndex = 7;
            this.checkDelFileAU.Text = "delete file after use";
            this.checkDelFileAU.UseVisualStyleBackColor = true;
            // 
            // btnFileDec
            // 
            this.btnFileDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDec.Location = new System.Drawing.Point(381, 80);
            this.btnFileDec.Name = "btnFileDec";
            this.btnFileDec.Size = new System.Drawing.Size(78, 34);
            this.btnFileDec.TabIndex = 9;
            this.btnFileDec.Text = "decrypt file";
            this.btnFileDec.UseVisualStyleBackColor = true;
            this.btnFileDec.Click += new System.EventHandler(this.btnFileDec_Click);
            // 
            // checkRandomFileName
            // 
            this.checkRandomFileName.AutoSize = true;
            this.checkRandomFileName.Location = new System.Drawing.Point(286, 28);
            this.checkRandomFileName.Name = "checkRandomFileName";
            this.checkRandomFileName.Size = new System.Drawing.Size(141, 19);
            this.checkRandomFileName.TabIndex = 6;
            this.checkRandomFileName.Text = "use random file name";
            this.checkRandomFileName.UseVisualStyleBackColor = true;
            // 
            // btnCopy1
            // 
            this.btnCopy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnCopy1.FlatAppearance.BorderSize = 0;
            this.btnCopy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopy1.Location = new System.Drawing.Point(464, 275);
            this.btnCopy1.Name = "btnCopy1";
            this.btnCopy1.Size = new System.Drawing.Size(45, 31);
            this.btnCopy1.TabIndex = 17;
            this.btnCopy1.TabStop = false;
            this.btnCopy1.Text = "copy";
            this.btnCopy1.UseVisualStyleBackColor = false;
            this.btnCopy1.Click += new System.EventHandler(this.btnCopy1_Click);
            // 
            // btnCopy2
            // 
            this.btnCopy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnCopy2.FlatAppearance.BorderSize = 0;
            this.btnCopy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopy2.Location = new System.Drawing.Point(464, 433);
            this.btnCopy2.Name = "btnCopy2";
            this.btnCopy2.Size = new System.Drawing.Size(45, 31);
            this.btnCopy2.TabIndex = 18;
            this.btnCopy2.TabStop = false;
            this.btnCopy2.Text = "copy";
            this.btnCopy2.UseVisualStyleBackColor = false;
            this.btnCopy2.Click += new System.EventHandler(this.btnCopy2_Click);
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
            this.btnPastePlain.TabIndex = 19;
            this.btnPastePlain.TabStop = false;
            this.btnPastePlain.Text = "paste";
            this.btnPastePlain.UseVisualStyleBackColor = false;
            this.btnPastePlain.Click += new System.EventHandler(this.btnPastePlain_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(464, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 31);
            this.button1.TabIndex = 20;
            this.button1.TabStop = false;
            this.button1.Text = "paste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(552, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPastePlain);
            this.Controls.Add(this.btnCopy2);
            this.Controls.Add(this.btnCopy1);
            this.Controls.Add(this.checkRandomFileName);
            this.Controls.Add(this.btnFileDec);
            this.Controls.Add(this.checkDelFileAU);
            this.Controls.Add(this.btnFileEnc);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.boxPwd);
            this.Controls.Add(this.lblEncTxt);
            this.Controls.Add(this.boxEnc);
            this.Controls.Add(this.lblPlainTxt);
            this.Controls.Add(this.boxPlain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAES";
            this.Text = "frmAES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxPlain;
        private System.Windows.Forms.Label lblPlainTxt;
        private System.Windows.Forms.Label lblEncTxt;
        private System.Windows.Forms.TextBox boxEnc;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox boxPwd;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnFileEnc;
        private System.Windows.Forms.CheckBox checkDelFileAU;
        private System.Windows.Forms.Button btnFileDec;
        private System.Windows.Forms.CheckBox checkRandomFileName;
        private System.Windows.Forms.Button btnCopy1;
        private System.Windows.Forms.Button btnCopy2;
        private System.Windows.Forms.Button btnPastePlain;
        private System.Windows.Forms.Button button1;
    }
}