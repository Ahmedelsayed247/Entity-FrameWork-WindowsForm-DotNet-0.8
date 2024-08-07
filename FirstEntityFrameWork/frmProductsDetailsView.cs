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
    public partial class frmProductsDetailsView : Form
    {
        public frmProductsDetailsView()
        {
            InitializeComponent();

        }
        SqlConnection sqlCN = new SqlConnection("Data Source=. ;Initial Catalog =NorthWind ;Integrated Security= true");
        SqlCommand sqlCommand;

        SqlDataAdapter sqlDataAdapter;
        DataTable dt = new DataTable();
        BindingSource bindingSource;

        private void frmProductsDetailsView_Load(object sender, EventArgs e)
        {
            sqlCommand = new SqlCommand("select * from Products", sqlCN);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt);

            /// To move through Data Source 
            bindingSource = new BindingSource(dt, "");

            lblProductID.DataBindings.Add("Text", bindingSource, "ProductID");
            txtProductName.DataBindings.Add("Text", bindingSource, "ProductName");
            numPrice.DataBindings.Add("Value", bindingSource, "Price");

            // simple data binding
            //lblProductID.DataBindings.Add("Text", dt, "ProductID");
            //txtProductName.DataBindings.Add("Text", dt, "ProductName");
            //numPrice.DataBindings.Add("Value",dt, "Price");


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bindingSource != null)
            {
                bindingSource.MoveNext();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (bindingSource != null)
            {
                bindingSource.MovePrevious();
            }
        }
        private void UpdateDatabase(DataRowView row)
        {
            try
            {
                // Open connection
                if (sqlCN.State != ConnectionState.Open)
                {
                    sqlCN.Open();
                }

                // Update command
                string updateQuery = "UPDATE Products SET ProductName = @ProductName, Price = @Price WHERE ProductID = @ProductID";
                sqlCommand = new SqlCommand(updateQuery, sqlCN);
                sqlCommand.Parameters.AddWithValue("@ProductName", row["ProductName"]);
                sqlCommand.Parameters.AddWithValue("@Price", row["Price"]);
                sqlCommand.Parameters.AddWithValue("@ProductID", row["ProductID"]);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message);
            }
            finally
            {
                // Close connection
                if (sqlCN.State == ConnectionState.Open)
                {
                    sqlCN.Close();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update the current row in DataTable dt
            if (bindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)bindingSource.Current;
                currentRow["ProductName"] = txtProductName.Text;
                currentRow["Price"] = numPrice.Value;

                // Update database
                UpdateDatabase(currentRow);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the current row from DataTable dt
            if (bindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)bindingSource.Current;
                int productId = (int)currentRow["ProductID"];

                // Delete from database
                DeleteFromDatabase(productId);

                // Remove from DataTable
                currentRow.Delete();
            }
        }
        private void DeleteFromDatabase(int productId)
        {
            try
            {
                // Open connection
                if (sqlCN.State != ConnectionState.Open)
                {
                    sqlCN.Open();
                }

                // Delete command
                string deleteQuery = "DELETE FROM Products WHERE ProductID = @ProductID";
                sqlCommand = new SqlCommand(deleteQuery, sqlCN);
                sqlCommand.Parameters.AddWithValue("@ProductID", productId);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting from database: " + ex.Message);
            }
            finally
            {
                // Close connection
                if (sqlCN.State == ConnectionState.Open)
                {
                    sqlCN.Close();
                }
            }
        }
    }
}
