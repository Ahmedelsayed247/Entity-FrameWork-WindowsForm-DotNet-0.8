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

namespace FirstEntityFrameWork
{
    public partial class FormCommand : Form
    {
        public FormCommand()
        {
            InitializeComponent();
            sqlCN = new SqlConnection("Data Source=. ;Initial Catalog =NorthWind ;Integrated Security= true");
                
            sqlCommand = new SqlCommand();
            //sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlCN;

            sqlCommand.CommandText = "select COUNT(*) from Products";

        }
        SqlConnection sqlCN;
        SqlCommand sqlCommand;

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (sqlCN.State == ConnectionState.Closed)
            {
                sqlCN.Open();
            }
            if (int.TryParse(sqlCommand.ExecuteScalar()?.ToString(), out int result))
            {
                this.Text = result.ToString();
            }
            sqlCN.Close();
        }

        private void FormCommand_Load(object sender, EventArgs e)
        {
            SqlCommand sqlGetProductIds = new SqlCommand("Select ProductID from Products" ,sqlCN);
            sqlCN.Open();
            
            SqlDataReader sqlDataReader = sqlGetProductIds.ExecuteReader();
            // cmbProductIDs.DataSource = sqlDataReader;
            while (sqlDataReader.Read())
            {
                cmbProductIDs.Items.Add(sqlDataReader.GetInt32("ProductID"));
            }


            sqlCN.Close();
        }
    }
}
