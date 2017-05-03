using System;
using System.Windows.Forms;

namespace LibraryMIS
{
    public partial class FormBookManage : Form
    {
        public FormBookManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            FormBookInsert formBookInsert = new FormBookInsert();

            formBookInsert.ShowDialog();
            FormBookManage_Load(sender, e);
        }

        private void FormBookManage_Load(object sender, System.EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (dgvInfo.RowCount > 0)
            {
                FormBookInsert formBookInsert = new FormBookInsert();
                formBookInsert.op = "Edit";
                formBookInsert.BookID = Convert.ToString(dgvInfo[0, dgvInfo.CurrentCell.RowIndex].Value).Trim();
                formBookInsert.Text = "修改图书信息";

                formBookInsert.ShowDialog();
                FormBookManage_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 删除数据
        }
    }
}
