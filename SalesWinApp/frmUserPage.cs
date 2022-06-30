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
    public partial class frmUserPage : Form
    {
        public frmUserPage()
        {
            InitializeComponent();
        }

        Member currentMemberInfo = new Member();

        public Member memberLogin { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public void LoadUserInfo()
        {
            currentMemberInfo = memberRepository.GetMemberByMemberID(memberLogin.MemberId.ToString());
            txtCity.Text = currentMemberInfo.City;
            txtCompanyName.Text = currentMemberInfo.CompanyName;
            txtCountry.Text = currentMemberInfo.Country;
            txtEmail.Text = currentMemberInfo.Email;
            txtMemberID.Text = currentMemberInfo.MemberId.ToString();
            txtPassword.Text = currentMemberInfo.Password;

        }

        public void LoadUserOrder()
        {
            var listUserOrder = orderRepository.GetOrdersByMemberID(memberLogin.MemberId.ToString());
            BindingSource source;
            source = new BindingSource();
            source.DataSource = listUserOrder;

            txtOrderID.DataBindings.Clear();
            txtMemberOrderID.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();
            txtFreight.DataBindings.Clear();
            txtRequiredDate.DataBindings.Clear();

            txtOrderID.DataBindings.Add("Text", source, "OrderId");
            txtMemberOrderID.DataBindings.Add("Text", source, "MemberId");
            txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            txtFreight.DataBindings.Add("Text", source, "Freight");
            txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
            txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");

            dgvListOrder.DataSource = null;
            dgvListOrder.DataSource = source;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            frmMembers updateMember = new frmMembers()
            {
                Member = memberLogin,
                InsertOrUpdate = true,
                MemberRepository = memberRepository
                
            };
            
            this.Hide();
            updateMember.ShowDialog();
            this.Show();
            LoadUserInfo();
        }

        private void frmUserPage_Load(object sender, EventArgs e)
        {
            
            LoadUserInfo();
            LoadUserOrder();
        }

        private void frmUserPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are u sure to exit?", "Login Notification!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvListOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetail ordDetail = new frmOrderDetail
            {
                Text = "Order Detail List",
                OrderID = txtOrderID.Text,
                OrderDetailRepository = orderDetailRepository,
                UserOrAdmin = false
            };
            this.Hide();
            ordDetail.ShowDialog();
            this.Show();
        }
    }
}
