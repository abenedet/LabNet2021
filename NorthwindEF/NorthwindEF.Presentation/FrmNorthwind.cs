using NorthwindEF.Entities;
using NorthwindEF.Logic;
using System;
using System.Windows.Forms;

namespace NorthwindEF.Presentation
{
    public partial class FrmNorthwind : Form
    {
        private ShippersLogic shippersLogic = new ShippersLogic();
        private SuppliersLogic suppliersLogic = new SuppliersLogic();

        private CustomersLogic customersLogic = new CustomersLogic();
        private ProductsLogic productsLogic = new ProductsLogic();
        private CategoriesLogic categoriesLogic = new CategoriesLogic(); 
        private enum Region { WA };        

        public FrmNorthwind()
        {
            InitializeComponent();
        }

        private void FrmNorthwind_Load(object sender, EventArgs e)
        {

        }

        private void btnEj1_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = customersLogic.GetFirstOrNullCustomer();
                if (customer != null)
                {
                    MessageBox.Show(string.Format("ID: {0} - Company Name: {1} - Contact Name: {2} - Contact Title: {3} - Address: {4} - " +
                                                  "City: {5} - Region: {6} - Postal Code: {7} - Country: {8} - Phone: {9} - Fax: {10}",
                                                    customer.CustomerID, customer.CompanyName, customer.ContactName, customer.ContactTitle, customer.Address,
                                                    customer.City, customer.Region, customer.PostalCode, customer.Country, customer.Phone, customer.Fax));
                }
                else 
                {
                    MessageBox.Show("No existen Customers");     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Customer {0}", ex.Message));
            }
        }

        private void btnEj2_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultados.DataSource = productsLogic.GetAllProductsWithoutStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Productos {0}", ex.Message));
            }

        }

        private void btnEj3_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultados.DataSource = productsLogic.GetProductsWithStockAndPriceMoreThan(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Productos {0}", ex.Message));
            }
        }

        private void btnEj4_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultados.DataSource = customersLogic.GetCustomersByRegion(Region.WA.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Customers {0}", ex.Message));
            }
        }

        private void btnEj5_Click(object sender, EventArgs e)
        {
            try
            {
                var product = productsLogic.GetProductByID(789);

                if (product != null)
                {
                    dgvResultados.DataSource = productsLogic.GetProductByID(789);
                }
                else 
                {
                    MessageBox.Show("No existen productos con el ID: 789");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Producto {0}", ex.Message));
            }
        }

        private void btnEj6_Click(object sender, EventArgs e)
        {
            try
            {
                var names = string.Empty;

                if (rbtnMinusculas.Checked)
                {
                    var customersList = customersLogic.GetCustomersNames(true);
                    foreach (var customer in customersList) 
                    {
                        names += string.Format(customer);
                    }

                    MessageBox.Show(names);
                }
                else if (rbtnMayusculas.Checked)
                {
                    var customersList = customersLogic.GetCustomersNames(false);
                    foreach (var customer in customersList)
                    {
                        names += string.Format(customer);
                    }

                    MessageBox.Show(names);
                }
                else 
                {
                    MessageBox.Show(string.Format("Seleccione una opción por favor"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Customers {0}", ex.Message));
            }
        }

        private void btnEj7_Click(object sender, EventArgs e)
        {
            try
            {                
                dgvResultados.DataSource = customersLogic.GetCustomerByRegionAndOrderGreaterThan(Region.WA.ToString(), Convert.ToDateTime("01/01/1997"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Customers {0}", ex.Message));
            }
        }

        private void btnEj8_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultados.DataSource = customersLogic.GetCustomersByRegionAndFirstNumbers(Region.WA.ToString(), 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Customers {0}", ex.Message));
            }
        }

        private void btnEj9_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultados.DataSource = productsLogic.GetProductsOrderByName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Productos {0}", ex.Message));
            }
        }

        private void btnEj10_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultados.DataSource = productsLogic.GetProductsOrderByUnitStockDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Productos {0}", ex.Message));
            }
        }

        private void btnEj11_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultados.DataSource = categoriesLogic.GetDistinctCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener CAtegorias {0}", ex.Message));
            }
        }

        private void btnEj12_Click(object sender, EventArgs e)
        {
            try
            {
                var product = productsLogic.GetFirstProduct();
                MessageBox.Show(string.Format("ID: {0} - Product Name: {1} - Quantity Per Unit: {2} - Unit Price: {3}- " +
                                                "Unit In Stock: {4} - Units On Order: {5} - Reorder Level: {6} - Discontinued: {7}",
                                                product.ProductID, product.ProductName, product.QuantityPerUnit, product.UnitPrice, 
                                                product.UnitsInStock, product.UnitsOnOrder, product.ReorderLevel, product.Discontinued));

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al intentar obtener Productos {0}", ex.Message));
            }
        }
    }
}
