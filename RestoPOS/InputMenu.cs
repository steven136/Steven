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
    public partial class InputMenu : Form
    {


        public InputMenu()
        {
            InitializeComponent();
            this.dgvData.AutoGenerateColumns = false;
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
                        dgvData.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InputMenu_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = open.FileName;
                    imageLocation = open.FileName;
                    Gambar.ImageLocation = imageLocation;
                }
                string image = textBox1.Text;
                Bitmap bmp = new Bitmap(image);
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                byte[] bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IDMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblSubmit_Click(object sender, EventArgs e)
        {
            if (this.IDMenu.Text.Trim() == "")
            {
                MessageBox.Show("ID Menu tidak boleh kosong", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.IDMenu.Focus();
            }
            else if (this.NmMenu.Text.Trim() == "")
            {
                MessageBox.Show("Nama Menu tidak boleh kosong", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.NmMenu.Focus();
            }
            else if (this.Hrg.Text.Trim() == "")
            {
                MessageBox.Show("Harga tidak boleh kosong", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hrg.Focus();
            }
            else if (this.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Gambar tidak boleh kosong", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Gambar.Focus();
            }
            else
            {
                try
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText =
                            @"Insert Into Menu Values (
                            @IDMenu, @NmMenu, @Harga, @Gambar)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@IDMenu", this.IDMenu.Text.Trim());
                            cmd.Parameters.AddWithValue("@NmMenu", this.NmMenu.Text.Trim());
                            cmd.Parameters.AddWithValue("@Harga", this.Hrg.Text.Trim());
                            cmd.Parameters.AddWithValue("@Gambar", this.textBox1.Text.Trim());
                            int recAffeced = cmd.ExecuteNonQuery();
                            if (recAffeced > 0)
                            {
                                this.Batal_Click(null, null);
                                LoadData();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }


        private void Batal_Click(object sender, EventArgs e)
        {
            this.IDMenu.Clear();
            this.NmMenu.Clear();
            this.Hrg.Clear();
            this.textBox1.Clear();
            Gambar.Image = null;
        }

        private void Hrg_TextChanged(object sender, EventArgs e)
        {

        }

        private int rowIndex = 0;
        private bool edit = false;
        private void dgvData_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvData.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                this.dgvData.CurrentCell = this.dgvData.Rows[e.RowIndex].Cells[2];
                this.contextMenuStrip1.Show(this.dgvData, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                delete();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            LoadData();
        }
        private void delete()
        {
            int i = 0;
            using (var conn = new Connection().CreateAndOpenConnection())
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    SqlCommand storedProcedureCommand = conn.CreateCommand();
                    storedProcedureCommand.CommandType = CommandType.Text;
                    storedProcedureCommand.CommandText = "DELETE FROM Menu WHERE IDMenu = @IDMenu";

                    SqlParameter inparam2 = new SqlParameter("@IDMenu", SqlDbType.Int);
                    inparam2.Direction = ParameterDirection.Input;
                    inparam2.Value = Convert.ToInt32(dgvData.Rows[i].Cells[0].Value);
                    storedProcedureCommand.Parameters.Add(inparam2);
                    storedProcedureCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void Edit()
        {
            using (var conn = new Connection().CreateAndOpenConnection())
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE Menu set IDMenu=@IDMenu, NmMenu=@NmMenu, Harga=@Harga, Gambar=@Gambar WHERE IDMenu = @IDMenu";
                    cmd.Parameters.AddWithValue("@IDMenu", this.IDMenu.Text.Trim());
                    cmd.Parameters.AddWithValue("@NmMenu", this.NmMenu.Text.Trim());
                    cmd.Parameters.AddWithValue("@Harga", this.Hrg.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gambar", this.textBox1.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    conn.Close();
                    LoadData();
                }
            }
        }

        private void dgvData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDMenu.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
            NmMenu.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
            Hrg.Text = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Edit Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (this.IDMenu.Text.Trim() == "")
                {
                    MessageBox.Show("ID Menu tidak boleh kosong", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.IDMenu.Focus();
                }
                else if (this.NmMenu.Text.Trim() == "")
                {
                    MessageBox.Show("Nama Menu tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.NmMenu.Focus();
                }
                else if (this.Hrg.Text.Trim() == "")
                {
                    MessageBox.Show("Harga tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hrg.Focus();
                }
                else if (this.textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Gambar tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Gambar.Focus();
                }
                else
                {
                    Edit();
                } 
                }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            LoadData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}