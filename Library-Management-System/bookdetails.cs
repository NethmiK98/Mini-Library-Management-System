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
    public partial class bookdetails : Form
    {
        public bookdetails()
        {
            InitializeComponent();
        }
        SqlConnection cq = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\bookdetails.mdf;Integrated Security=True;Connect Timeout=30");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bookdetails_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cd = new SqlCommand("insert into bookTB values(" + txtbook.Text + ",'" + txtname.Text + "'," + txtprice.Text + "," + txtquan.Text + ")", cq);
            cq.Open();
            cd.ExecuteNonQuery();
            cq.Close();
            MessageBox.Show("Data saved successfully");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string update = "UPDATE bookTB SET book_name ='" + txtname.Text + "', price = " + txtprice.Text + ", quanity = " + txtquan.Text + " WHERE book_id = " + txtbook.Text + " ";
            SqlCommand cm = new SqlCommand(update, cq);
            try 
            {
                cq.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                cq.Close();
            }
            catch (SqlException er)
            {
                MessageBox.Show("Error" + er);

            }
            finally
            {
                cq.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            String del = "DELETE FROM bookTB where book_id = " + txtbook.Text + " ";
            SqlCommand cmd = new SqlCommand(del, cq);
            try
            {
                cq.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Deleted Successfully");
                cq.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex);

            }
            finally
            {
                cq.Close();
            }
        }

        private void txtbook_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
