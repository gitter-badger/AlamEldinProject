using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElkingV1.DBClass;

namespace ElkingV1
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم الخاص بك", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_UserName.Focus();
                return;
            }
            if (txt_Password.Text == "")
            {
                MessageBox.Show("من فضلك ادخل كلمة المرور الخاصه بك", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Password.Focus();
                return;
            }
            try
            {
                DataTable dt = DB.Retreivedata("select [UserName],[Password] from [Tbl_Profile] where [UserName]='" + txt_UserName.Text +
                                "' and Password = "+txt_Password.Text);
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("من فضلك ادخل اسم دخول او كلمة مرور صحيحه");
                    txt_UserName.Clear();
                    txt_Password.Clear();
                    txt_UserName.Focus();
                }
                else
                {
                    frmMainMenu menu = new frmMainMenu();
                    menu.FormClosed += new FormClosedEventHandler(frmlogin_FormClosed);
                    menu.lbl_UserName.Text = txt_UserName.Text;
                    menu.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void frmlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
