using BusinessLogicLayer.EntitiyLists;
using BusinessLogicLayer.EntityManager;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLoad_Click(object sender, EventArgs e)
        {
            ProductList products = ProductManager.SelectAllProducts();
            this.dataGridView1.DataSource = products;


        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            ProductManager.DeleteProduct(2);
        }
    }
}
