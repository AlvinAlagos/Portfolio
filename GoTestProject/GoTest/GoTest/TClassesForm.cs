using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoTest
{
    public partial class TClassesForm : Form
    {
        public TClassesForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from StudentList where courseId='" + courseIdTextBox.Text + "'", con);
            try
            {
               
                DataTable table = new DataTable();
                adapter.Fill(table);
                studentsDataGridView.DataSource = table;
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    con.Close();
            //}
        
        }

        private void studentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void courseIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            User user = User.GetInstance();
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();
            SqlCommand insert = new SqlCommand("Insert into Course values('" + newCourseTextBox.Text + "'," + user.Id + ")", con);
            try
            {
              

                if (!String.IsNullOrEmpty(newCourseTextBox.Text))
                {
                    //con.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Course has been registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Input is empty. Must fill in!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Course id is already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            //finally
            //{
            //    con.Close();
            //}
        }

        private void TClassesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
