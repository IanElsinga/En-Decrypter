
namespace En_decrypter
{
    partial class frmPwdCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPwdCreate));
            this.boxPwdCreate = new System.Windows.Forms.TextBox();
            this.btnPwdCreate = new System.Windows.Forms.Button();
            this.boxPwdLength = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkUppercase = new System.Windows.Forms.CheckBox();
            this.checkNumbers = new System.Windows.Forms.CheckBox();
            this.checkSpecialChar = new System.Windows.Forms.CheckBox();
            this.btnPwdCopy = new System.Windows.Forms.Button();
            this.checkLowercase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // boxPwdCreate
            // 
            this.boxPwdCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxPwdCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxPwdCreate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.boxPwdCreate.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxPwdCreate.Location = new System.Drawing.Point(50, 273);
            this.boxPwdCreate.Name = "boxPwdCreate";
            this.boxPwdCreate.Size = new System.Drawing.Size(392, 23);
            this.boxPwdCreate.TabIndex = 1;
            // 
            // btnPwdCreate
            // 
            this.btnPwdCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPwdCreate.Location = new System.Drawing.Point(51, 61);
            this.btnPwdCreate.Name = "btnPwdCreate";
            this.btnPwdCreate.Size = new System.Drawing.Size(98, 23);
            this.btnPwdCreate.TabIndex = 2;
            this.btnPwdCreate.Text = "new Password";
            this.btnPwdCreate.UseVisualStyleBackColor = true;
            this.btnPwdCreate.Click += new System.EventHandler(this.btnPwdCreate_Click);
            // 
            // boxPwdLength
            // 
            this.boxPwdLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxPwdLength.Location = new System.Drawing.Point(51, 99);
            this.boxPwdLength.Name = "boxPwdLength";
            this.boxPwdLength.Size = new System.Drawing.Size(49, 23);
            this.boxPwdLength.TabIndex = 3;
            this.boxPwdLength.Text = "20";
            this.boxPwdLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResponse
            // 
            this.lblResponse.Location = new System.Drawing.Point(50, 240);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(376, 18);
            this.lblResponse.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "password length";
            // 
            // checkUppercase
            // 
            this.checkUppercase.AutoSize = true;
            this.checkUppercase.Checked = true;
            this.checkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUppercase.Location = new System.Drawing.Point(50, 160);
            this.checkUppercase.Name = "checkUppercase";
            this.checkUppercase.Size = new System.Drawing.Size(101, 19);
            this.checkUppercase.TabIndex = 6;
            this.checkUppercase.Text = "use uppercase";
            this.checkUppercase.UseVisualStyleBackColor = true;
            // 
            // checkNumbers
            // 
            this.checkNumbers.AutoSize = true;
            this.checkNumbers.Checked = true;
            this.checkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNumbers.Location = new System.Drawing.Point(50, 185);
            this.checkNumbers.Name = "checkNumbers";
            this.checkNumbers.Size = new System.Drawing.Size(94, 19);
            this.checkNumbers.TabIndex = 7;
            this.checkNumbers.Text = "use numbers";
            this.checkNumbers.UseVisualStyleBackColor = true;
            // 
            // checkSpecialChar
            // 
            this.checkSpecialChar.AutoSize = true;
            this.checkSpecialChar.Checked = true;
            this.checkSpecialChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSpecialChar.Location = new System.Drawing.Point(50, 210);
            this.checkSpecialChar.Name = "checkSpecialChar";
            this.checkSpecialChar.Size = new System.Drawing.Size(140, 19);
            this.checkSpecialChar.TabIndex = 8;
            this.checkSpecialChar.Text = "use special characters";
            this.checkSpecialChar.UseVisualStyleBackColor = true;
            // 
            // btnPwdCopy
            // 
            this.btnPwdCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPwdCopy.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPwdCopy.Location = new System.Drawing.Point(448, 273);
            this.btnPwdCopy.Name = "btnPwdCopy";
            this.btnPwdCopy.Size = new System.Drawing.Size(76, 23);
            this.btnPwdCopy.TabIndex = 9;
            this.btnPwdCopy.Text = "copy";
            this.btnPwdCopy.UseVisualStyleBackColor = true;
            this.btnPwdCopy.Click += new System.EventHandler(this.btnPwdCopy_Click);
            // 
            // checkLowercase
            // 
            this.checkLowercase.AutoSize = true;
            this.checkLowercase.Checked = true;
            this.checkLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLowercase.Location = new System.Drawing.Point(50, 135);
            this.checkLowercase.Name = "checkLowercase";
            this.checkLowercase.Size = new System.Drawing.Size(99, 19);
            this.checkLowercase.TabIndex = 13;
            this.checkLowercase.Text = "use lowercase";
            this.checkLowercase.UseVisualStyleBackColor = true;
            // 
            // frmPwdCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(552, 487);
            this.Controls.Add(this.checkLowercase);
            this.Controls.Add(this.btnPwdCopy);
            this.Controls.Add(this.checkSpecialChar);
            this.Controls.Add(this.checkNumbers);
            this.Controls.Add(this.checkUppercase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.boxPwdLength);
            this.Controls.Add(this.btnPwdCreate);
            this.Controls.Add(this.boxPwdCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPwdCreate";
            this.Text = "frmPwdCreate";
            this.Load += new System.EventHandler(this.frmPwdCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxPwdCreate;
        private System.Windows.Forms.Button btnPwdCreate;
        private System.Windows.Forms.TextBox boxPwdLength;
        private System.Windows.Forms.Label lblResoponse;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkUppercase;
        private System.Windows.Forms.CheckBox checkNumbers;
        private System.Windows.Forms.CheckBox checkSpecialChar;
        private System.Windows.Forms.Button btnPwdCopy;
        private System.Windows.Forms.CheckBox checkLowercase;
    }
}