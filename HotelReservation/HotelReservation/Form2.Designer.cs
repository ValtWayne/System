namespace HotelReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TFUSER = new System.Windows.Forms.TextBox();
            this.TFPASS = new System.Windows.Forms.TextBox();
            this.BTNLOGIN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNEXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TFUSER
            // 
            this.TFUSER.Location = new System.Drawing.Point(77, 45);
            this.TFUSER.Name = "TFUSER";
            this.TFUSER.Size = new System.Drawing.Size(147, 20);
            this.TFUSER.TabIndex = 0;
            // 
            // TFPASS
            // 
            this.TFPASS.Location = new System.Drawing.Point(77, 92);
            this.TFPASS.Name = "TFPASS";
            this.TFPASS.Size = new System.Drawing.Size(147, 20);
            this.TFPASS.TabIndex = 1;
            // 
            // BTNLOGIN
            // 
            this.BTNLOGIN.Location = new System.Drawing.Point(77, 118);
            this.BTNLOGIN.Name = "BTNLOGIN";
            this.BTNLOGIN.Size = new System.Drawing.Size(75, 23);
            this.BTNLOGIN.TabIndex = 2;
            this.BTNLOGIN.Text = "LOGIN";
            this.BTNLOGIN.UseVisualStyleBackColor = true;
            this.BTNLOGIN.Click += new System.EventHandler(this.BTNLOGIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.Location = new System.Drawing.Point(158, 118);
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(66, 23);
            this.BTNEXIT.TabIndex = 5;
            this.BTNEXIT.Text = "EXIT";
            this.BTNEXIT.UseVisualStyleBackColor = true;
            this.BTNEXIT.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(302, 160);
            this.Controls.Add(this.BTNEXIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNLOGIN);
            this.Controls.Add(this.TFPASS);
            this.Controls.Add(this.TFUSER);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TFUSER;
        private System.Windows.Forms.TextBox TFPASS;
        private System.Windows.Forms.Button BTNLOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNEXIT;
    }
}