using BusinessLogicLayer.Entities;
using BusinessLogicLayer.EntitiyLists;
using DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace BusinessLogicLayer.EntityManager
{
    public class ProductManager
    {
        static DBManager dBManager = new DBManager();

        public static ProductList SelectAllProducts()
        {
            try
            {
                // Execute the query and get the DataTable
               return DataTableToProductList( dBManager.ExecuteDataTable("SelectAllProducts"));

         

            }
            catch (Exception ex)
            {
               
            }
            return new ProductList();
        }

        public static bool DeleteProduct(int proid)
        {
            try
            {
                // Use parameterized query to prevent SQL injection
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProductID", SqlDbType.Int) { Value = proid }
                };

                // Execute the stored procedure
                int rowsAffected = dBManager.ExecuteNonQuery("DeleteProduct", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteProduct: {ex.Message}");
                return false;
            }
        }
        #region Mapping Functions
        internal static ProductList DataTableToProductList(DataTable Dt)
        {
            ProductList products   = new ProductList();
            try
            {
                if (Dt?.Rows?.Count > 0)
                {
                    foreach (DataRow Dr in Dt.Rows)
                    {
                        products.Add(DataRowToProduct(Dr));
                        
                    }

                }
            }
            catch (Exception)
            {

                
            }
            return products;

        }
        internal static Product DataRowToProduct(DataRow dataRow)
        {
            Product prd = new Product();

            try
            {
                // Handle ProductID - Assuming it's a required field and should always be present
                if (int.TryParse(dataRow["ProductID"]?.ToString(), out int tempInt))
                {
                    prd.ProductID = tempInt;
                }
                else
                {
                    prd.ProductID = 0; 
                }

                // Handle ProductName - Assuming it is a required field
                prd.ProductName = dataRow["ProductName"]?.ToString() ?? string.Empty;

                // Handle SupplierID - Nullable field
                if (int.TryParse(dataRow["SupplierID"]?.ToString(), out tempInt))
                {
                    prd.SupplierID = tempInt;
                }
                else
                {
                    prd.SupplierID = null; // Default value for nullable int
                }

                if (int.TryParse(dataRow["CategoryID"]?.ToString(), out tempInt))
                {
                    prd.CategoryID = tempInt;
                }
                else
                {
                    prd.CategoryID = null; 
                }

                prd.Unit = dataRow["Unit"]?.ToString();

                if (decimal.TryParse(dataRow["Price"]?.ToString(), out decimal tempDecimal))
                {
                    prd.Price = tempDecimal;
                }
                else
                {
                    prd.Price = null; // Default value for nullable decimal
                }
            }
            catch (Exception ex)
            {
               
            }

            return prd;
        }


        #endregion


    }
}
