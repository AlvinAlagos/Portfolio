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
    public partial class SResultsForm : Form
    {
        public SResultsForm()
        {
            InitializeComponent();
        }

        private void SResultsForm_Load(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            try
            {
                Quiz quiz = Quiz.GetInstance();
                User user = User.GetInstance();
                Connection connect = Connection.GetInstance();
                SqlConnection con = connect.GetConnection();


          
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Results where StudentId="+user.Id+"", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                resultDataGridView.DataSource = table;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
