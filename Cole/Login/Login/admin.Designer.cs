namespace Login
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.CBShowPass = new System.Windows.Forms.CheckBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBShowPass
            // 
            this.CBShowPass.AutoSize = true;
            this.CBShowPass.BackColor = System.Drawing.Color.Transparent;
            this.CBShowPass.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBShowPass.Location = new System.Drawing.Point(188, 107);
            this.CBShowPass.Name = "CBShowPass";
            this.CBShowPass.Size = new System.Drawing.Size(110, 20);
            this.CBShowPass.TabIndex = 12;
            this.CBShowPass.Text = "Show Password";
            this.CBShowPass.UseVisualStyleBackColor = false;
            this.CBShowPass.CheckedChanged += new System.EventHandler(this.CBShowPass_CheckedChanged);
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(132, 81);
            this.TBPass.Margin = new System.Windows.Forms.Padding(4);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(166, 20);
            this.TBPass.TabIndex = 11;
            this.TBPass.UseSystemPasswordChar = true;
            this.TBPass.TextChanged += new System.EventHandler(this.TBPass_TextChanged);
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(132, 51);
            this.TBUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(166, 20);
            this.TBUsername.TabIndex = 10;
            this.TBUsername.TextChanged += new System.EventHandler(this.TBUsername_TextChanged);
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LoginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBTN.Location = new System.Drawing.Point(143, 134);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(88, 28);
            this.LoginBTN.TabIndex = 9;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(57, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // BTNBack
            // 
            this.BTNBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBack.Location = new System.Drawing.Point(3, 3);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(35, 23);
            this.BTNBack.TabIndex = 20;
            this.BTNBack.Text = "<-";
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 213);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.CBShowPass);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBShowPass;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNBack;
    }
}