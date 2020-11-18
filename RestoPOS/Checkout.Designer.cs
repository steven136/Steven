namespace RestoPOS
{
    partial class Checkout
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
            this.KodeMeja = new System.Windows.Forms.Label();
            this.NamaResto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Struk = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTtl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TblBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IDMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TtlHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Struk)).BeginInit();
            this.SuspendLayout();
            // 
            // KodeMeja
            // 
            this.KodeMeja.AutoSize = true;
            this.KodeMeja.Font = new System.Drawing.Font("Myriad Pro Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeMeja.Location = new System.Drawing.Point(895, 69);
            this.KodeMeja.Name = "KodeMeja";
            this.KodeMeja.Size = new System.Drawing.Size(79, 30);
            this.KodeMeja.TabIndex = 4;
            this.KodeMeja.Text = "MEJA 01";
            // 
            // NamaResto
            // 
            this.NamaResto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NamaResto.AutoSize = true;
            this.NamaResto.BackColor = System.Drawing.Color.White;
            this.NamaResto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NamaResto.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaResto.ForeColor = System.Drawing.Color.Black;
            this.NamaResto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NamaResto.Location = new System.Drawing.Point(304, 9);
            this.NamaResto.Name = "NamaResto";
            this.NamaResto.Size = new System.Drawing.Size(385, 46);
            this.NamaResto.TabIndex = 3;
            this.NamaResto.Text = "Waroeng Masa Kini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "ORDERAN";
            // 
            // Struk
            // 
            this.Struk.AllowUserToAddRows = false;
            this.Struk.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.Struk.CausesValidation = false;
            this.Struk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Struk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMenu,
            this.Menu,
            this.Harga,
            this.Column3,
            this.TtlHarga});
            this.Struk.GridColor = System.Drawing.Color.PaleGreen;
            this.Struk.Location = new System.Drawing.Point(61, 102);
            this.Struk.Name = "Struk";
            this.Struk.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Format = "N0";
            this.Struk.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Struk.RowTemplate.Height = 24;
            this.Struk.Size = new System.Drawing.Size(913, 342);
            this.Struk.TabIndex = 6;
            this.Struk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "TOTAL HARGA";
            // 
            // lblTtl
            // 
            this.lblTtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtl.Location = new System.Drawing.Point(828, 450);
            this.lblTtl.Name = "lblTtl";
            this.lblTtl.Size = new System.Drawing.Size(146, 17);
            this.lblTtl.TabIndex = 9;
            this.lblTtl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pilih Metode Pembayaran";
            // 
            // TblBack
            // 
            this.TblBack.BackColor = System.Drawing.Color.LightGreen;
            this.TblBack.Location = new System.Drawing.Point(61, 450);
            this.TblBack.Name = "TblBack";
            this.TblBack.Size = new System.Drawing.Size(115, 34);
            this.TblBack.TabIndex = 16;
            this.TblBack.Text = "Ubah Orderan";
            this.TblBack.UseVisualStyleBackColor = false;
            this.TblBack.Click += new System.EventHandler(this.TblBack_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "OVO",
            "GOPAY",
            "LINK AJA",
            "DANA",
            "SHOPEEPAY",
            "CASH",
            "KREDIT",
            "DEBIT"});
            this.comboBox1.Location = new System.Drawing.Point(487, 490);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "BAYAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDMenu
            // 
            this.IDMenu.DataPropertyName = "IDMenu";
            this.IDMenu.HeaderText = "ID MENU";
            this.IDMenu.MinimumWidth = 6;
            this.IDMenu.Name = "IDMenu";
            this.IDMenu.Width = 125;
            // 
            // Menu
            // 
            this.Menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Menu.DataPropertyName = "NmMenu";
            this.Menu.HeaderText = "MENU";
            this.Menu.MinimumWidth = 6;
            this.Menu.Name = "Menu";
            // 
            // Harga
            // 
            this.Harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harga.DataPropertyName = "Harga";
            this.Harga.HeaderText = "HARGA";
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Jumlah";
            this.Column3.HeaderText = "JUMLAH";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // TtlHarga
            // 
            this.TtlHarga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TtlHarga.DataPropertyName = "TtlHarga";
            dataGridViewCellStyle1.Format = "N0";
            this.TtlHarga.DefaultCellStyle = dataGridViewCellStyle1;
            this.TtlHarga.HeaderText = "TOTAL";
            this.TtlHarga.MinimumWidth = 6;
            this.TtlHarga.Name = "TtlHarga";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1001, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TblBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTtl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Struk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KodeMeja);
            this.Controls.Add(this.NamaResto);
            this.Name = "Checkout";
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.Struk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KodeMeja;
        private System.Windows.Forms.Label NamaResto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Struk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTtl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TblBack;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TtlHarga;
    }
}