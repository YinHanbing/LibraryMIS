using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryMIS
{
    public partial class FormUserManage : Form
    {
        Common.DataBase dataBase = new Common.DataBase();
        public FormUserManage()
        {
            InitializeComponent();
        }

        private void FormUserManage_Load(object sender, EventArgs e)
        {

            DataSet myds = dataBase.RunProcReturn("select UserID,UserName,Name from users");
            dgvInfo.AutoGenerateColumns = false;
            dgvInfo.DataSource = myds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInfo.RowCount > 0)
            {
                if (MessageBox.Show("确定要删除用户【" + Convert.ToString(dgvInfo[2, dgvInfo.CurrentCell.RowIndex].Value).Trim() + "】吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (dataBase.RunProc("delete from users where userid='" + Convert.ToString(dgvInfo[0, dgvInfo.CurrentCell.RowIndex].Value).Trim() + "'") == 1)
                    {
                        FormUserManage_Load(sender, e);
                        MessageBox.Show("删除数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("删除数据失败", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInfo.RowCount > 0)
            {
                FormUserInsert formUserInsert = new FormUserInsert();
                formUserInsert.op = "Edit";
                formUserInsert.UserID = Convert.ToString(dgvInfo[0, dgvInfo.CurrentCell.RowIndex].Value).Trim();
                formUserInsert.Text = "修改用户信息";

                formUserInsert.ShowDialog();
                FormUserManage_Load(sender, e);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormUserManage_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormUserInsert formUserInsert = new FormUserInsert();

            formUserInsert.ShowDialog();
            FormUserManage_Load(sender, e);
        }
    }
}
