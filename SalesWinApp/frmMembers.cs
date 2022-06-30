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
    public partial class frmMembers : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member Member { get; set; }

        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are u sure to exit?", "Login Notification!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtCompanyName.Clear();
            txtPassword.Clear();
            cboCity.Text = null;
            cboCountry.Text = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Boolean checkId = true;
            int memID;
            try
            {
                do
                {

                    memID = rnd.Next(10, 10000);
                    if (!MemberRepository.CheckMemberIdDuplicated(memID))
                    {
                        checkId = false;
                    }


                } while (checkId);


                if (txtEmail.Text == "" || txtCompanyName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Product Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (InsertOrUpdate == false)
                    {
                        var m = new Member
                        {
                            Email = txtEmail.Text,
                            CompanyName = txtCompanyName.Text,
                            Password = txtPassword.Text,
                            City = cboCity.Text,
                            Country = cboCountry.Text,
                            MemberId = memID

                        };
                        MemberRepository.SaveMember(m);
                        MessageBox.Show("Add new member successfully!");
                        txtEmail.Clear();
                        txtCompanyName.Clear();
                        txtPassword.Clear();
                        cboCity.Text = null;
                        cboCountry.Text = null;
                    }
                    else
                    {
                        var m = new Member
                        {
                            Email = txtEmail.Text,
                            CompanyName = txtCompanyName.Text,
                            Password = txtPassword.Text,
                            City = cboCity.Text,
                            Country = cboCountry.Text,
                            MemberId = Member.MemberId

                        };
                        MemberRepository.UpdateMember(m);
                        MessageBox.Show("Update member successfully!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Member!" : "Update a Member!");

            }
        }

        private void frmMembers_Load(object sender, EventArgs e)
        { 
            if (InsertOrUpdate == true)
            {
                txtEmail.Text = Member.Email.ToString();
                txtCompanyName.Text = Member.CompanyName.ToString();
                txtPassword.Text = Member.Password.ToString();
                cboCity.SelectedItem = Member.City;
                cboCountry.SelectedItem = Member.Country;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {    
            if (InsertOrUpdate == true)
            {
                if (MemberRepository.CheckUpdateEmailDuplicated(Member.MemberId,txtEmail.Text))
                {
                    MessageBox.Show("Email is already used. Please try again!");
                    txtEmail.Clear();
                }
            }
            else if (InsertOrUpdate == false)
            {
                if (MemberRepository.CheckEmailDuplicated(txtEmail.Text))
                {
                    MessageBox.Show("Email is already used. Please try again!");
                    txtEmail.Clear();
                }
            }         
        }
    }
}
