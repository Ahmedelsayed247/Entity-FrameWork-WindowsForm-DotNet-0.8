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

namespace FirstEntityFrameWork
{
    public partial class ClosedConnection : Form
    {
        public ClosedConnection()
        {
            InitializeComponent();


        }
        SqlConnection sqlCN = new SqlConnection("Data Source=. ;Initial Catalog =NorthWind ;Integrated Security= true");
        SqlCommand sqlCommand;

        SqlDataAdapter sqlDataAdapter;
        DataTable dt;
        private void ClosedConnection_Load(object sender, EventArgs e)
        {


            dt = new DataTable();

        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            sqlCommand = new SqlCommand("Select * from Products where Price > @Price", sqlCN);
            sqlCommand.Parameters.AddWithValue("@Price", 30);

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dt);
            ///open sql connection , Execute sql command ,fetch data into data table 
            ///
            this.Text = dt.Rows.Count.ToString();

            /// complex data binding
            //lstProducts.DataSource = dt;
            //lstProducts.DisplayMember = "ProductName";
            //lstProducts.ValueMember = "ProductID";
            grdViewProducts.DataSource = dt;
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = $"{lstProducts.SelectedValue}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ///SQl command builder 
            
            sqlDataAdapter.Update(dt);  
            // execute insertcommand , update command ,delete command


        }
    }
}
