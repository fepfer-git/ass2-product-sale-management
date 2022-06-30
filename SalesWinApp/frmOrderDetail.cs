using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess.Repository;
namespace SalesWinApp
{
    public partial class frmOrderDetail : Form
    {
        public IOrderDetailRepository OrderDetailRepository { get; set; }

        IProductRepository productRepository = new ProductRepository();
        public string OrderID { get; set; }
        public Boolean UserOrAdmin { get; set; }


        public frmOrderDetail()
        {
            InitializeComponent();
        }

        public List<OrderDetail> GetOrderDetails()
        {
            var listOrderDetail = OrderDetailRepository.GetOrderDetailByOrderID(OrderID);
            return listOrderDetail;
        }

        public void LoadListOrder()
        {
            try
            {
                var listOrderDetail = OrderDetailRepository.GetOrderDetailByOrderID(OrderID);

                BindingSource source;
                source = new BindingSource();
                source.DataSource = listOrderDetail;

                txtOrderID.DataBindings.Clear();
                txtProductID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtDiscount.DataBindings.Add("Text", source, "Discount");

                dgvListOrderDetail.DataSource = null;
                dgvListOrderDetail.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of order deatils");
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListOrder();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrderDetailUpdateAndCreate orderDetailAdjust = new frmOrderDetailUpdateAndCreate
            {
                Text = "Add a new order detail!",
                InsertOrUpdate = false,
                OrderID = OrderID,
                AdjustOrderDetailRepository = OrderDetailRepository
            };
            this.Hide();
            orderDetailAdjust.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do u really wanna delete this?", "Order Detail Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                if (txtOrderID.Text == "" && txtProductID.Text == "")
                {
                    MessageBox.Show("There are nothing to delete");
                }
                else
                {
                    OrderDetailRepository.DeleteOrderDetail(txtOrderID.Text, txtProductID.Text);
                    var deleteProduct = productRepository.GetProductByID(txtProductID.Text);
                    productRepository.UpdateProductQuantity(deleteProduct.UnitsInStock + int.Parse(txtQuantity.Text), txtProductID.Text);
                    LoadListOrder();
                    txtOrderID.Clear();
                    txtProductID.Clear();
                    txtUnitPrice.Clear();
                    txtQuantity.Clear();
                    txtDiscount.Clear();
                }
                
            }
        }

        public OrderDetail GetOrderDetailObject()
        {
            OrderDetail orderDetail = null;
            try
            {
                orderDetail = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProductID.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Discount = double.Parse(txtDiscount.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return orderDetail;
        }

        private void dgvListOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetailUpdateAndCreate orderDetailAdjust = new frmOrderDetailUpdateAndCreate
            {
                Text = "Update Order Detail",
                InsertOrUpdate = true,
                orderDetail = GetOrderDetailObject(),
                AdjustOrderDetailRepository = OrderDetailRepository
            };
            this.Hide();
            orderDetailAdjust.ShowDialog();
            this.Show();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            if (UserOrAdmin == false)
            {
                btnNew.Visible = false;
                btnDelete.Visible = false;
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                dgvListOrderDetail.Enabled = false;
            }
        }
    }
}
