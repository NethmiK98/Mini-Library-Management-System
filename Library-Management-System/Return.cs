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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\System.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand sq = new SqlCommand("insert into ReturnTB values(" + txtbook.Text + "," + txtstu.Text + ",'" + txtissue.Text + "','" + txtreturn.Text + "')", con);
            con.Open();
            sq.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data saved successfully");
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String update = "UPDATE ReturnTB SET studentid = " + txtstu.Text + ", issuedate ='" + txtissue.Text + "', returndate ='" + txtreturn.Text + "' WHERE bookid = " + txtbook.Text + "";
            SqlCommand cmd = new SqlCommand(update, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex);

            }
            finally
            {
                con.Close();
            }

        }

        private void btndelete1_Click(object sender, EventArgs e)
        {
            String del = "DELETE FROM ReturnTB where bookid = " + txtbook.Text + " ";
            SqlCommand cmd = new SqlCommand(del, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Deleted Successfully");
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex);

            }
            finally
            {
                con.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homepage newForm = new Homepage();
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
    }
}
