namespace HotelReservation
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
            this.components = new System.ComponentModel.Container();
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
            this.Delete = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.hRDataSet4 = new HotelReservation.HRDataSet4();
            this.reservetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserve_tableTableAdapter = new HotelReservation.HRDataSet4TableAdapters.reserve_tableTableAdapter();
            this.usertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet5 = new HotelReservation.HRDataSet5();
            this.reservetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reserve_tableTableAdapter1 = new HotelReservation.HRDataSet5TableAdapters.reserve_tableTableAdapter();
            this.user_tableTableAdapter = new HotelReservation.HRDataSet4TableAdapters.user_tableTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reservetableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservetableBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet7 = new HotelReservation.HRDataSet7();
            this.reservetableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.reservetableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.reserve_tableTableAdapter2 = new HotelReservation.HRDataSet7TableAdapters.reserve_tableTableAdapter();
            this.reservetableBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.Refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Refresh);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 594);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel Information";
            // 
            // Avail
            // 
            this.Avail.Location = new System.Drawing.Point(67, 256);
            this.Avail.Name = "Avail";
            this.Avail.Size = new System.Drawing.Size(180, 20);
            this.Avail.TabIndex = 15;
            this.Avail.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.Avail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Avail_KeyDown);
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
            this.Executive.CheckedChanged += new System.EventHandler(this.Executive_CheckedChanged);
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
            this.Deluxe.CheckedChanged += new System.EventHandler(this.Deluxe_CheckedChanged);
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
            this.Classic.CheckedChanged += new System.EventHandler(this.Classic_CheckedChanged);
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
            this.l.Click += new System.EventHandler(this.label5_Click);
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(67, 315);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(180, 29);
            this.Price.TabIndex = 8;
            this.Price.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.Room_ID.TextChanged += new System.EventHandler(this.Room_ID_TextChanged);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(355, 580);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(116, 35);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(510, 580);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(116, 35);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(672, 580);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 35);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // hRDataSet4
            // 
            this.hRDataSet4.DataSetName = "HRDataSet4";
            this.hRDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservetableBindingSource
            // 
            this.reservetableBindingSource.DataMember = "reserve_table";
            this.reservetableBindingSource.DataSource = this.hRDataSet4;
            // 
            // reserve_tableTableAdapter
            // 
            this.reserve_tableTableAdapter.ClearBeforeFill = true;
            // 
            // usertableBindingSource
            // 
            this.usertableBindingSource.DataMember = "user_table";
            this.usertableBindingSource.DataSource = this.hRDataSet4;
            // 
            // hRDataSet5
            // 
            this.hRDataSet5.DataSetName = "HRDataSet5";
            this.hRDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservetableBindingSource1
            // 
            this.reservetableBindingSource1.DataMember = "reserve_table";
            this.reservetableBindingSource1.DataSource = this.hRDataSet5;
            // 
            // reserve_tableTableAdapter1
            // 
            this.reserve_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // user_tableTableAdapter
            // 
            this.user_tableTableAdapter.ClearBeforeFill = true;
            // 
            // reservetableBindingSource2
            // 
            this.reservetableBindingSource2.DataMember = "reserve_table";
            this.reservetableBindingSource2.DataSource = this.hRDataSet5BindingSource;
            // 
            // hRDataSet5BindingSource
            // 
            this.hRDataSet5BindingSource.DataSource = this.hRDataSet5;
            this.hRDataSet5BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomClassDataGridViewTextBoxColumn,
            this.availableDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservetableBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(366, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 553);
            this.dataGridView1.TabIndex = 3;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomClassDataGridViewTextBoxColumn
            // 
            this.roomClassDataGridViewTextBoxColumn.DataPropertyName = "Room_Class";
            this.roomClassDataGridViewTextBoxColumn.HeaderText = "Room_Class";
            this.roomClassDataGridViewTextBoxColumn.Name = "roomClassDataGridViewTextBoxColumn";
            // 
            // availableDateDataGridViewTextBoxColumn
            // 
            this.availableDateDataGridViewTextBoxColumn.DataPropertyName = "Available_Date";
            this.availableDateDataGridViewTextBoxColumn.HeaderText = "Available_Date";
            this.availableDateDataGridViewTextBoxColumn.Name = "availableDateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // reservetableBindingSource6
            // 
            this.reservetableBindingSource6.DataMember = "reserve_table";
            this.reservetableBindingSource6.DataSource = this.hRDataSet7;
            // 
            // hRDataSet7
            // 
            this.hRDataSet7.DataSetName = "HRDataSet7";
            this.hRDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservetableBindingSource3
            // 
            this.reservetableBindingSource3.DataMember = "reserve_table";
            this.reservetableBindingSource3.DataSource = this.hRDataSet5BindingSource;
            // 
            // reservetableBindingSource4
            // 
            this.reservetableBindingSource4.DataMember = "reserve_table";
            this.reservetableBindingSource4.DataSource = this.hRDataSet7;
            // 
            // reserve_tableTableAdapter2
            // 
            this.reserve_tableTableAdapter2.ClearBeforeFill = true;
            // 
            // reservetableBindingSource5
            // 
            this.reservetableBindingSource5.DataMember = "reserve_table";
            this.reservetableBindingSource5.DataSource = this.hRDataSet7;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(100, 518);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(116, 35);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Update);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Room_ID;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Classic;
        private System.Windows.Forms.RadioButton Deluxe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Executive;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DateTimePicker Avail;
        private HRDataSet4 hRDataSet4;
        private System.Windows.Forms.BindingSource reservetableBindingSource;
        private HRDataSet4TableAdapters.reserve_tableTableAdapter reserve_tableTableAdapter;
        private HRDataSet5 hRDataSet5;
        private System.Windows.Forms.BindingSource reservetableBindingSource1;
        private HRDataSet5TableAdapters.reserve_tableTableAdapter reserve_tableTableAdapter1;
        private System.Windows.Forms.BindingSource usertableBindingSource;
        private HRDataSet4TableAdapters.user_tableTableAdapter user_tableTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource reservetableBindingSource2;
        private System.Windows.Forms.BindingSource hRDataSet5BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource reservetableBindingSource3;
        private HRDataSet7 hRDataSet7;
        private System.Windows.Forms.BindingSource reservetableBindingSource4;
        private HRDataSet7TableAdapters.reserve_tableTableAdapter reserve_tableTableAdapter2;
        private System.Windows.Forms.BindingSource reservetableBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservetableBindingSource6;
        private System.Windows.Forms.Button Refresh;
    }
}