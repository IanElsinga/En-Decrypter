
namespace En_decrypter
{
    partial class FrmSecDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecDel));
            this.btnDelAsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelAsk
            // 
            this.btnDelAsk.Location = new System.Drawing.Point(215, 437);
            this.btnDelAsk.Name = "btnDelAsk";
            this.btnDelAsk.Size = new System.Drawing.Size(75, 23);
            this.btnDelAsk.TabIndex = 0;
            this.btnDelAsk.Text = "button1";
            this.btnDelAsk.UseVisualStyleBackColor = true;
            this.btnDelAsk.Click += new System.EventHandler(this.btnDelAsk_Click);
            // 
            // FrmSecDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(552, 487);
            this.Controls.Add(this.btnDelAsk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSecDel";
            this.Text = "FrmSecDel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelAsk;
    }
}