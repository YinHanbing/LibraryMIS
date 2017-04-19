using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryMIS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Common.CGlobal.userName = "test";
            if (ValidateLogin(txtUserName.Text, txtPassword.Text))
                
                this.Close();
            else
                MessageBox.Show("用户名或者密码不正确，请重试！");
        }

        //
        private bool ValidateLogin(String Account, String Password)
        {
            Common.DataBase dataBase = new Common.DataBase();
            try
            {
                DataSet myds = dataBase.RunProcReturn("select count(*) from users where UserName='" + Account + "' and password='" + Password + "'");

                if (myds.Tables[0].Rows[0][0].ToString() == "1")
                    Common.CGlobal.userName = Account;
                else
                    Common.CGlobal.userName = "";
            }
            catch
            {
                Common.CGlobal.userName = "";
            }

            if (Common.CGlobal.userName == "")
                return false;
            else
            {
                return true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
    }
}
