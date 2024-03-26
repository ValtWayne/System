namespace Login
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GBSnacks = new System.Windows.Forms.GroupBox();
            this.PriceLabel3 = new System.Windows.Forms.Label();
            this.ProductNameLabel3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PriceLabel4 = new System.Windows.Forms.Label();
            this.ProductNameLabel4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PriceLabel2 = new System.Windows.Forms.Label();
            this.ProductNameLabel2 = new System.Windows.Forms.Label();
            this.Picture2 = new System.Windows.Forms.PictureBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNRemove = new System.Windows.Forms.Button();
            this.BTNBack = new System.Windows.Forms.Button();
            this.cartBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.registerDataSet3 = new Login.RegisterDataSet3();
            this.cartBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.cartTableAdapter = new Login.RegisterDataSet3TableAdapters.cartTableAdapter();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.TBQTY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNPrint = new System.Windows.Forms.Button();
            this.BTNClear = new System.Windows.Forms.Button();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.registerDataSet2 = new Login.RegisterDataSet3();
            this.cartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cartTableAdapter1 = new Login.RegisterDataSet3TableAdapters.cartTableAdapter();
            this.cartBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cartTableAdapter2 = new Login.RegisterDataSet3TableAdapters.cartTableAdapter();
            this.registerDataSet = new Login.RegisterDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.cartTableAdapter3 = new Login.RegisterDataSetTableAdapters.cartTableAdapter();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBSnacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SnackSavvy: Your Go-To Munchies Machine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // GBSnacks
            // 
            this.GBSnacks.Controls.Add(this.PriceLabel3);
            this.GBSnacks.Controls.Add(this.ProductNameLabel3);
            this.GBSnacks.Controls.Add(this.pictureBox3);
            this.GBSnacks.Controls.Add(this.PriceLabel4);
            this.GBSnacks.Controls.Add(this.ProductNameLabel4);
            this.GBSnacks.Controls.Add(this.pictureBox2);
            this.GBSnacks.Controls.Add(this.PriceLabel2);
            this.GBSnacks.Controls.Add(this.ProductNameLabel2);
            this.GBSnacks.Controls.Add(this.Picture2);
            this.GBSnacks.Controls.Add(this.PriceLabel);
            this.GBSnacks.Controls.Add(this.ProductNameLabel);
            this.GBSnacks.Controls.Add(this.ProductPictureBox);
            this.GBSnacks.Location = new System.Drawing.Point(81, 91);
            this.GBSnacks.Name = "GBSnacks";
            this.GBSnacks.Size = new System.Drawing.Size(465, 411);
            this.GBSnacks.TabIndex = 2;
            this.GBSnacks.TabStop = false;
            this.GBSnacks.Text = "Snacks";
            this.GBSnacks.Enter += new System.EventHandler(this.GBSnacks_Enter);
            // 
            // PriceLabel3
            // 
            this.PriceLabel3.AutoSize = true;
            this.PriceLabel3.Location = new System.Drawing.Point(89, 271);
            this.PriceLabel3.Name = "PriceLabel3";
            this.PriceLabel3.Size = new System.Drawing.Size(35, 13);
            this.PriceLabel3.TabIndex = 11;
            this.PriceLabel3.Text = "label3";
            this.PriceLabel3.Click += new System.EventHandler(this.PriceLabel3_Click);
            // 
            // ProductNameLabel3
            // 
            this.ProductNameLabel3.AutoSize = true;
            this.ProductNameLabel3.Location = new System.Drawing.Point(89, 247);
            this.ProductNameLabel3.Name = "ProductNameLabel3";
            this.ProductNameLabel3.Size = new System.Drawing.Size(35, 13);
            this.ProductNameLabel3.TabIndex = 10;
            this.ProductNameLabel3.Text = "label2";
            this.ProductNameLabel3.Click += new System.EventHandler(this.ProductNameLabel3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(59, 153);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 91);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PriceLabel4
            // 
            this.PriceLabel4.AutoSize = true;
            this.PriceLabel4.Location = new System.Drawing.Point(312, 271);
            this.PriceLabel4.Name = "PriceLabel4";
            this.PriceLabel4.Size = new System.Drawing.Size(35, 13);
            this.PriceLabel4.TabIndex = 8;
            this.PriceLabel4.Text = "label3";
            this.PriceLabel4.Click += new System.EventHandler(this.PriceLabel4_Click);
            // 
            // ProductNameLabel4
            // 
            this.ProductNameLabel4.AutoSize = true;
            this.ProductNameLabel4.Location = new System.Drawing.Point(312, 247);
            this.ProductNameLabel4.Name = "ProductNameLabel4";
            this.ProductNameLabel4.Size = new System.Drawing.Size(35, 13);
            this.ProductNameLabel4.TabIndex = 7;
            this.ProductNameLabel4.Text = "label2";
            this.ProductNameLabel4.Click += new System.EventHandler(this.ProductNameLabel4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(282, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 91);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PriceLabel2
            // 
            this.PriceLabel2.AutoSize = true;
            this.PriceLabel2.Location = new System.Drawing.Point(312, 137);
            this.PriceLabel2.Name = "PriceLabel2";
            this.PriceLabel2.Size = new System.Drawing.Size(35, 13);
            this.PriceLabel2.TabIndex = 5;
            this.PriceLabel2.Text = "label3";
            this.PriceLabel2.Click += new System.EventHandler(this.PriceLabel2_Click);
            // 
            // ProductNameLabel2
            // 
            this.ProductNameLabel2.AutoSize = true;
            this.ProductNameLabel2.Location = new System.Drawing.Point(312, 113);
            this.ProductNameLabel2.Name = "ProductNameLabel2";
            this.ProductNameLabel2.Size = new System.Drawing.Size(35, 13);
            this.ProductNameLabel2.TabIndex = 4;
            this.ProductNameLabel2.Text = "label2";
            this.ProductNameLabel2.Click += new System.EventHandler(this.ProductNameLabel2_Click);
            // 
            // Picture2
            // 
            this.Picture2.Location = new System.Drawing.Point(282, 19);
            this.Picture2.Name = "Picture2";
            this.Picture2.Size = new System.Drawing.Size(100, 91);
            this.Picture2.TabIndex = 3;
            this.Picture2.TabStop = false;
            this.Picture2.Click += new System.EventHandler(this.Picture2_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(89, 137);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 13);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "label3";
            this.PriceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(89, 113);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(35, 13);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "label2";
            this.ProductNameLabel.Click += new System.EventHandler(this.ProductNameLabel_Click);
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Location = new System.Drawing.Point(59, 19);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(100, 91);
            this.ProductPictureBox.TabIndex = 0;
            this.ProductPictureBox.TabStop = false;
            this.ProductPictureBox.Click += new System.EventHandler(this.ProductPictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cart:";
            // 
            // BTNRemove
            // 
            this.BTNRemove.Location = new System.Drawing.Point(745, 521);
            this.BTNRemove.Name = "BTNRemove";
            this.BTNRemove.Size = new System.Drawing.Size(75, 23);
            this.BTNRemove.TabIndex = 4;
            this.BTNRemove.Text = "Remove";
            this.BTNRemove.UseVisualStyleBackColor = true;
            this.BTNRemove.Click += new System.EventHandler(this.BTNRemove_Click);
            // 
            // BTNBack
            // 
            this.BTNBack.Location = new System.Drawing.Point(12, 521);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(75, 23);
            this.BTNBack.TabIndex = 5;
            this.BTNBack.Text = "Back";
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // cartBindingSource4
            // 
            this.cartBindingSource4.DataMember = "cart";
            this.cartBindingSource4.DataSource = this.registerDataSet3;
            // 
            // registerDataSet3
            // 
            this.registerDataSet3.DataSetName = "RegisterDataSet3";
            this.registerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource3
            // 
            this.cartBindingSource3.DataMember = "cart";
            this.cartBindingSource3.DataSource = this.registerDataSet3;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "cart";
            this.cartBindingSource.DataSource = this.registerDataSet3;
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(563, 521);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(75, 23);
            this.BTNUpdate.TabIndex = 7;
            this.BTNUpdate.Text = "Update";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(654, 521);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(75, 23);
            this.BTNAdd.TabIndex = 8;
            this.BTNAdd.Text = "Add";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // TBQTY
            // 
            this.TBQTY.Location = new System.Drawing.Point(602, 449);
            this.TBQTY.Name = "TBQTY";
            this.TBQTY.Size = new System.Drawing.Size(100, 20);
            this.TBQTY.TabIndex = 9;
            this.TBQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBQTY.TextChanged += new System.EventHandler(this.TBQTY_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "QTY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(831, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total:";
            // 
            // BTNPrint
            // 
            this.BTNPrint.Location = new System.Drawing.Point(919, 521);
            this.BTNPrint.Name = "BTNPrint";
            this.BTNPrint.Size = new System.Drawing.Size(75, 23);
            this.BTNPrint.TabIndex = 13;
            this.BTNPrint.Text = "Print";
            this.BTNPrint.UseVisualStyleBackColor = true;
            this.BTNPrint.Click += new System.EventHandler(this.BTNPrint_Click);
            // 
            // BTNClear
            // 
            this.BTNClear.Location = new System.Drawing.Point(835, 521);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.Size = new System.Drawing.Size(75, 23);
            this.BTNClear.TabIndex = 14;
            this.BTNClear.Text = "Clear";
            this.BTNClear.UseVisualStyleBackColor = true;
            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // TBTotal
            // 
            this.TBTotal.Location = new System.Drawing.Point(894, 449);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(100, 20);
            this.TBTotal.TabIndex = 15;
            this.TBTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTotal.TextChanged += new System.EventHandler(this.TBTotal_TextChanged);
            // 
            // registerDataSet2
            // 
            this.registerDataSet2.DataSetName = "RegisterDataSet2";
            this.registerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource1
            // 
            this.cartBindingSource1.DataMember = "cart";
            this.cartBindingSource1.DataSource = this.registerDataSet2;
            // 
            // cartTableAdapter1
            // 
            this.cartTableAdapter1.ClearBeforeFill = true;
            // 
            // cartBindingSource2
            // 
            this.cartBindingSource2.DataMember = "cart";
            this.cartBindingSource2.DataSource = this.registerDataSet2;
            // 
            // cartTableAdapter2
            // 
            this.cartTableAdapter2.ClearBeforeFill = true;
            // 
            // registerDataSet
            // 
            this.registerDataSet.DataSetName = "RegisterDataSet";
            this.registerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_name,
            this.price,
            this.qtyDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(552, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 352);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // registerDataSetBindingSource
            // 
            this.registerDataSetBindingSource.DataSource = this.registerDataSet;
            this.registerDataSetBindingSource.Position = 0;
            // 
            // cartBindingSource5
            // 
            this.cartBindingSource5.DataMember = "cart";
            this.cartBindingSource5.DataSource = this.registerDataSetBindingSource;
            // 
            // cartTableAdapter3
            // 
            this.cartTableAdapter3.ClearBeforeFill = true;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "product_name";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1001, 556);
            this.Controls.Add(this.TBTotal);
            this.Controls.Add(this.BTNClear);
            this.Controls.Add(this.BTNPrint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBQTY);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GBSnacks);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.GBSnacks.ResumeLayout(false);
            this.GBSnacks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GBSnacks;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.Label PriceLabel3;
        private System.Windows.Forms.Label ProductNameLabel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label PriceLabel4;
        private System.Windows.Forms.Label ProductNameLabel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PriceLabel2;
        private System.Windows.Forms.Label ProductNameLabel2;
        private System.Windows.Forms.PictureBox Picture2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNRemove;
        private System.Windows.Forms.Button BTNBack;
        private System.Windows.Forms.Button BTNUpdate;
        private RegisterDataSet3 registerDataSet3;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private RegisterDataSet3TableAdapters.cartTableAdapter cartTableAdapter;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.TextBox TBQTY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNPrint;
        private System.Windows.Forms.Button BTNClear;
        private System.Windows.Forms.TextBox TBTotal;
        private RegisterDataSet3 registerDataSet2;
        private System.Windows.Forms.BindingSource cartBindingSource1;
        private RegisterDataSet3TableAdapters.cartTableAdapter cartTableAdapter1;
        private System.Windows.Forms.BindingSource cartBindingSource2;
        private System.Windows.Forms.BindingSource cartBindingSource3;
        private RegisterDataSet3TableAdapters.cartTableAdapter cartTableAdapter2;
        private System.Windows.Forms.BindingSource cartBindingSource4;
        private RegisterDataSet registerDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource registerDataSetBindingSource;
        private System.Windows.Forms.BindingSource cartBindingSource5;
        private RegisterDataSetTableAdapters.cartTableAdapter cartTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}