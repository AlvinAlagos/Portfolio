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
    public partial class SRegisterCourseForm : Form
    {
        DataSet set = new DataSet();
        public SRegisterCourseForm()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection connect = Connection.GetInstance();
                SqlConnection con = connect.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select  * from Course", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                courseDataGridView.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                User user = User.GetInstance();
                Connection connect = Connection.GetInstance();
                SqlConnection con = connect.GetConnection();
                SqlCommand insert = new SqlCommand("insert into StudentList values('" + user.FirstName + "','" + user.LastName + "'," + user.Id + ",'" + courseTextBox.Text + "')", con);
                SqlCommand check = new SqlCommand("select StudentId from StudentList where StudentId=" + user.Id + " AND CourseId='"+courseTextBox.Text+"'", con);
                
                SqlDataAdapter adapter = new SqlDataAdapter(check);
                adapter.Fill(set);
                 i = set.Tables[0].Rows.Count;
                if (i == 0)
                {
                    insert.ExecuteNonQuery();
                    MessageBox.Show("You have been successfully added to the course.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else if(i > 0)
                {
                    throw new Exception();
                }

            }
            catch(SqlException ex)
            {
                MessageBox.Show("There is no course registered under that id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            catch(Exception exc){
                MessageBox.Show("You are already registered in that course!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void yourCoursesButton_Click(object sender, EventArgs e)
        {
             try
            {
                User user = User.GetInstance();
                Connection connect = Connection.GetInstance();
                SqlConnection con = connect.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select  CourseId from StudentList where StudentId="+user.Id+"", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                courseDataGridView.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
