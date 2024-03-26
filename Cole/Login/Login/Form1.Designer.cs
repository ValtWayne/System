namespace Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.CBShowPass = new System.Windows.Forms.CheckBox();
            this.BTNAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(72, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(72, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LoginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBTN.Location = new System.Drawing.Point(158, 167);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(88, 28);
            this.LoginBTN.TabIndex = 2;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(147, 84);
            this.TBUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(166, 22);
            this.TBUsername.TabIndex = 3;
            this.TBUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(147, 114);
            this.TBPass.Margin = new System.Windows.Forms.Padding(4);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(166, 22);
            this.TBPass.TabIndex = 4;
            this.TBPass.UseSystemPasswordChar = true;
            this.TBPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegisterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBTN.Location = new System.Drawing.Point(158, 203);
            this.RegisterBTN.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(88, 28);
            this.RegisterBTN.TabIndex = 5;
            this.RegisterBTN.Text = "Register";
            this.RegisterBTN.UseVisualStyleBackColor = false;
            this.RegisterBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // CBShowPass
            // 
            this.CBShowPass.AutoSize = true;
            this.CBShowPass.BackColor = System.Drawing.Color.Transparent;
            this.CBShowPass.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBShowPass.Location = new System.Drawing.Point(203, 140);
            this.CBShowPass.Name = "CBShowPass";
            this.CBShowPass.Size = new System.Drawing.Size(110, 20);
            this.CBShowPass.TabIndex = 6;
            this.CBShowPass.Text = "Show Password";
            this.CBShowPass.UseVisualStyleBackColor = false;
            this.CBShowPass.CheckedChanged += new System.EventHandler(this.CBShowPass_CheckedChanged);
            // 
            // BTNAdmin
            // 
            this.BTNAdmin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BTNAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNAdmin.Location = new System.Drawing.Point(332, 13);
            this.BTNAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAdmin.Name = "BTNAdmin";
            this.BTNAdmin.Size = new System.Drawing.Size(54, 25);
            this.BTNAdmin.TabIndex = 7;
            this.BTNAdmin.Text = "Admin";
            this.BTNAdmin.UseVisualStyleBackColor = false;
            this.BTNAdmin.Click += new System.EventHandler(this.BTNAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 263);
            this.Controls.Add(this.BTNAdmin);
            this.Controls.Add(this.CBShowPass);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Button RegisterBTN;
        private System.Windows.Forms.CheckBox CBShowPass;
        private System.Windows.Forms.Button BTNAdmin;
    }
}

