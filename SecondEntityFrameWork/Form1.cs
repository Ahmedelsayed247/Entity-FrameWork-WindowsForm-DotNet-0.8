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
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dt = new DataTable();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog= NorthWind; Integrated Security = true");

        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dt;
        BindingSource productsBindingSource;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            sqlDataAdapter.Fill(dt);
            productsBindingSource = new BindingSource(dt, "");
            dataGridView1.DataSource = productsBindingSource;
            dataGridView1.Columns["ProductId"].ReadOnly = true;
            DataGridViewComboBoxColumn DC = new DataGridViewComboBoxColumn();
            DC.HeaderText = "Supplier";
            dataGridView1.Columns.AddRange(DC);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            productsBindingSource.EndEdit(); 
            sqlDataAdapter.Update(dt);  
        }
    }
}
