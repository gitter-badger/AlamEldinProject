namespace ElkingV1
{
    partial class SuplliersBalances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuplliersBalances));
            this.lbl_SupplierName = new System.Windows.Forms.Label();
            this.txt_SuplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_PayMentDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CBO_Payment = new System.Windows.Forms.ComboBox();
            this.Rtxt_Notes = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_SupplierName
            // 
            this.lbl_SupplierName.AutoSize = true;
            this.lbl_SupplierName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SupplierName.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_SupplierName.Location = new System.Drawing.Point(151, 12);
            this.lbl_SupplierName.Name = "lbl_SupplierName";
            this.lbl_SupplierName.Size = new System.Drawing.Size(84, 21);
            this.lbl_SupplierName.TabIndex = 1;
            this.lbl_SupplierName.Text = "اسم المورد :";
            // 
            // txt_SuplierName
            // 
            this.txt_SuplierName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_SuplierName.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.txt_SuplierName.Location = new System.Drawing.Point(33, 12);
            this.txt_SuplierName.Name = "txt_SuplierName";
            this.txt_SuplierName.Size = new System.Drawing.Size(100, 24);
            this.txt_SuplierName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(146, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "المبلغ المستحق :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.textBox1.Location = new System.Drawing.Point(33, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(146, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "المبلغ المدفوع :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.textBox2.Location = new System.Drawing.Point(33, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(146, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "تاريخ سداد المبلغ :";
            // 
            // dtp_PayMentDate
            // 
            this.dtp_PayMentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_PayMentDate.Location = new System.Drawing.Point(33, 139);
            this.dtp_PayMentDate.Name = "dtp_PayMentDate";
            this.dtp_PayMentDate.Size = new System.Drawing.Size(100, 20);
            this.dtp_PayMentDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(146, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "طريقة السداد :";
            // 
            // CBO_Payment
            // 
            this.CBO_Payment.FormattingEnabled = true;
            this.CBO_Payment.Items.AddRange(new object[] {
            "نقدي",
            "بنكي"});
            this.CBO_Payment.Location = new System.Drawing.Point(33, 182);
            this.CBO_Payment.Name = "CBO_Payment";
            this.CBO_Payment.Size = new System.Drawing.Size(100, 21);
            this.CBO_Payment.TabIndex = 4;
            // 
            // Rtxt_Notes
            // 
            this.Rtxt_Notes.Location = new System.Drawing.Point(12, 248);
            this.Rtxt_Notes.Name = "Rtxt_Notes";
            this.Rtxt_Notes.Size = new System.Drawing.Size(253, 96);
            this.Rtxt_Notes.TabIndex = 5;
            this.Rtxt_Notes.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(192, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "ملاحظات :";
            // 
            // SuplliersBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElkingV1.Properties.Resources.nexus7_2013_wallpaper;
            this.ClientSize = new System.Drawing.Size(277, 356);
            this.Controls.Add(this.Rtxt_Notes);
            this.Controls.Add(this.CBO_Payment);
            this.Controls.Add(this.dtp_PayMentDate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SuplierName);
            this.Controls.Add(this.lbl_SupplierName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuplliersBalances";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابات الموردين";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SupplierName;
        private System.Windows.Forms.TextBox txt_SuplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_PayMentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBO_Payment;
        private System.Windows.Forms.RichTextBox Rtxt_Notes;
        private System.Windows.Forms.Label label5;
    }
}