using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestoPOS
{
    public partial class Table : Form
    {

        public Table()
        {
            InitializeComponent();
            this.dgvMenu.AutoGenerateColumns = false;
            LoadData();
            Total();
            DelAll();
        }


        private void Total()
        {
            for (int i = 0; i < dgvMenu.Rows.Count; i++)
            {

                int A = Convert.ToInt32(dgvMenu.Rows[i].Cells[2].Value);
                int B = Convert.ToInt32(dgvMenu.Rows[i].Cells[4].Value);
                int C = A * B;
                dgvMenu.Rows[i].Cells[5].Value = C;
            }
            int sum = 0;
            for (int c = 0; c < dgvMenu.Rows.Count; ++c)
            {
                sum += Convert.ToInt32(dgvMenu.Rows[c].Cells[5].Value);
            }

            lblTotal.Text = sum.ToString("N0");
        }
        private void LoadData()
        {
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Select IDMenu, NmMenu, Harga, Gambar From Menu";
                        SqlDataAdapter sd = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
                        foreach (DataRow drow in dt.Rows)
                        {
                            drow["Pic"] = File.ReadAllBytes(drow["Gambar"].ToString());
                        }
                        dgvMenu.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Table_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Total();
        }

        private void dgvMenu_MouseHover(object sender, EventArgs e)
        {

        }

        private void Batal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvMenu.Rows.Count; i++)
            {
                dgvMenu.Rows[i].Cells[4].Value = 0;
            }
        }
        private void Input()
        {
            try { 
                foreach (DataGridViewRow row in dgvMenu.Rows)
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.Parameters.Clear();
                            cmd.CommandText = @"Insert Into Tabel Values( @IDMenu, @NmMenu, @Harga, @Jumlah, @TtlHarga)";
                            cmd.Parameters.AddWithValue("@IDMenu", row.Cells["IDMenu"].Value);
                            cmd.Parameters.AddWithValue("@NmMenu", row.Cells["NmMenu"].Value);
                            cmd.Parameters.AddWithValue("@Harga", row.Cells["Harga"].Value);
                            cmd.Parameters.AddWithValue("@Jumlah", row.Cells["Jumlah"].Value);
                            cmd.Parameters.AddWithValue("@TtlHarga", row.Cells["TtlHarga"].Value);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
        }
            catch (Exception ex)
            {
                return;
        }
        }

        private void DelAll()
        {
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"DELETE From Tabel";
                        SqlDataAdapter sd = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dgvMenu.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }
        private void Pesan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Pesan", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Input();
                Checkout obj1 = new Checkout();
                obj1.Show();
                Table obj2 = new Table();
                obj2.Close();
                obj2.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void dgvMenu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Total();
        }

        private void Table_Load_1(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }


        private void dgvMenu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Total();
        }

    }
}




    
