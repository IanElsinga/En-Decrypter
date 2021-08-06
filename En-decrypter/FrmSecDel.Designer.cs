
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
            this.boxResponse = new System.Windows.Forms.RichTextBox();
            this.boxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelAsk
            // 
            this.btnDelAsk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAsk.Location = new System.Drawing.Point(202, 425);
            this.btnDelAsk.Name = "btnDelAsk";
            this.btnDelAsk.Size = new System.Drawing.Size(136, 50);
            this.btnDelAsk.TabIndex = 2;
            this.btnDelAsk.Text = "delete files and folders";
            this.btnDelAsk.UseVisualStyleBackColor = true;
            this.btnDelAsk.Click += new System.EventHandler(this.btnDelAsk_Click);
            // 
            // boxResponse
            // 
            this.boxResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.boxResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxResponse.Location = new System.Drawing.Point(23, 311);
            this.boxResponse.Name = "boxResponse";
            this.boxResponse.ReadOnly = true;
            this.boxResponse.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.boxResponse.Size = new System.Drawing.Size(498, 108);
            this.boxResponse.TabIndex = 4;
            this.boxResponse.TabStop = false;
            this.boxResponse.Text = "";
            // 
            // boxInput
            // 
            this.boxInput.AllowDrop = true;
            this.boxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxInput.Location = new System.Drawing.Point(23, 24);
            this.boxInput.Multiline = true;
            this.boxInput.Name = "boxInput";
            this.boxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxInput.Size = new System.Drawing.Size(498, 281);
            this.boxInput.TabIndex = 1;
            this.boxInput.TextChanged += new System.EventHandler(this.boxInput_TextChanged);
            this.boxInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.boxInput_DragDrop);
            this.boxInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.boxInput_DragEnter);
            // 
            // FrmSecDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(552, 487);
            this.Controls.Add(this.boxResponse);
            this.Controls.Add(this.boxInput);
            this.Controls.Add(this.btnDelAsk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSecDel";
            this.Text = "FrmSecDel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelAsk;
        private System.Windows.Forms.RichTextBox boxResponse;
        private System.Windows.Forms.TextBox boxInput;
    }
}