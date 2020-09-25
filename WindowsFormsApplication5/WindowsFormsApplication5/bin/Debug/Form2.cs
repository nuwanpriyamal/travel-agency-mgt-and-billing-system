using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\master.mdf;Integrated Security=True");
        String bid, name, address, tel, rname, gname, billdate, gtel;
        public Form2()
        {
            InitializeComponent();
        }
        void Loaddata()
        {
            bid = txtBid.Text;
            name = txtName.Text;
            address = txtAddress.Text;
            tel = txtTel.Text;
            rname = txtRname.Text;
            gname = txtGName.Text;
            gtel = txtGtel.Text;
            
            billdate = dtpToday.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGtel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            diplayGridView();
        }
        private void diplayGridView()
        {

            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM client", con);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                Loaddata();
                string query = "INSERT INTO client VALUES('" + bid + "','" + name + "','" + address + "','" + tel + "','" + rname + "','" + gname + "','" + gtel + "','" + billdate + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted successfully");
                diplayGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string query = "UPDATE client SET Name='" + name + "',Address='" + address + "',Contact='" + tel + "',Reception='" + rname + "',Guide = '" + gname + "',Guide_Contact ='" + gtel + "',Bill_date = '" + billdate +  "' WHERE Billid = '" + bid + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated  Successfully");
                diplayGridView();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Loaddata();
                string query = "DELETE FROM client WHERE Billid ='" + bid + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully");
                diplayGridView();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            txtBid.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtTel.Clear();
            txtRname.Clear();
            txtGName.Clear();
            txtGtel.Clear();
            dtpToday.ResetText();
            txtSearch.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM client WHERE Billid ='" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {

                    txtBid.Text = sdr[0].ToString();
                    txtName.Text = sdr[1].ToString();
                    txtAddress.Text = sdr[2].ToString();
                    txtTel.Text = sdr[3].ToString();
                    txtRname.Text = sdr[4].ToString();
                    txtGName.Text = sdr[5].ToString();
                    txtGtel.Text = sdr[6].ToString();
                    dtpToday.Text = sdr[7].ToString();
                 

                }
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
