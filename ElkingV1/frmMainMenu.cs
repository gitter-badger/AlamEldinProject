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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void logouttoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin frm = new frmlogin();
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(frmMainMenu_FormClosed);
            frm.txt_UserName.Text = "";
            frm.txt_Password.Text = "";
            frm.txt_UserName.Focus();
        }

        private void suppliertoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Suppliers frm = new Suppliers();
            //frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
            if (PublicVariables.SupplierTable == null)
                GetData(true);
            else
                LoadData(PublicVariables.SupplierTable, dataGridView1);
            if (PublicVariables.CustomerTable == null)
                GetData(false);
            else
                LoadData(PublicVariables.CustomerTable, dataGridView2);
        }

        public void GetData(bool flag)
        {
            if (flag)
            {
                DataTable dtSuppliers = DB.Retreivedata("select [ID],[Name],[Balance],[Kind] from [dbo].[Tbl_Suppliers]");
                dataGridView1.Rows.Clear();
                PublicVariables.SupplierTable = dtSuppliers;
                LoadData(PublicVariables.SupplierTable, dataGridView1);

            }
            else
            {
                DataTable dtCustomers = DB.Retreivedata("select [ID],[Name],[Address],[Balance] from [dbo].[Tbl_Customer]");
                dataGridView2.Rows.Clear();
                PublicVariables.CustomerTable = dtCustomers;
                LoadData(PublicVariables.CustomerTable, dataGridView2);

            }

        }

        private void txt_SpplierName_TextChanged(object sender, EventArgs e)
        {
            if (txt_SpplierName.Text != "")
            {
                DataTable dt = DB.Retreivedata("select [ID],[Name],[Balance],[Kind] from [dbo].[Tbl_Suppliers] where CHARINDEX(N'" + txt_SpplierName.Text + "', [Name]) > 0");
                dataGridView1.Rows.Clear();
                LoadData(dt, dataGridView1);
            }
            else
            {
                if (PublicVariables.SupplierTable == null)
                {
                    dataGridView1.Rows.Clear();
                    GetData(true);
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    LoadData(PublicVariables.SupplierTable, dataGridView1);
                }

            }
        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {
            if (txt_UserName.Text != "")
            {
                DataTable dt = DB.Retreivedata("select [ID],[Name],[Address],[Balance] from [dbo].[Tbl_Customer] where CHARINDEX(N'" + txt_UserName.Text + "',Name) >0");
                dataGridView2.Rows.Clear();
                LoadData(dt, dataGridView2);
            }
            else
            {
                if (PublicVariables.CustomerTable == null)
                {
                    dataGridView2.Rows.Clear();
                    GetData(false);
                }
                else
                {
                    dataGridView2.Rows.Clear();
                    LoadData(PublicVariables.CustomerTable, dataGridView2);
                }
            }
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }


        public void LoadData(DataTable dt, DataGridView dgv)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
                dgv.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]);
        }

        private void البياناتالأساسيةللموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers frm = new Suppliers();
            frm.Show();
        }

        private void فواتيرالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierInvoice frminvoice = new SupplierInvoice();
            frminvoice.Show();
        }

        private void حساباتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuplliersBalances frmbalance = new SuplliersBalances();
            frmbalance.Show();
        }

        private void مرتجعاتللموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierReturns frmsuppreturns = new SupplierReturns();
            frmsuppreturns.Show();
        }

        private void boxtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DailyDealings frmDealings = new DailyDealings();
            frmDealings.Show();
        }
    }
}
