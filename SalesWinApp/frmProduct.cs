using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProduct : Form
    {
        /*IProductRepository repository = new ProductRepository()*/
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product Product { get; set; }




        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LoadCategoryList()
        {
            try
            {
                var cateList = ProductRepository.GetCategories();
                cboCategoryID.DataSource = cateList;
                cboCategoryID.ValueMember = "CategoryId";
                cboCategoryID.DisplayMember = "CategoryName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }

        private void frmProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are u sure to exit?", "Login Notification!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Boolean checkId = true;
            int proID;
            try
            {
                do
                {

                    proID = rnd.Next(10, 10000);
                    if (!ProductRepository.CheckProductIdDuplicated(proID))
                    {
                        checkId = false;
                    }


                } while (checkId);


                if (txtProductName.Text == "" || txtPrice.Text == "" || txtStock.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Product Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (InsertOrUpdate == false)
                    {
                        var p = new Product
                        {
                            ProductName = txtProductName.Text,
                            UnitPrice = decimal.Parse(txtPrice.Text),
                            UnitsInStock = short.Parse(txtStock.Text),
                            CategoryId = int.Parse(cboCategoryID.SelectedValue.ToString()),
                            ProductId = proID,
                            Weight = txtWeight.Text

                        };
                        ProductRepository.SaveProduct(p);
                        MessageBox.Show("Add new product successfully!");
                        txtPrice.Clear();
                        txtProductName.Clear();
                        txtStock.Clear();
                        txtWeight.Clear();
                        cboCategoryID.Text = null;

                    }
                    else
                    {
                        var p = new Product
                        {
                            ProductName = txtProductName.Text,
                            UnitPrice = decimal.Parse(txtPrice.Text),
                            UnitsInStock = short.Parse(txtStock.Text),
                            CategoryId = int.Parse(cboCategoryID.SelectedValue.ToString()),
                            ProductId = Product.ProductId,
                            Weight = txtWeight.Text

                        };
                        ProductRepository.UpdateProduct(p);
                        MessageBox.Show("Update product successfully!");

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new product!" : "Update a product!");

            }
            
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
            cboCategoryID.SelectedIndex = 0;
            if (InsertOrUpdate == true)
            {
                txtProductName.Text = Product.ProductName.ToString();
                txtPrice.Text = Product.UnitPrice.ToString();
                txtStock.Text = Product.UnitsInStock.ToString();
                txtWeight.Text = Product.Weight.ToString();
                cboCategoryID.SelectedValue = Product.CategoryId;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtWeight.Clear();
            cboCategoryID.Text = string.Empty;
        }
    }
}
