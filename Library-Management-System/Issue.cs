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
    public partial class Issue : Form
    {
        public Issue()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\System.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand sq = new SqlCommand("insert into IssueTB values(" + txtbookid.Text + "," + txtstuid.Text + ",'" + txtissda.Text + "','" + txtretda.Text + "')", sc);
            sc.Open();
            sq.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Data saved successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String update = "UPDATE IssueTB SET studentid = " + txtstuid.Text + ", issuedate ='" + txtissda.Text + "', returndate ='" + txtretda.Text + "' WHERE bookid = " + txtbookid.Text + "";
            SqlCommand cmd = new SqlCommand(update, sc);
            try
            {
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                sc.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error" + ex);

            }
            finally
            {
                sc.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String del = "DELETE FROM IssueTB where bookid = " + txtbookid.Text + " ";
            SqlCommand cmd = new SqlCommand(del, sc);
            try
            {
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Deleted Successfully");
                sc.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex);

            }
            finally
            {
                sc.Close();
            }
        }

        private void Issue_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homepage newForm = new Homepage();
            newForm.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}
