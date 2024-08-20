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

namespace SecondEntityFrameWork
{
    public partial class frmDataGridView : Form
    {
        public frmDataGridView()
        {
            InitializeComponent();
            sqlCommand = new SqlCommand("Select * from Products", sqlConnection);
            cmdSuppliers = new SqlCommand("Select SupplierID as SID ,SupplierName from Suppliers", sqlConnection);

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapterSuppliers = new SqlDataAdapter(cmdSuppliers);
            dt = new DataTable();
            suppliersDt = new DataTable();  
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog= NorthWind; Integrated Security = true");

        SqlCommand sqlCommand,cmdSuppliers;

        SqlDataAdapter sqlDataAdapter,sqlDataAdapterSuppliers;
        DataTable dt,suppliersDt;
        BindingSource productsBindingSource;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            sqlDataAdapter.Fill(dt);
            productsBindingSource = new BindingSource(dt, "");
            dataGridView1.DataSource = productsBindingSource;
            dataGridView1.Columns["ProductId"].ReadOnly = true;
            dataGridView1.Columns["SupplierId"].Visible = false;




            DataGridViewComboBoxColumn DC = new DataGridViewComboBoxColumn();
            DC.HeaderText = "Supplier";
            dataGridView1.Columns.AddRange(DC);
            sqlDataAdapterSuppliers.Fill(suppliersDt);
            DC.DataSource = suppliersDt;
            DC.DisplayMember = "SupplierName";
            DC.ValueMember = "SID";
            // Source of selected value from the original data source 
            DC.DataPropertyName= "SupplierID" ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            productsBindingSource.EndEdit(); 
            sqlDataAdapter.Update(dt);  
        }
    }
}
