namespace HotelReservation
{
    partial class Form3
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
            this.Executive = new System.Windows.Forms.RadioButton();
            this.Deluxe = new System.Windows.Forms.RadioButton();
            this.Classic = new System.Windows.Forms.RadioButton();
            this.s = new System.Windows.Forms.Label();
            this.Avail = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.usertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet = new HotelReservation.HRDataSet();
            this.user_tableTableAdapter = new HotelReservation.HRDataSetTableAdapters.user_tableTableAdapter();
            this.Search = new System.Windows.Forms.Button();
            this.hRDataSet1 = new HotelReservation.HRDataSet1();
            this.hRDataSet3 = new HotelReservation.HRDataSet3();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservetableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet7 = new HotelReservation.HRDataSet7();
            this.hRDataSet4 = new HotelReservation.HRDataSet4();
            this.hRDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserve_tableTableAdapter = new HotelReservation.HRDataSet4TableAdapters.reserve_tableTableAdapter();
            this.reservetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reserve_tableTableAdapter1 = new HotelReservation.HRDataSet7TableAdapters.reserve_tableTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckAvailablility = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Executive);
            this.groupBox1.Controls.Add(this.Deluxe);
            this.groupBox1.Controls.Add(this.Classic);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Executive
            // 
            this.Executive.AutoSize = true;
            this.Executive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Executive.Location = new System.Drawing.Point(457, 33);
            this.Executive.Name = "Executive";
            this.Executive.Size = new System.Drawing.Size(124, 29);
            this.Executive.TabIndex = 2;
            this.Executive.TabStop = true;
            this.Executive.Text = "Executive";
            this.Executive.UseVisualStyleBackColor = true;
            // 
            // Deluxe
            // 
            this.Deluxe.AutoSize = true;
            this.Deluxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deluxe.Location = new System.Drawing.Point(250, 33);
            this.Deluxe.Name = "Deluxe";
            this.Deluxe.Size = new System.Drawing.Size(97, 29);
            this.Deluxe.TabIndex = 1;
            this.Deluxe.TabStop = true;
            this.Deluxe.Text = "Deluxe";
            this.Deluxe.UseVisualStyleBackColor = true;
            // 
            // Classic
            // 
            this.Classic.AutoSize = true;
            this.Classic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classic.Location = new System.Drawing.Point(16, 33);
            this.Classic.Name = "Classic";
            this.Classic.Size = new System.Drawing.Size(100, 29);
            this.Classic.TabIndex = 0;
            this.Classic.TabStop = true;
            this.Classic.Text = "Classic";
            this.Classic.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.Black;
            this.s.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.s.Location = new System.Drawing.Point(139, 9);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(389, 73);
            this.s.TabIndex = 1;
            this.s.Text = "WELCOME!";
            this.s.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Avail
            // 
            this.Avail.Location = new System.Drawing.Point(124, 92);
            this.Avail.Name = "Avail";
            this.Avail.Size = new System.Drawing.Size(200, 20);
            this.Avail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check In Date";
            // 
            // usertableBindingSource
            // 
            this.usertableBindingSource.DataMember = "user_table";
            this.usertableBindingSource.DataSource = this.hRDataSet;
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_tableTableAdapter
            // 
            this.user_tableTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.RosyBrown;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(271, 396);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(92, 42);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // hRDataSet1
            // 
            this.hRDataSet1.DataSetName = "HRDataSet1";
            this.hRDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hRDataSet3
            // 
            this.hRDataSet3.DataSetName = "HRDataSet3";
            this.hRDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomClassDataGridViewTextBoxColumn,
            this.availableDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.CheckAvailablility});
            this.dataGridView1.DataSource = this.reservetableBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.Location = new System.Drawing.Point(99, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(503, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reservetableBindingSource2
            // 
            this.reservetableBindingSource2.DataMember = "reserve_table";
            this.reservetableBindingSource2.DataSource = this.hRDataSet7;
            // 
            // hRDataSet7
            // 
            this.hRDataSet7.DataSetName = "HRDataSet7";
            this.hRDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hRDataSet4
            // 
            this.hRDataSet4.DataSetName = "HRDataSet4";
            this.hRDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hRDataSet4BindingSource
            // 
            this.hRDataSet4BindingSource.DataSource = this.hRDataSet4;
            this.hRDataSet4BindingSource.Position = 0;
            // 
            // reservetableBindingSource
            // 
            this.reservetableBindingSource.DataMember = "reserve_table";
            this.reservetableBindingSource.DataSource = this.hRDataSet4BindingSource;
            // 
            // reserve_tableTableAdapter
            // 
            this.reserve_tableTableAdapter.ClearBeforeFill = true;
            // 
            // reservetableBindingSource1
            // 
            this.reservetableBindingSource1.DataMember = "reserve_table";
            this.reservetableBindingSource1.DataSource = this.hRDataSet7;
            // 
            // reserve_tableTableAdapter1
            // 
            this.reserve_tableTableAdapter1.ClearBeforeFill = true;
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
            // CheckAvailablility
            // 
            this.CheckAvailablility.DataPropertyName = "Room_ID";
            this.CheckAvailablility.HeaderText = "Availability";
            this.CheckAvailablility.Name = "CheckAvailablility";
            this.CheckAvailablility.ReadOnly = true;
            this.CheckAvailablility.Text = "Book";
            this.CheckAvailablility.UseColumnTextForButtonValue = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Avail);
            this.Controls.Add(this.s);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservetableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.RadioButton Executive;
        private System.Windows.Forms.RadioButton Deluxe;
        private System.Windows.Forms.RadioButton Classic;
        private System.Windows.Forms.DateTimePicker Avail;
        private System.Windows.Forms.Label label1;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource usertableBindingSource;
        private HRDataSetTableAdapters.user_tableTableAdapter user_tableTableAdapter;
        private System.Windows.Forms.Button Search;
        private HRDataSet1 hRDataSet1;
        private HRDataSet3 hRDataSet3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hRDataSet4BindingSource;
        private HRDataSet4 hRDataSet4;
        private System.Windows.Forms.BindingSource reservetableBindingSource;
        private HRDataSet4TableAdapters.reserve_tableTableAdapter reserve_tableTableAdapter;
        private HRDataSet7 hRDataSet7;
        private System.Windows.Forms.BindingSource reservetableBindingSource1;
        private HRDataSet7TableAdapters.reserve_tableTableAdapter reserve_tableTableAdapter1;
        private System.Windows.Forms.BindingSource reservetableBindingSource2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn CheckAvailablility;
    }
}