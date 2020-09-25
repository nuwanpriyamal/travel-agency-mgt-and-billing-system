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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\master.mdf;Integrated Security=True");
        String fid, tid;
        int  tax, total, advance, balance;
        public Form4()
        {
            InitializeComponent();
        }
        void Loaddata()
        {
            fid = txtFid.Text;
            tid = txtTid.Text;
           
            tax = int.Parse(txtTax.Text);
            total = int.Parse(label2.Text);
            advance = int.Parse(txtAdvance.Text);
            balance = int.Parse(label3.Text);
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void diplayGridView()
        {

            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Finance", con);
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
        private void btncheck_Click(object sender, EventArgs e)
        {
            int w = int.Parse(txtAdvance.Text);
            int v = int.Parse(label2.Text);
            int s = v - w;
            label3.Text = s.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            diplayGridView();
        }

        private void txtFid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM Finance WHERE Fid ='" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    txtFid.Text = sdr[0].ToString();
                    txtTid.Text = sdr[5].ToString();
                    txtTax.Text = sdr[1].ToString();
                    label2.Text = sdr[2].ToString();
                    txtAdvance.Text = sdr[3].ToString();
                    label3.Text = sdr[4].ToString();
                   


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtTransport.Text);
            int b = int.Parse(txtFood.Text);
            int c = int.Parse(txtTickets.Text);
            int d = int.Parse(txtAccomadation.Text);
            int g = int.Parse(txtGFee.Text);
            int f = int.Parse(txtOther.Text);
            int t = int.Parse(txtTax.Text);
            int x = a + b + c + g + d + t + f;
            label2.Text = x.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                Loaddata();
                string query = "INSERT INTO Finance VALUES('" + fid + "','" + tax + "','" + total+ "','" + advance + "','" + balance + "','" + tid + "')";
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
                string query = "UPDATE Finance SET Tax='" + tax + "',Total='" + total + "',Advance='" + advance + "',Balance='" + balance + "',Tid= '" + tid + "' WHERE Fid = '" + fid + "'";
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
                string query = "DELETE FROM Finance WHERE Fid ='" + fid + "'";
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
            txtFid.Clear();
            txtTid.Clear();
            txtTransport.Clear();
            txtFood.Clear();
            txtTickets.Clear();
            txtAccomadation.Clear();
            txtGFee.Clear();
            txtOther.Clear();
            txtTax.Clear();
            label2.ResetText();
            txtAdvance.Clear();
            label3.ResetText();
            txtSearch.Clear();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
