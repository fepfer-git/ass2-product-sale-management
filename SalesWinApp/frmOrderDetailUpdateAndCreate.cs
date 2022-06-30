using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrderDetailUpdateAndCreate : Form
    {
        public IOrderDetailRepository AdjustOrderDetailRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public OrderDetail orderDetail { get; set; }
        IProductRepository productRepository = new ProductRepository();
        string proId = "";
        string currentProductID;
        int currentQuantity;
        public string OrderID { get; set; }
        Product productObject = new Product();
        public frmOrderDetailUpdateAndCreate()
        {
            InitializeComponent();
        }

        public void LoadProductIDList()
        {
            try
            {
                var productList = productRepository.GetProducts();
                cboProductID.DataSource = productList;
                cboProductID.ValueMember = "ProductId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int stockLeft = 0;
            try
            {
                if (txtDiscount.Text == "" || cboProductID.Text == "" || txtQuantity.Text == "" || txtUnitPrice.Text =="")
                {
                    MessageBox.Show("All fields are required!", "Order Detail Adjust",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (InsertOrUpdate == false )
                    {
                        productObject = productRepository.GetProductByID(cboProductID.SelectedValue.ToString());
                        stockLeft = productObject.UnitsInStock - int.Parse(txtQuantity.Text);

                        if (AdjustOrderDetailRepository.CheckDuplicatedOrderDetail(OrderID, cboProductID.SelectedValue.ToString()) != null)
                        {
                            MessageBox.Show("Product already on your order, please choose another product!");
                        }else if (stockLeft < 0)
                        {
                            MessageBox.Show("Product stock left is not enough, there is only " + productObject.UnitsInStock + " stock left!");
                        }
                        else
                        {
                            try
                            {
                                var ord = new OrderDetail
                                {
                                    OrderId = int.Parse(OrderID),
                                    ProductId = int.Parse(cboProductID.SelectedValue.ToString()),
                                    Quantity = int.Parse(txtQuantity.Text),
                                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                                    Discount = double.Parse(txtDiscount.Text)
                                };
                                productRepository.UpdateProductQuantity(stockLeft, cboProductID.SelectedValue.ToString());
                                AdjustOrderDetailRepository.SaveOrderDetail(ord);
                                MessageBox.Show("Add a new order detail successfully!");
                                txtDiscount.Clear();
                                txtQuantity.Clear();
                                txtUnitPrice.Clear();
                                cboProductID.SelectedIndex = -1;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }                           
                        }
                        
                    }
                    else
                    {
                        productObject = productRepository.GetProductByID(cboProductID.SelectedValue.ToString());
                        stockLeft = productObject.UnitsInStock - (int.Parse(txtQuantity.Text) - currentQuantity);

                        if (stockLeft < 0)
                        {
                            MessageBox.Show("Product stock left is not enough, there is only " + productObject.UnitsInStock + " stock left!");
                        }
                        else
                        {
                            var ord = new OrderDetail
                            {
                                OrderId = orderDetail.OrderId,
                                ProductId = int.Parse(cboProductID.SelectedValue.ToString()),
                                Quantity = int.Parse(txtQuantity.Text),
                                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                                Discount = double.Parse(txtDiscount.Text)

                            };
                            productRepository.UpdateProductQuantity(stockLeft, cboProductID.SelectedValue.ToString());
                            AdjustOrderDetailRepository.UpdateOrderDetail(ord);
                            currentProductID = cboProductID.SelectedValue.ToString();
                            currentQuantity = int.Parse(txtQuantity.Text);
                            MessageBox.Show("Update order details successfully!");
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Button");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrderDetailUpdateAndCreate_Load(object sender, EventArgs e)
        {
            LoadProductIDList();           
            cboProductID.SelectedIndex = -1;
            txtOrderID.Text = OrderID;
            if (InsertOrUpdate == true)
            {
                currentQuantity = orderDetail.Quantity;
                currentProductID = orderDetail.ProductId.ToString();
                txtDiscount.Text = orderDetail.Discount.ToString();
                txtQuantity.Text = orderDetail.Quantity.ToString();
                cboProductID.SelectedValue = orderDetail.ProductId;
                txtOrderID.Text = orderDetail.OrderId.ToString();
                txtUnitPrice.Text = orderDetail.UnitPrice.ToString();
                cboProductID.Enabled = false;
                lbStock.Visible = false;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cboProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InsertOrUpdate == false)
            {
                proId = cboProductID.Text;
                try
                {
                    if (Regex.IsMatch(proId, @"^\d+$"))
                    {
                        productObject = productRepository.GetProductByID(proId);
                        txtUnitPrice.Text = productObject.UnitPrice.ToString();
                        lbStock.Text = productObject.UnitsInStock.ToString();
                        lbStock.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "cboProID Change");
                }
            }
            else
            {
                lbSotckText.Visible = false;
            }
        }
    }
}
