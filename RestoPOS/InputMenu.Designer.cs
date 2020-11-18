namespace RestoPOS
{
    partial class InputMenu
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
            this.NamaResto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDMenu = new System.Windows.Forms.TextBox();
            this.NmMenu = new System.Windows.Forms.TextBox();
            this.Hrg = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Gambar = new System.Windows.Forms.PictureBox();
            this.tblSubmit = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Batal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gambar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.NamaResto.Location = new System.Drawing.Point(201, 9);
            this.NamaResto.Name = "NamaResto";
            this.NamaResto.Size = new System.Drawing.Size(385, 46);
            this.NamaResto.TabIndex = 4;
            this.NamaResto.Text = "Waroeng Masa Kini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENU SETUP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID MENU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "NAMA MENU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "HARGA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "GAMBAR";
            // 
            // IDMenu
            // 
            this.IDMenu.Location = new System.Drawing.Point(146, 193);
            this.IDMenu.Name = "IDMenu";
            this.IDMenu.Size = new System.Drawing.Size(267, 22);
            this.IDMenu.TabIndex = 10;
            // 
            // NmMenu
            // 
            this.NmMenu.Location = new System.Drawing.Point(146, 240);
            this.NmMenu.Name = "NmMenu";
            this.NmMenu.Size = new System.Drawing.Size(267, 22);
            this.NmMenu.TabIndex = 11;
            // 
            // Hrg
            // 
            this.Hrg.Location = new System.Drawing.Point(146, 287);
            this.Hrg.Name = "Hrg";
            this.Hrg.Size = new System.Drawing.Size(267, 22);
            this.Hrg.TabIndex = 12;
            this.Hrg.TextChanged += new System.EventHandler(this.Hrg_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(384, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gambar
            // 
            this.Gambar.BackColor = System.Drawing.Color.LightCyan;
            this.Gambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gambar.Location = new System.Drawing.Point(146, 359);
            this.Gambar.Name = "Gambar";
            this.Gambar.Size = new System.Drawing.Size(232, 122);
            this.Gambar.TabIndex = 14;
            this.Gambar.TabStop = false;
            // 
            // tblSubmit
            // 
            this.tblSubmit.BackColor = System.Drawing.Color.SpringGreen;
            this.tblSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblSubmit.Location = new System.Drawing.Point(146, 502);
            this.tblSubmit.Name = "tblSubmit";
            this.tblSubmit.Size = new System.Drawing.Size(232, 33);
            this.tblSubmit.TabIndex = 15;
            this.tblSubmit.Text = "Insert";
            this.tblSubmit.UseVisualStyleBackColor = false;
            this.tblSubmit.Click += new System.EventHandler(this.tblSubmit_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvData.GridColor = System.Drawing.Color.Maroon;
            this.dgvData.Location = new System.Drawing.Point(49, 70);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(699, 85);
            this.dgvData.TabIndex = 16;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseUp);
            this.dgvData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "IDMenu";
            this.Column1.HeaderText = "ID Menu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "NmMenu";
            this.Column2.HeaderText = "Nama Menu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Harga";
            this.Column3.HeaderText = "Harga";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Pic";
            this.Column4.HeaderText = "Gambar";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Batal
            // 
            this.Batal.BackColor = System.Drawing.Color.LavenderBlush;
            this.Batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batal.Location = new System.Drawing.Point(547, 502);
            this.Batal.Name = "Batal";
            this.Batal.Size = new System.Drawing.Size(82, 33);
            this.Batal.TabIndex = 17;
            this.Batal.Text = "Cancel";
            this.Batal.UseVisualStyleBackColor = false;
            this.Batal.Click += new System.EventHandler(this.Batal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 22);
            this.textBox1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(384, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(780, 551);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Batal);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tblSubmit);
            this.Controls.Add(this.Gambar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Hrg);
            this.Controls.Add(this.NmMenu);
            this.Controls.Add(this.IDMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamaResto);
            this.Name = "InputMenu";
            this.Text = "InputMenu";
            this.Load += new System.EventHandler(this.InputMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gambar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NamaResto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDMenu;
        private System.Windows.Forms.TextBox NmMenu;
        private System.Windows.Forms.TextBox Hrg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Gambar;
        private System.Windows.Forms.Button tblSubmit;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button Batal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}