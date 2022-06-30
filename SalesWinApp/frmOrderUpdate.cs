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
    public partial class frmOrderUpdate : Form
    {
        public Order orderObject { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        IOrderRepository orderRepository = new OrderRepository();
        public frmOrderUpdate()
        {
            InitializeComponent();
        }

        public void LoadMemberList()
        {
            var listMember = memberRepository.GetMembers();
            cboMemberID.DataSource = listMember;
            cboMemberID.ValueMember = "MemberId";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                OrderId = orderObject.OrderId,
                MemberId = int.Parse(cboMemberID.Text),
                Freight = int.Parse(txtFreight.Text),
                OrderDate = orderObject.OrderDate,
                RequiredDate = orderObject.RequiredDate,
                ShippedDate = orderObject.ShippedDate

            };
            orderRepository.UpdateOrder(order);
            MessageBox.Show("Update order successfully!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrderUpdate_Load(object sender, EventArgs e)
        {
            txtFreight.Text = orderObject.Freight.ToString();
            txtOrderDate.Text = orderObject.OrderDate.ToString();
            txtRequiredDate.Text = orderObject.RequiredDate.ToString();
            txtShippedDate.Text = orderObject.ShippedDate.ToString();
            LoadMemberList();
            cboMemberID.SelectedIndex = -1;
        }
    }
}
