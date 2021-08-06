
namespace En_decrypter
{
    partial class frmHashes
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
            this.boxResponse = new System.Windows.Forms.RichTextBox();
            this.boxInput = new System.Windows.Forms.TextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.comboHashes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // boxResponse
            // 
            this.boxResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.boxResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxResponse.Location = new System.Drawing.Point(27, 388);
            this.boxResponse.Multiline = false;
            this.boxResponse.Name = "boxResponse";
            this.boxResponse.ReadOnly = true;
            this.boxResponse.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.boxResponse.Size = new System.Drawing.Size(498, 25);
            this.boxResponse.TabIndex = 4;
            this.boxResponse.TabStop = false;
            this.boxResponse.Text = "";
            // 
            // boxInput
            // 
            this.boxInput.AllowDrop = true;
            this.boxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxInput.Location = new System.Drawing.Point(27, 101);
            this.boxInput.Multiline = true;
            this.boxInput.Name = "boxInput";
            this.boxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxInput.Size = new System.Drawing.Size(498, 281);
            this.boxInput.TabIndex = 2;
            this.boxInput.TextChanged += new System.EventHandler(this.boxInput_TextChanged);
            this.boxInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.boxInput_DragDrop);
            this.boxInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.boxInput_DragEnter);
            // 
            // btnHash
            // 
            this.btnHash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHash.Location = new System.Drawing.Point(206, 419);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(136, 50);
            this.btnHash.TabIndex = 3;
            this.btnHash.Text = "Hash text";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // comboHashes
            // 
            this.comboHashes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHashes.FormattingEnabled = true;
            this.comboHashes.Items.AddRange(new object[] {
            "SHA512",
            "SHA256",
            "SHA1",
            "MD5"});
            this.comboHashes.Location = new System.Drawing.Point(27, 30);
            this.comboHashes.Name = "comboHashes";
            this.comboHashes.Size = new System.Drawing.Size(189, 23);
            this.comboHashes.TabIndex = 1;
            // 
            // frmHashes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(552, 487);
            this.Controls.Add(this.comboHashes);
            this.Controls.Add(this.boxResponse);
            this.Controls.Add(this.boxInput);
            this.Controls.Add(this.btnHash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHashes";
            this.Text = "frmHashes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox boxResponse;
        private System.Windows.Forms.TextBox boxInput;
        private System.Windows.Forms.Button btnDelAsk;
        private System.Windows.Forms.ComboBox comboHashes;
        private System.Windows.Forms.Button btnHash;
    }
}