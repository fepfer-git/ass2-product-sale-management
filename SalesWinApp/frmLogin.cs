
using DataAccess;
using DataAccess.Repository;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {

        IMemberRepository memberRepository = new MemberRepository();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string fileName = "appsetting.json";
            string json = File.ReadAllText(fileName);  // đọc text từ tập tin JSON

            // deserialize từ chuỗi đọc ở tập tin JSOn --> đối tượng DefaultAccount
            var adminAccount = JsonSerializer.Deserialize<AccountDefault>(json, null);

            string email = adminAccount.Email;
            string password = adminAccount.Password;
            string role = adminAccount.Role;


            

            if (txtUserName.Text == email && txtPassword.Text == password)
            {
                frmMain main = new frmMain();
                this.Hide();
                main.ShowDialog();
                this.Show();
                txtUserName.Clear();
                txtPassword.Clear();
            }
            else 
            {
                var userLogin = memberRepository.CheckLogin(txtUserName.Text, txtPassword.Text);
                if (userLogin != null)
                {
                    frmUserPage userPage = new frmUserPage()
                    {
                        memberLogin = userLogin
                    };
                    this.Hide();
                    userPage.ShowDialog();
                    this.Show();
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Sai pass rùi bạn êy");                   
                    txtUserName.Focus();
                }
            }
            
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are u sure to exit?","Login Notification!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
