using BusinessObject.Models;
using DataAccess.Repository;
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

namespace SalesWinApp
{
    public partial class frmOrderCreate : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        IProductRepository productRepository = new ProductRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public IOrderDetailRepository AdjustOrderDetailRepository { get; set; }
        DateTime currentTime = DateTime.Now;
        Boolean OrderOrOrderDetail;
        Product productObject = new Product();
        int currentOrdID = 0;
        public frmOrderCreate()
        {
            InitializeComponent();
        }

        public void LoadMemberIDList()
        {
            try
            {
                var memberList = memberRepository.GetMembers();
                cboMemberID.DataSource = memberList;
                cboMemberID.ValueMember = "MemberId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of memberID");
            }
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
                MessageBox.Show(ex.Message, "Error on load list of productID");
            }
        }

        public void LoadOrderDetailList(int ordID)
        {
            try
            {               
                var orderDetailList = AdjustOrderDetailRepository.GetOrderDetailByOrderID(ordID.ToString());
                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = orderDetailList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of orders");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean checkId = true;
            int ordID;
            Random rnd = new Random();

            do
            {

                ordID = rnd.Next(10, 10000);
                if (orderRepository.GetOrderByOrderID(ordID.ToString()) == null)
                {
                    checkId = false;
                }


            } while (checkId);
            if (OrderOrOrderDetail == true)
            {


                if (cboMemberID.Text == "" || txtFreight.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Add new order",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var ord = new Order
                    {
                        OrderId = ordID,
                        OrderDate = currentTime,
                        RequiredDate = currentTime,
                        ShippedDate = currentTime,
                        MemberId = int.Parse(cboMemberID.Text),
                        Freight = int.Parse(txtFreight.Text)
                    };
                    orderRepository.SaveOrder(ord);
                    cboProductID.Enabled = true;
                    txtQuantity.Enabled = true;
                    txtDiscount.Enabled = true;
                    OrderOrOrderDetail = false;

                    LoadProductIDList();
                    cboProductID.SelectedIndex = -1;
                    cboMemberID.Enabled = false;
                    txtFreight.Enabled = false;

                    txtStockLeft.Text = "";
                    txtUnitPrice.Text = "";
                    currentOrdID = ordID;
                    lbOrdID.Text = "Order: #" + currentOrdID.ToString();
                    lbOrdID.Visible = true;
                }
            }
            else
            {
                int stockLeft = 0;
                productObject = productRepository.GetProductByID(cboProductID.SelectedValue.ToString());
                stockLeft = productObject.UnitsInStock - int.Parse(txtQuantity.Text);

                if (AdjustOrderDetailRepository.CheckDuplicatedOrderDetail(currentOrdID.ToString(), cboProductID.SelectedValue.ToString()) != null)
                {
                    MessageBox.Show("Product already on your order, please choose another product!");
                }
                else if (stockLeft < 0)
                {
                    MessageBox.Show("Product stock left is not enough, there is only " + productObject.UnitsInStock + " stock left!");
                }
                else
                {
                    var ord = new OrderDetail
                    {
                        OrderId = currentOrdID,
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
                    cboProductID.Text = null;
                    txtStockLeft.Clear();
                    LoadOrderDetailList(currentOrdID);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {         
            Close();
        }

        private void OrderUpdateAndCreate_Load(object sender, EventArgs e)
        {
            cboProductID.Enabled = false;
            txtQuantity.Enabled = false;
            txtDiscount.Enabled = false;
            OrderOrOrderDetail = true;
            LoadMemberIDList();
            cboMemberID.SelectedIndex = -1;

            txtRequiredDate.Text = currentTime.ToString();
            txtShippedDate.Text = currentTime.ToString();
            txtOrderDate.Text = currentTime.ToString();
            lbOrdID.Visible = false;
        }

        private void cboProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string proId = cboProductID.Text;
            try
            {
                if (Regex.IsMatch(proId, @"^\d+$"))
                {
                    productObject = productRepository.GetProductByID(proId);
                    txtUnitPrice.Text = productObject.UnitPrice.ToString();
                    txtStockLeft.Text = productObject.UnitsInStock.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "cboProID Change");
            }
        }

        private void frmOrderUpdateAndCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Are u sure to exit?", "Login Notification!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                var orderDetailList = AdjustOrderDetailRepository.GetOrderDetailByOrderID(currentOrdID.ToString());
                var order = orderRepository.GetOrderByOrderID(currentOrdID.ToString());
                if (orderDetailList.Count == 0 && order != null)
                {
                    var deleteOrder = orderRepository.GetOrderByOrderID(currentOrdID.ToString());
                    orderRepository.DeleteOrder(deleteOrder);
                }
            }
        }
    }
}

