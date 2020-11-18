using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestoPOS
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
            this.Struk.AutoGenerateColumns = false;
            Total();
            LoadData();
            Total();
        }

        private void Total()
        {
            for (int i = 0; i < Struk.Rows.Count; i++)
            {

                int A = Convert.ToInt32(Struk.Rows[i].Cells[2].Value);
                int B = Convert.ToInt32(Struk.Rows[i].Cells[3].Value);
                int C = A * B;
                Struk.Rows[i].Cells[4].Value = C;
            }
            int sum = 0;
            for (int c = 0; c < Struk.Rows.Count; ++c)
            {
                sum += Convert.ToInt32(Struk.Rows[c].Cells[4].Value);
            }

            lblTtl.Text = sum.ToString("N0");
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
                        cmd.CommandText = @"Select IDMenu, NmMenu, Harga, Jumlah, TtlHarga From Tabel";
                        SqlDataAdapter sd = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        Struk.DataSource = dt;
                        Total();
                    }
                }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TblBack_Click(object sender, EventArgs e)
        {
            Table obj1 = new Table();
            obj1.Show();
            Checkout obj2 = new Checkout();
            obj2.Hide();
            obj2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Silahkan Pilih Metode Pembayaran", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.Focus();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("TOTAL Rp" + lblTtl.Text + Environment.NewLine + "VIA " + comboBox1.Text, "BAYAR", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Table obj1 = new Table();
                    obj1.Show();
                    Checkout obj2 = new Checkout();
                    obj2.Hide();
                    obj2.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
