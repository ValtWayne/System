namespace Login
{
    partial class Manage
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
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Avail = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Executive = new System.Windows.Forms.RadioButton();
            this.Deluxe = new System.Windows.Forms.RadioButton();
            this.Classic = new System.Windows.Forms.RadioButton();
            this.l = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Room_ID = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(30, 616);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(116, 35);
            this.Back.TabIndex = 14;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(440, 553);
            this.dataGridView1.TabIndex = 13;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(682, 566);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 35);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Avail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Executive);
            this.groupBox1.Controls.Add(this.Deluxe);
            this.groupBox1.Controls.Add(this.Classic);
            this.groupBox1.Controls.Add(this.l);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Room_ID);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 594);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // Avail
            // 
            this.Avail.Location = new System.Drawing.Point(67, 256);
            this.Avail.Name = "Avail";
            this.Avail.Size = new System.Drawing.Size(180, 20);
            this.Avail.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Room Type";
            // 
            // Executive
            // 
            this.Executive.AutoSize = true;
            this.Executive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Executive.Location = new System.Drawing.Point(215, 101);
            this.Executive.Name = "Executive";
            this.Executive.Size = new System.Drawing.Size(98, 22);
            this.Executive.TabIndex = 12;
            this.Executive.TabStop = true;
            this.Executive.Text = "Executive";
            this.Executive.UseVisualStyleBackColor = true;
            // 
            // Deluxe
            // 
            this.Deluxe.AutoSize = true;
            this.Deluxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deluxe.Location = new System.Drawing.Point(119, 101);
            this.Deluxe.Name = "Deluxe";
            this.Deluxe.Size = new System.Drawing.Size(77, 22);
            this.Deluxe.TabIndex = 11;
            this.Deluxe.TabStop = true;
            this.Deluxe.Text = "Deluxe";
            this.Deluxe.UseVisualStyleBackColor = true;
            // 
            // Classic
            // 
            this.Classic.AutoSize = true;
            this.Classic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classic.Location = new System.Drawing.Point(16, 101);
            this.Classic.Name = "Classic";
            this.Classic.Size = new System.Drawing.Size(82, 22);
            this.Classic.TabIndex = 10;
            this.Classic.TabStop = true;
            this.Classic.Text = "Classic";
            this.Classic.UseVisualStyleBackColor = true;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(135, 294);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(47, 18);
            this.l.TabIndex = 9;
            this.l.Text = "Price";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(67, 315);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(180, 29);
            this.Price.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Available Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room_ID";
            // 
            // Room_ID
            // 
            this.Room_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_ID.Location = new System.Drawing.Point(67, 178);
            this.Room_ID.Name = "Room_ID";
            this.Room_ID.Size = new System.Drawing.Size(180, 29);
            this.Room_ID.TabIndex = 0;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(365, 566);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(116, 35);
            this.Insert.TabIndex = 10;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(520, 566);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(116, 35);
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 659);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Update);
            this.Name = "Manage";
            this.Text = "Manage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Avail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Executive;
        private System.Windows.Forms.RadioButton Deluxe;
        private System.Windows.Forms.RadioButton Classic;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Room_ID;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
    }
}