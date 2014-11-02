namespace ElkingV1
{
    partial class SupplierInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_invoiceNo = new System.Windows.Forms.TextBox();
            this.lbl_SupplierName = new System.Windows.Forms.Label();
            this.txt_SupplierName = new System.Windows.Forms.TextBox();
            this.lbl_DateOfInvoice = new System.Windows.Forms.Label();
            this.dtp_DateofInvoice = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_invoiceSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SupplierBalance = new System.Windows.Forms.TextBox();
            this.btn_Newinvoice = new System.Windows.Forms.Button();
            this.btn_addnewitem = new System.Windows.Forms.Button();
            this.btn_deleteinvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتوره :";
            // 
            // txt_invoiceNo
            // 
            this.txt_invoiceNo.Location = new System.Drawing.Point(199, 12);
            this.txt_invoiceNo.Name = "txt_invoiceNo";
            this.txt_invoiceNo.Size = new System.Drawing.Size(172, 20);
            this.txt_invoiceNo.TabIndex = 1;
            // 
            // lbl_SupplierName
            // 
            this.lbl_SupplierName.AutoSize = true;
            this.lbl_SupplierName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SupplierName.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_SupplierName.Location = new System.Drawing.Point(377, 44);
            this.lbl_SupplierName.Name = "lbl_SupplierName";
            this.lbl_SupplierName.Size = new System.Drawing.Size(84, 21);
            this.lbl_SupplierName.TabIndex = 0;
            this.lbl_SupplierName.Text = "اسم المورد :";
            // 
            // txt_SupplierName
            // 
            this.txt_SupplierName.Location = new System.Drawing.Point(199, 47);
            this.txt_SupplierName.Name = "txt_SupplierName";
            this.txt_SupplierName.Size = new System.Drawing.Size(172, 20);
            this.txt_SupplierName.TabIndex = 1;
            // 
            // lbl_DateOfInvoice
            // 
            this.lbl_DateOfInvoice.AutoSize = true;
            this.lbl_DateOfInvoice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DateOfInvoice.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_DateOfInvoice.Location = new System.Drawing.Point(377, 84);
            this.lbl_DateOfInvoice.Name = "lbl_DateOfInvoice";
            this.lbl_DateOfInvoice.Size = new System.Drawing.Size(107, 21);
            this.lbl_DateOfInvoice.TabIndex = 0;
            this.lbl_DateOfInvoice.Text = "تاريخ الفاتورة :";
            // 
            // dtp_DateofInvoice
            // 
            this.dtp_DateofInvoice.Enabled = false;
            this.dtp_DateofInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateofInvoice.Location = new System.Drawing.Point(199, 84);
            this.dtp_DateofInvoice.Name = "dtp_DateofInvoice";
            this.dtp_DateofInvoice.Size = new System.Drawing.Size(172, 20);
            this.dtp_DateofInvoice.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(605, 220);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "الصنف الرئيسي";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "الصنف الفرعي";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "الوزن بالكيلو";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "الوزن بالطن";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "سعر الكيلو";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column6.HeaderText = "الاجمالي";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(199, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "اجمالي الفاتوره :";
            // 
            // txt_invoiceSum
            // 
            this.txt_invoiceSum.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.txt_invoiceSum.Location = new System.Drawing.Point(49, 357);
            this.txt_invoiceSum.Name = "txt_invoiceSum";
            this.txt_invoiceSum.Size = new System.Drawing.Size(128, 24);
            this.txt_invoiceSum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(199, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "رصيد المورد :";
            // 
            // txt_SupplierBalance
            // 
            this.txt_SupplierBalance.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.txt_SupplierBalance.Location = new System.Drawing.Point(49, 387);
            this.txt_SupplierBalance.Name = "txt_SupplierBalance";
            this.txt_SupplierBalance.Size = new System.Drawing.Size(128, 24);
            this.txt_SupplierBalance.TabIndex = 5;
            // 
            // btn_Newinvoice
            // 
            this.btn_Newinvoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Newinvoice.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.btn_Newinvoice.Location = new System.Drawing.Point(455, 351);
            this.btn_Newinvoice.Name = "btn_Newinvoice";
            this.btn_Newinvoice.Size = new System.Drawing.Size(80, 30);
            this.btn_Newinvoice.TabIndex = 6;
            this.btn_Newinvoice.Text = "فاتورة جديدة";
            this.btn_Newinvoice.UseVisualStyleBackColor = false;
            // 
            // btn_addnewitem
            // 
            this.btn_addnewitem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addnewitem.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.btn_addnewitem.Location = new System.Drawing.Point(370, 383);
            this.btn_addnewitem.Name = "btn_addnewitem";
            this.btn_addnewitem.Size = new System.Drawing.Size(165, 30);
            this.btn_addnewitem.TabIndex = 6;
            this.btn_addnewitem.Text = "اضافة صنف لفاتورة سابقة";
            this.btn_addnewitem.UseVisualStyleBackColor = false;
            // 
            // btn_deleteinvoice
            // 
            this.btn_deleteinvoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deleteinvoice.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.btn_deleteinvoice.Location = new System.Drawing.Point(370, 351);
            this.btn_deleteinvoice.Name = "btn_deleteinvoice";
            this.btn_deleteinvoice.Size = new System.Drawing.Size(80, 30);
            this.btn_deleteinvoice.TabIndex = 6;
            this.btn_deleteinvoice.Text = "حذف فاتورة";
            this.btn_deleteinvoice.UseVisualStyleBackColor = false;
            // 
            // SupplierInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElkingV1.Properties.Resources.nexus7_2013_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 425);
            this.Controls.Add(this.btn_deleteinvoice);
            this.Controls.Add(this.btn_addnewitem);
            this.Controls.Add(this.btn_Newinvoice);
            this.Controls.Add(this.txt_SupplierBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_invoiceSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtp_DateofInvoice);
            this.Controls.Add(this.txt_SupplierName);
            this.Controls.Add(this.lbl_DateOfInvoice);
            this.Controls.Add(this.lbl_SupplierName);
            this.Controls.Add(this.txt_invoiceNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة مورد";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_invoiceNo;
        private System.Windows.Forms.Label lbl_SupplierName;
        private System.Windows.Forms.TextBox txt_SupplierName;
        private System.Windows.Forms.Label lbl_DateOfInvoice;
        private System.Windows.Forms.DateTimePicker dtp_DateofInvoice;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_invoiceSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SupplierBalance;
        private System.Windows.Forms.Button btn_Newinvoice;
        private System.Windows.Forms.Button btn_addnewitem;
        private System.Windows.Forms.Button btn_deleteinvoice;
    }
}