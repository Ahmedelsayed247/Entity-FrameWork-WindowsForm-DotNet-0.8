using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FirstEntityFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCn;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection();
            // sqlCn.ConnectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=true";
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;

            this.Text = ConfigurationManager.AppSettings["BranchID"];
            sqlCn.StateChange += (sender, e) => 
            this.Text = $"State Was {e.OriginalState} and changed to {e.CurrentState} ";

            sqlCn.InfoMessage += (sender, e) =>
            MessageBox.Show(e.Message);

            this.FormClosed += (sender, e) =>  sqlCn?.Dispose();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (sqlCn.State == ConnectionState.Closed)
            {
                sqlCn.Open();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (sqlCn.State == ConnectionState.Open)
            {
                sqlCn.Close();

            }
        }

        private void btnChangeDB_Click(object sender, EventArgs e)
        {
            if (sqlCn.State == ConnectionState.Open)
            {
                sqlCn.ChangeDatabase("ITI");
            }
        }
    }
}
