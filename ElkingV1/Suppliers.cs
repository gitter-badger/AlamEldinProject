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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            CBO_Kind.Items.Add("مدين");
            CBO_Kind.Items.Add("دائن");
            txt_SupplierID.Text = "0";
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            //Autocomplete();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_SupplierID.Text == "0")
            {
                string query = "INSERT INTO [dbo].[Tbl_Suppliers]([Name],[Address],[Tel],[Balance],[Kind],[DateofBalance])VALUES(N'" + txt_SupplierName.Text + "',N'" + txt_Address.Text + "','" + txt_Tel.Text + "'," + txt_Balance.Text + ",N'" + CBO_Kind.SelectedItem + "','" + dtp_DateBalance.Value.ToString() + "')";
                DB.Execute(query);
                MessageBox.Show("تم تسجيل العميل بنجاح");
            }

        }

        private void txt_SupplierID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                DoSomething();
            }
        }
        //#region AutoComplete for Txt box supplier name
        ///// <summary>
        ///// This Function for making auto complete for text box supplier name
        ///// </summary>
        //public void Autocomplete()
        //{
        //    DataTable supptable = DB.Retreivedata("select * from [dbo].[Tbl_Suppliers]");
        //    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        //    for (int j = 0; j < supptable.Rows.Count; j++)
        //    {
        //        collection.Add(supptable.Rows[j]["Name"].ToString());
        //    }
        //    txt_SupplierName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    txt_SupplierName.AutoCompleteCustomSource = collection;
        //    txt_SupplierName.AutoCompleteMode = AutoCompleteMode.Suggest;


        //}

        //#endregion

        #region Open Lookup Form
        /// <summary>
        /// This function for opening the look up form
        /// </summary>
        public void DoSomething()
        {
            btn_Add.Enabled = false;
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;
            dtp_DateBalance.Enabled = false;
            SupplierLookUP frm = new SupplierLookUP();
            frm.dataGridView1.Rows.Clear();
            frmMainMenu form = new frmMainMenu();
            DataTable supptable = DB.Retreivedata("select * from [dbo].[Tbl_Suppliers]");
            for (int i = 0; i < supptable.Rows.Count; i++)
                frm.dataGridView1.Rows.Add(supptable.Rows[i][0], supptable.Rows[i][1], supptable.Rows[i][2], supptable.Rows[i][3], supptable.Rows[i][4], supptable.Rows[i][5], supptable.Rows[i][6]);
            frm.ShowDialog();

            foreach (DataGridViewRow item in frm.dataGridView1.SelectedRows)
            {
                txt_SupplierID.Text = item.Cells[0].Value.ToString();
                txt_SupplierName.Text = item.Cells[1].Value.ToString();
                txt_Balance.Text = Convert.ToInt32(item.Cells[4].Value).ToString();
                CBO_Kind.SelectedItem = item.Cells[5].Value.ToString();
                txt_Tel.Text = item.Cells[3].Value.ToString();
                dtp_DateBalance.Value = Convert.ToDateTime(item.Cells[6].Value);

                txt_Address.Text = item.Cells[2].Value.ToString();
            }
        }
        #endregion
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالفعل تعديل هذا المورد ؟", "تأكيد", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Convert.ToInt32(txt_SupplierID.Text) != 0)
                {
                    DB.Execute("UPDATE [dbo].[Tbl_Suppliers] SET [Name] = N'" + txt_SupplierName.Text + "',[Address] = N'" + txt_Address.Text + "',[Tel] = '" + txt_Tel.Text + "',[Balance] = " + txt_Balance.Text + ",[Kind] = N'" + CBO_Kind.SelectedItem + "'WHERE ID = " + txt_SupplierID.Text);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالفعل مسح هذا المورد ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Convert.ToInt32(txt_SupplierID.Text) != 0)
                {
                    DB.Execute("Delete From Tbl_Suppliers where ID = " + txt_SupplierID.Text);
                }
            }

        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (dtp_DateBalance.Enabled)
                dtp_DateBalance.Enabled = false;
            else
                dtp_DateBalance.Enabled = true;

        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            DoSomething();
        }

        private void txt_SupplierName_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
