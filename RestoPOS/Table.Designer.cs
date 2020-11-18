namespace RestoPOS
{
    partial class Table
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.NamaResto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pesan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Batal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.IDMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gambar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TtlHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMenu,
            this.NmMenu,
            this.Harga,
            this.Gambar,
            this.Jumlah,
            this.TtlHarga});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenu.GridColor = System.Drawing.Color.Lime;
            this.dgvMenu.Location = new System.Drawing.Point(24, 76);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(854, 394);
            this.dgvMenu.TabIndex = 0;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvMenu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellEnter);
            this.dgvMenu.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellValueChanged);
            this.dgvMenu.MouseHover += new System.EventHandler(this.dgvMenu_MouseHover);
            // 
            // NamaResto
            // 
            this.NamaResto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NamaResto.AutoSize = true;
            this.NamaResto.BackColor = System.Drawing.Color.White;
            this.NamaResto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NamaResto.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaResto.ForeColor = System.Drawing.Color.Black;
            this.NamaResto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NamaResto.Location = new System.Drawing.Point(232, 9);
            this.NamaResto.Name = "NamaResto";
            this.NamaResto.Size = new System.Drawing.Size(385, 46);
            this.NamaResto.TabIndex = 5;
            this.NamaResto.Text = "Waroeng Masa Kini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "MEJA 01";
            // 
            // Pesan
            // 
            this.Pesan.BackColor = System.Drawing.Color.GreenYellow;
            this.Pesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesan.ForeColor = System.Drawing.Color.Navy;
            this.Pesan.Location = new System.Drawing.Point(322, 491);
            this.Pesan.Name = "Pesan";
            this.Pesan.Size = new System.Drawing.Size(139, 42);
            this.Pesan.TabIndex = 7;
            this.Pesan.Text = "PESAN ";
            this.Pesan.UseVisualStyleBackColor = false;
            this.Pesan.Click += new System.EventHandler(this.Pesan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "TOTAL Rp ";
            // 
            // Batal
            // 
            this.Batal.BackColor = System.Drawing.Color.Honeydew;
            this.Batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batal.ForeColor = System.Drawing.Color.Red;
            this.Batal.Location = new System.Drawing.Point(500, 501);
            this.Batal.Name = "Batal";
            this.Batal.Size = new System.Drawing.Size(79, 30);
            this.Batal.TabIndex = 9;
            this.Batal.Text = "BATAL";
            this.Batal.UseVisualStyleBackColor = false;
            this.Batal.Click += new System.EventHandler(this.Batal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(754, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 17);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // IDMenu
            // 
            this.IDMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDMenu.DataPropertyName = "IDMenu";
            this.IDMenu.FillWeight = 22.66922F;
            this.IDMenu.HeaderText = "ID Menu";
            this.IDMenu.MinimumWidth = 6;
            this.IDMenu.Name = "IDMenu";
            // 
            // NmMenu
            // 
            this.NmMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NmMenu.DataPropertyName = "NmMenu";
            this.NmMenu.FillWeight = 22.66922F;
            this.NmMenu.HeaderText = "Menu";
            this.NmMenu.MinimumWidth = 6;
            this.NmMenu.Name = "NmMenu";
            // 
            // Harga
            // 
            this.Harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harga.DataPropertyName = "Harga";
            this.Harga.FillWeight = 22.66922F;
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            // 
            // Gambar
            // 
            this.Gambar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gambar.DataPropertyName = "Pic";
            this.Gambar.FillWeight = 22F;
            this.Gambar.HeaderText = "Gambar";
            this.Gambar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Gambar.MinimumWidth = 6;
            this.Gambar.Name = "Gambar";
            // 
            // Jumlah
            // 
            this.Jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jumlah.DataPropertyName = "Jumlah";
            dataGridViewCellStyle1.NullValue = "0";
            this.Jumlah.DefaultCellStyle = dataGridViewCellStyle1;
            this.Jumlah.FillWeight = 22.66922F;
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.MinimumWidth = 6;
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Jumlah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TtlHarga
            // 
            this.TtlHarga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TtlHarga.DataPropertyName = "TtlHarga";
            this.TtlHarga.FillWeight = 22.66922F;
            this.TtlHarga.HeaderText = "Total";
            this.TtlHarga.MinimumWidth = 6;
            this.TtlHarga.Name = "TtlHarga";
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(899, 558);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Batal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pesan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamaResto);
            this.Controls.Add(this.dgvMenu);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label NamaResto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pesan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Batal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewImageColumn Gambar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn TtlHarga;
    }
}