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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        

        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

       
        //////////////////////////////////////////////////////
        /// <summary>
        /// //////////////
        /// </summary>
        /// <param name="childFrmName"></param>
        /// <returns></returns>
        public bool checkchildFrmExist(string childFrmName)
        {
            foreach (Form childFrm in this.MdiChildren)
            {
                if (childFrm.Text.ToString() == childFrmName)
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)
                    {
                        childFrm.WindowState = FormWindowState.Normal;

                    }
                    childFrm.Activate();

                    return true;

                }
            }
            return false;
        }

        private void UserManage_Click(object sender, EventArgs e)
        {
            if (checkchildFrmExist("用户管理") == true) { return; }

            FormUserManage formUserManage = new FormUserManage();
            //form1.MdiParent = this;
            //form1.Show();
            formUserManage.ShowDialog();
        }
    }
}
