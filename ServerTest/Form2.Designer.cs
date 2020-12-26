
namespace ServerTest
{
    partial class Form2
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
            this.claimBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // claimBox
            // 
            this.claimBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.claimBox.Location = new System.Drawing.Point(12, 12);
            this.claimBox.Name = "claimBox";
            this.claimBox.ReadOnly = true;
            this.claimBox.Size = new System.Drawing.Size(443, 350);
            this.claimBox.TabIndex = 0;
            this.claimBox.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 392);
            this.Controls.Add(this.claimBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox claimBox;
    }
}