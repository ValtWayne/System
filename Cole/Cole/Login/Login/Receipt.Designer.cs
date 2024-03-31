namespace Login
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.BTNDone = new System.Windows.Forms.Button();
            this.RTBReceipt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BTNDone
            // 
            this.BTNDone.Location = new System.Drawing.Point(216, 350);
            this.BTNDone.Name = "BTNDone";
            this.BTNDone.Size = new System.Drawing.Size(75, 23);
            this.BTNDone.TabIndex = 1;
            this.BTNDone.Text = "Done";
            this.BTNDone.UseVisualStyleBackColor = true;
            this.BTNDone.Click += new System.EventHandler(this.BTNDone_Click);
            // 
            // RTBReceipt
            // 
            this.RTBReceipt.Location = new System.Drawing.Point(122, 34);
            this.RTBReceipt.Name = "RTBReceipt";
            this.RTBReceipt.Size = new System.Drawing.Size(284, 297);
            this.RTBReceipt.TabIndex = 2;
            this.RTBReceipt.Text = "";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(525, 410);
            this.Controls.Add(this.RTBReceipt);
            this.Controls.Add(this.BTNDone);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTNDone;
        private System.Windows.Forms.RichTextBox RTBReceipt;
    }
}
