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
    public partial class frmMain : Form
    {

        IProductRepository productRepository = new ProductRepository();
        IMemberRepository memberRepository = new MemberRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();


        public Product productInfo { get; set; }
        public Member memberInfo { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }
        string searchType = "";


        //Product ---------------------------------------------------------------------------------------------------

        public void ClearSearchSection()
        {
            txtSearchBox.Clear();
            cboSearchFilter.Text = null;
        }

        public void LoadProductList()
        {
            try
            {
                var productList = productRepository.GetProducts();
                BindingSource source;
                source = new BindingSource();
                source.DataSource = productList;

                txtProductID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvListProducts.DataSource = null;
                dgvListProducts.DataSource = source;

                ClearSearchSection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }
        }

        public void LoadListSearch(string keyword, string type)
        {
            try
            {

                var productList = productRepository.SearchProduct(keyword, type);
                BindingSource source;
                source = new BindingSource();
                source.DataSource = productList;

                txtProductID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvListProducts.DataSource = null;
                dgvListProducts.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list search");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are u sure to exit?", "Login Notification!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct
            {
                Text = "Add a new product!",
                InsertOrUpdate = false,
                ProductRepository = productRepository
            };
            this.Hide();
            product.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("There are nothing to delete!");
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Do u really wanna delete this?", "Product management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var p = new Product
                    {
                        ProductId = int.Parse(txtProductID.Text),
                    };
                    productRepository.DeleteProduct(p);
                    LoadProductList();
                    txtProductID.Clear();
                    txtCategoryID.Clear();
                    txtProductName.Clear();
                    txtWeight.Clear();
                    txtPrice.Clear();
                    txtStock.Clear();

                }
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private Product GetProductObject()
        {
            Product pro = null;
            try
            {
                pro = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtCategoryID.Text),
                    UnitPrice = decimal.Parse(txtPrice.Text),
                    UnitsInStock = short.Parse(txtStock.Text),
                    Weight = txtWeight.Text,

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return pro;
        }

        private void dgvListProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProduct product = new frmProduct
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                Product = GetProductObject(),
                ProductRepository = productRepository
            };
            this.Hide();
            product.ShowDialog();
            this.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadProductList();
            LoadMemberList();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadListSearch(txtSearchBox.Text, searchType);
        }

        private void cboSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchBox.Clear();
            searchType = cboSearchFilter.Text;

        }

        //Member ----------------------------------------------------------------------------------

        public void LoadMemberList()
        {
            try
            {
                var memberList = memberRepository.GetMembers();

                BindingSource source;
                source = new BindingSource();
                source.DataSource = memberList;

                txtCountry.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtCountry.DataBindings.Add("Text", source, "Country");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvListMember.DataSource = null;
                dgvListMember.DataSource = source;

                ClearSearchSection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of members");
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoadMember_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private Member GetMemberObject()
        {
            Member mem = null;
            try
            {
                mem = new Member
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    CompanyName = txtCompanyName.Text,

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return mem;
        }


        private void btnNewMember_Click(object sender, EventArgs e)
        {
            frmMembers members = new frmMembers
            {
                Text = "Add a new member!",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            this.Hide();
            members.ShowDialog();
            this.Show();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {

            if (txtMemberID.Text == "")
            {
                MessageBox.Show("There are nothing to delete!");
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Do u really wanna delete this member?", "Member management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var m = new Member
                    {
                        MemberId = int.Parse(txtMemberID.Text),
                    };
                    memberRepository.DeleteMember(m);
                    txtCountry.Clear();
                    txtCity.Clear();
                    txtCompanyName.Clear();
                    txtMemberID.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    LoadMemberList();

                }
            }
            
        }

        private void dgvListMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMembers members = new frmMembers
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                Member = GetMemberObject(),
                MemberRepository = memberRepository
            };
            this.Hide();
            members.ShowDialog();
            this.Show();
        }


        //Order ----------------------------------------------------------------------------
        private void btnClose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Order GetOrderObject()
        {
            Order orderObject = null;
            if (txtOrderID.Text != "")
            {
                orderObject = orderRepository.GetOrderByOrderID(txtOrderID.Text);
            }

            return orderObject;
        }

        public void LoadOrderList()
        {
            try
            {
                var orderList = orderRepository.GetOrders();

                BindingSource source;
                source = new BindingSource();
                source.DataSource = orderList;

                txtOrderID.DataBindings.Clear();
                txtMemberOrderID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtMemberOrderID.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

                dgvListOrder.DataSource = null;
                dgvListOrder.DataSource = source;

                ClearSearchSection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of orders");
            }
        }

        private void btnLoadOrder_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void dgvListOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetail ordDetail = new frmOrderDetail
            {
                Text = "Order Detail List",
                OrderID = txtOrderID.Text,
                OrderDetailRepository = orderDetailRepository,
                UserOrAdmin = true
                
            };
            this.Hide();
            ordDetail.ShowDialog();
            this.Show();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmOrderCreate CreateOrder = new frmOrderCreate
            {
                Text = "Add a new order!",
                AdjustOrderDetailRepository = orderDetailRepository
            };
            this.Hide();
            CreateOrder.ShowDialog();
            this.Show();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "")
            {
                MessageBox.Show("There are nothing to delete!");
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Do u really wanna delete this?", "Order management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var ord = new Order
                    {
                        OrderId = int.Parse(txtOrderID.Text),
                    };
                    orderRepository.DeleteOrder(ord);
                    LoadProductList();
                    LoadOrderList();
                    MessageBox.Show("Delete order successfully!");
                    txtOrderID.Clear();
                    txtMemberOrderID.Clear();
                    txtOrderDate.Clear();
                    txtRequiredDate.Clear();
                    txtShippedDate.Clear();
                    txtFreight.Clear();
                }
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            var orderObject = GetOrderObject();
            if (orderObject == null)
            {
                MessageBox.Show("No order are choose, please choose an order to update!");
            }
            else
            {
                frmOrderUpdate updateOrder = new frmOrderUpdate
                {
                    Text = "Update an oreder",
                    orderObject = orderObject
                };
                this.Hide();
                updateOrder.ShowDialog();
                this.Show();
            }

        }

        //Statistic--------------------------------------------------------------------------------



        private void btnLoadStatistic_Click(object sender, EventArgs e)
        {
            var listOrder = orderRepository.GetOrderByDate(dtpFrom.Value, dtpTo.Value);        
            decimal TotalPrice = 0;
            int TotalProduct = 0;
            decimal TotalPriceAfterDiscount = 0;
            decimal lastTotalPrice = 0;
            List<OrderStatistic> listOrderStatistic = new List<OrderStatistic>();
            foreach (var ord in listOrder)
            {
                
                var listOrderDetail = orderDetailRepository.GetOrderDetailByOrderID(ord.OrderId.ToString());
                foreach (var ordDetail in listOrderDetail)
                {
                    TotalPrice += (ordDetail.Quantity * ordDetail.UnitPrice);
                    TotalProduct += ordDetail.Quantity;
                    TotalPriceAfterDiscount += (ordDetail.Quantity * ordDetail.UnitPrice) - ((ordDetail.Quantity * ordDetail.UnitPrice) * (decimal)ordDetail.Discount / 100);
                }
                OrderStatistic orderStatistic = new OrderStatistic
                {
                    MemberId = ord.MemberId,
                    Freight = ord.Freight,
                    OrderId = ord.OrderId,
                    TotalPrice = (int)(TotalPrice - lastTotalPrice),
                    TotalProdcut = TotalProduct
                };
                lastTotalPrice = TotalPrice;
                listOrderStatistic.Add(orderStatistic);
            }
            dgvStatistic.DataSource = null;
            dgvStatistic.DataSource = listOrderStatistic.ToList();
            lbTotalOrder.Text = "Total orders: " + listOrder.Count().ToString();
            lbTotalPrice.Text = "Total price: " + TotalPrice.ToString();
            lbTotalProduct.Text = "Total products: " + TotalProduct.ToString();
            lbTotalPriceAfterDiscount.Text = "Total price after discount: " + TotalPriceAfterDiscount.ToString();
        }

        private void btnCancelStatistics_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
