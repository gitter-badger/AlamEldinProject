namespace ElkingV1
{
    partial class Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.lbl_SupplierID = new System.Windows.Forms.Label();
            this.txt_SupplierID = new System.Windows.Forms.TextBox();
            this.lbl_SupplierName = new System.Windows.Forms.Label();
            this.txt_SupplierName = new System.Windows.Forms.TextBox();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.lbl_DateBalance = new System.Windows.Forms.Label();
            this.dtp_DateBalance = new System.Windows.Forms.DateTimePicker();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.CBO_Kind = new System.Windows.Forms.ComboBox();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.GB = new System.Windows.Forms.GroupBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_choose = new System.Windows.Forms.Button();
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SupplierID
            // 
            this.lbl_SupplierID.AutoSize = true;
            this.lbl_SupplierID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SupplierID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_SupplierID.Location = new System.Drawing.Point(225, 12);
            this.lbl_SupplierID.Name = "lbl_SupplierID";
            this.lbl_SupplierID.Size = new System.Drawing.Size(83, 22);
            this.lbl_SupplierID.TabIndex = 66;
            this.lbl_SupplierID.Text = "رقم المورد :";
            // 
            // txt_SupplierID
            // 
            this.txt_SupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.txt_SupplierID.Location = new System.Drawing.Point(71, 12);
            this.txt_SupplierID.Name = "txt_SupplierID";
            this.txt_SupplierID.ReadOnly = true;
            this.txt_SupplierID.Size = new System.Drawing.Size(128, 20);
            this.txt_SupplierID.TabIndex = 67;
            this.txt_SupplierID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SupplierID_KeyUp);
            // 
            // lbl_SupplierName
            // 
            this.lbl_SupplierName.AutoSize = true;
            this.lbl_SupplierName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SupplierName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_SupplierName.Location = new System.Drawing.Point(224, 53);
            this.lbl_SupplierName.Name = "lbl_SupplierName";
            this.lbl_SupplierName.Size = new System.Drawing.Size(84, 22);
            this.lbl_SupplierName.TabIndex = 60;
            this.lbl_SupplierName.Text = "اسم المورد :";
            // 
            // txt_SupplierName
            // 
            this.txt_SupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.txt_SupplierName.Location = new System.Drawing.Point(71, 55);
            this.txt_SupplierName.Name = "txt_SupplierName";
            this.txt_SupplierName.Size = new System.Drawing.Size(128, 20);
            this.txt_SupplierName.TabIndex = 1;
            this.txt_SupplierName.TextChanged += new System.EventHandler(this.txt_SupplierName_TextChanged);
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Tel.Location = new System.Drawing.Point(225, 96);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(57, 22);
            this.lbl_Tel.TabIndex = 60;
            this.lbl_Tel.Text = "تليفون :";
            // 
            // txt_Tel
            // 
            this.txt_Tel.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Tel.Location = new System.Drawing.Point(70, 96);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(129, 20);
            this.txt_Tel.TabIndex = 2;
            // 
            // lbl_DateBalance
            // 
            this.lbl_DateBalance.AutoSize = true;
            this.lbl_DateBalance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DateBalance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_DateBalance.Location = new System.Drawing.Point(224, 135);
            this.lbl_DateBalance.Name = "lbl_DateBalance";
            this.lbl_DateBalance.Size = new System.Drawing.Size(103, 22);
            this.lbl_DateBalance.TabIndex = 60;
            this.lbl_DateBalance.Text = "تاريخ الرصيد :";
            // 
            // dtp_DateBalance
            // 
            this.dtp_DateBalance.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.dtp_DateBalance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateBalance.Location = new System.Drawing.Point(71, 135);
            this.dtp_DateBalance.Name = "dtp_DateBalance";
            this.dtp_DateBalance.Size = new System.Drawing.Size(128, 24);
            this.dtp_DateBalance.TabIndex = 3;
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Balance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Balance.Location = new System.Drawing.Point(224, 173);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(114, 22);
            this.lbl_Balance.TabIndex = 60;
            this.lbl_Balance.Text = "رصيد اول المده :";
            // 
            // CBO_Kind
            // 
            this.CBO_Kind.FormattingEnabled = true;
            this.CBO_Kind.Location = new System.Drawing.Point(149, 175);
            this.CBO_Kind.Name = "CBO_Kind";
            this.CBO_Kind.Size = new System.Drawing.Size(50, 21);
            this.CBO_Kind.TabIndex = 4;
            // 
            // txt_Balance
            // 
            this.txt_Balance.Location = new System.Drawing.Point(70, 175);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Size = new System.Drawing.Size(73, 20);
            this.txt_Balance.TabIndex = 5;
            // 
            // GB
            // 
            this.GB.BackColor = System.Drawing.Color.Transparent;
            this.GB.Controls.Add(this.btn_Report);
            this.GB.Controls.Add(this.btn_Delete);
            this.GB.Controls.Add(this.btn_Edit);
            this.GB.Controls.Add(this.btn_Add);
            this.GB.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.GB.Location = new System.Drawing.Point(23, 231);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(330, 100);
            this.GB.TabIndex = 68;
            this.GB.TabStop = false;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(88, 61);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(153, 33);
            this.btn_Report.TabIndex = 0;
            this.btn_Report.Text = "تقرير بالبيانات الاساسية للموردين";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(48, 23);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(129, 23);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(210, 23);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "اضافة";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(224, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "العنوان :";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(71, 211);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(128, 20);
            this.txt_Address.TabIndex = 6;
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Change.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btn_Change.Location = new System.Drawing.Point(12, 133);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(52, 24);
            this.btn_Change.TabIndex = 70;
            this.btn_Change.Text = "تغيير";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_choose
            // 
            this.btn_choose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_choose.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btn_choose.Location = new System.Drawing.Point(13, 9);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(52, 23);
            this.btn_choose.TabIndex = 71;
            this.btn_choose.Text = "اختار";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElkingV1.Properties.Resources.nexus7_2013_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(375, 343);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.txt_Balance);
            this.Controls.Add(this.CBO_Kind);
            this.Controls.Add(this.dtp_DateBalance);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_SupplierName);
            this.Controls.Add(this.txt_SupplierID);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.lbl_DateBalance);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.lbl_SupplierName);
            this.Controls.Add(this.lbl_SupplierID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Suppliers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الموردين";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            this.GB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_SupplierID;
        internal System.Windows.Forms.TextBox txt_SupplierID;
        internal System.Windows.Forms.Label lbl_SupplierName;
        internal System.Windows.Forms.TextBox txt_SupplierName;
        internal System.Windows.Forms.Label lbl_Tel;
        internal System.Windows.Forms.TextBox txt_Tel;
        internal System.Windows.Forms.Label lbl_DateBalance;
        internal System.Windows.Forms.DateTimePicker dtp_DateBalance;
        internal System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.ComboBox CBO_Kind;
        private System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_choose;
    }
}