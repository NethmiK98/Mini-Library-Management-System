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

namespace Library_Management_System
{
    public partial class studentdetails : Form
    {
        public studentdetails()       {
            InitializeComponent();
        }
        SqlConnection scq = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\bookdetails.mdf;Integrated Security=True;Connect Timeout=30");
        private void studentdetails_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string update = "UPDATE studentTB SET stucontact =" + txtcontact.Text + ", stuemail = '" + txtemail.Text + "', stuid = " + txtid.Text + " WHERE stuname = '" + txtname.Text + "' ";
            SqlCommand cm = new SqlCommand(update, scq);
            try
            {
                scq.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                scq.Close();
            }
            catch (SqlException er)
            {
                MessageBox.Show("Error" + er);

            }
            finally
            {
                scq.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cw = new SqlCommand("insert into studentTB values('" + txtname.Text + "','" + txtemail.Text + "'," + txtid.Text + "," + txtcontact.Text + ",'" + txtbatch.Text + "')", scq);
            scq.Open();
            cw.ExecuteNonQuery();
            scq.Close();
            MessageBox.Show("Data saved successfully");
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {

            String del = "DELETE FROM studentTB where stuname = '" + txtname.Text + "'";
            SqlCommand cmd = new SqlCommand(del, scq);
            try
            {
                scq.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex);

            }
            finally
            {
                scq.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homepage newForm = new Homepage();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentdetails newForm = new studentdetails();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookdetails newForm = new bookdetails();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Issue newForm = new Issue();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Return newForm = new Return();
            newForm.Show();
            this.Hide();
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
     
