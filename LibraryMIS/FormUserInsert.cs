using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryMIS
{
    public partial class FormUserInsert : Form
    {
        Common.DataBase dataBase = new Common.DataBase();
        public string op = "Add";
        public string UserID = "";

        public FormUserInsert()
        {
            InitializeComponent();
        }

        private void FormUserInsert_Load(object sender, EventArgs e)
        {
            if (op == "Edit")
            {
                //
                DataSet vrds = dataBase.RunProcReturn("select * from Users where UserID=" + UserID);
                if (vrds.Tables[0].Rows.Count < 0)
                    Close();
               

                edtUserName.Text = vrds.Tables[0].Rows[0]["UserName"].ToString();
                edtName.Text = vrds.Tables[0].Rows[0]["Name"].ToString();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (op == "Add")
            {

                int result = dataBase.RunProc("insert into Users(UserName,Name,Password) values('" + edtUserName.Text.Trim() + "','" + edtName.Text.Trim() + "','123456')");


                if (result == 1)
                {
                    MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {

                    MessageBox.Show("数据保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (op == "Edit")
            {
                int result = dataBase.RunProc("update Users set UserName='" + edtUserName.Text.Trim() + "',Name='" + edtName.Text.Trim() + "' where UserID=" + UserID);


                if (result == 1)
                {
                    MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {

                    MessageBox.Show("数据保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
