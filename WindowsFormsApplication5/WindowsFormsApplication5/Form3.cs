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
    public partial class Form3 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\master.mdf;Integrated Security=True");
        String tid, ttype, location, reservationdate, vtype, service,bid;
        int nop, nod;
        public Form3()
        {
            InitializeComponent();
        }
        void Loaddata()
        {
            bid = txtBid.Text;
            tid = txtTid.Text;
            if (rdblocal.Checked == true)
            {
                ttype = "Local";
            }
            else if (rdbforeign.Checked == true)
            {
                ttype = "Foreign";
            };
            location = txtLocation.Text;
            reservationdate = dtpReserved.Text;
            if (rdbcar.Checked == true)
            {
                vtype = "car";
            }
            else if (rdbvan.Checked == true)
            {
                vtype = "van";
            }
            else if (rdbbus.Checked == true)
            {
                vtype = "bus";
            }
            else if (rdbother.Checked == true)
            {
                vtype = "other";
            };
            nop = int.Parse(txtNumberop.Text);
            nod = int.Parse(txtNumberod.Text);
            if (rdbnall.Checked == true)
            {
                service = "all";
            }
            else if (rdbnwa.Checked == true)
            {
                service = "without accomadation";
            }
            else if (rdbnwt.Checked == true)
            {
                service = "without transport";
            }
            else if (rdbnwf.Checked == true)
            {
                service = "without food";
            }
            else if (rdbnother.Checked == true)
            {
                service = "other";
            };
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void diplayGridView()
        {

            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Trip", con);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void rdbnother_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            diplayGridView();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtBid.Clear();
            txtTid.Clear();
            rdblocal.Checked = false;
            rdbforeign.Checked = false;
            txtLocation.Clear();
            dtpReserved.ResetText();
            txtNumberop.Clear();
            txtNumberod.Clear();
            rdbcar.Checked = false;
            rdbvan.Checked = false;
            rdbbus.Checked = false;
            rdbother.Checked = false;
            rdbnall.Checked = false;
            rdbnwa.Checked = false;
            rdbnwt.Checked = false;
            rdbnwf.Checked = false;
            rdbnother.Checked = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtBid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                Loaddata();
                string query = "INSERT INTO Trip VALUES('" + tid + "','" + ttype + "','" + location + "','" + reservationdate + "','" + nop + "','" + nod + "','" +vtype + "','" + service + "','"+bid+"')";
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
                string query = "UPDATE Trip SET Trip_Type='" + ttype  + "',Location='" + location + "',Reserved_Date='" + reservationdate + "',Num_of_passenger='" + nop + "',Num_of_Days= '" + nod + "',Vehicle ='" + vtype + "',Services = '" + service + "',Billid='"+bid+"' WHERE Tid = '" +tid + "'";
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
                string query = "DELETE FROM Trip WHERE TId ='" + tid + "'";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM Trip WHERE Tid ='" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {

                    txtTid.Text = sdr[0].ToString();
                    if (sdr[1].ToString() == "Local")
                    {

                        rdblocal.Checked = true;
                    }
                    else
                    {
                        rdbforeign.Checked = true;
                    }
                    txtLocation.Text = sdr[2].ToString();
                    dtpReserved.Text = sdr[3].ToString();
                    txtNumberop.Text = sdr[4].ToString();
                    txtNumberod.Text = sdr[5].ToString();
                    if (sdr[6].ToString() == "car")
                    {

                        rdbcar.Checked = true;
                    }
                    else if (sdr[6].ToString() == "van")
                    {
                        rdbvan.Checked = true;
                    }
                    else if (sdr[6].ToString() == "bus")
                    {
                        rdbbus.Checked = true;
                    }
                    else
                    {
                        rdbother.Checked = true;
                    }
                    if (sdr[7].ToString() == "all")
                    {

                        rdbnall.Checked = true;
                    }
                    else if (sdr[7].ToString() == "without accomadation")
                    {
                        rdbnwa.Checked = true;
                    }
                    else if (sdr[7].ToString() == "without transport")
                    {
                        rdbnwt.Checked = true;
                    }
                    else if (sdr[7].ToString() == "without food")
                    {
                        rdbnwf.Checked = true;
                    }
                    else
                    {
                        rdbnother.Checked = true;
                    }
                    txtBid.Text = sdr[8].ToString();
                   


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
    }
}
