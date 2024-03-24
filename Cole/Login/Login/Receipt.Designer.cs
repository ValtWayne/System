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
            this.RTBReceipt = new System.Windows.Forms.RichTextBox();
            this.BTNDone = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label(); // Moved initialization here
            this.SuspendLayout();
            // 
            // RTBReceipt
            // 
            this.RTBReceipt.Location = new System.Drawing.Point(116, 46);
            this.RTBReceipt.Name = "RTBReceipt";
            this.RTBReceipt.Size = new System.Drawing.Size(517, 287);
            this.RTBReceipt.TabIndex = 0;
            this.RTBReceipt.Text = "";
            this.RTBReceipt.TextChanged += new System.EventHandler(this.RTBReceipt_TextChanged);
            // 
            // BTNDone
            // 
            this.BTNDone.Location = new System.Drawing.Point(332, 359);
            this.BTNDone.Name = "BTNDone";
            this.BTNDone.Size = new System.Drawing.Size(75, 23);
            this.BTNDone.TabIndex = 1;
            this.BTNDone.Text = "Done";
            this.BTNDone.UseVisualStyleBackColor = true;
            this.BTNDone.Click += new System.EventHandler(this.BTNDone_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(10, 10); // Adjust the position as needed
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "labelUsername";
            this.Controls.Add(this.labelUsername); // Add labelUsername to the form's controls
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNDone);
            this.Controls.Add(this.RTBReceipt);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBReceipt;
        private System.Windows.Forms.Button BTNDone;
        private System.Windows.Forms.Label labelUsername; // Added labelUsername declaration here
    }
}
