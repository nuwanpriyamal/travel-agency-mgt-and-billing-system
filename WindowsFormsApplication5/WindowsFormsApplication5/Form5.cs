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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\master.mdf;Integrated Security=True");
       
        public Form5()
        {
            InitializeComponent();
        }
        private void diplayGridView1()
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
        private void diplayGridView2()
        {

            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Trip", con);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0].DefaultView;
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
        private void diplayGridView3()
        {

            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Finance", con);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0].DefaultView;
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            diplayGridView1();
            diplayGridView2();
            diplayGridView3();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
