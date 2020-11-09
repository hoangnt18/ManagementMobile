namespace PhoneManagement
{
    partial class frmTableManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsInformationAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInformationPrivate = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefersh = new System.Windows.Forms.Button();
            this.flpPhoneCate = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtPayMone = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdNewBill = new System.Windows.Forms.TextBox();
            this.txtIdItemPhone = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.txtNamePhone = new System.Windows.Forms.TextBox();
            this.flpBill = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.mtsInformationAccount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // mtsInformationAccount
            // 
            this.mtsInformationAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInformationPrivate,
            this.đăngXuấtToolStripMenuItem});
            this.mtsInformationAccount.Name = "mtsInformationAccount";
            this.mtsInformationAccount.Size = new System.Drawing.Size(128, 20);
            this.mtsInformationAccount.Text = "Information account";
            this.mtsInformationAccount.Click += new System.EventHandler(this.mtsInformationAccount_Click);
            // 
            // tsInformationPrivate
            // 
            this.tsInformationPrivate.Name = "tsInformationPrivate";
            this.tsInformationPrivate.Size = new System.Drawing.Size(180, 22);
            this.tsInformationPrivate.Text = "Information Private";
            this.tsInformationPrivate.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Log out";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "MOBILE PHONE SHOP";
            // 
            // btnRefersh
            // 
            this.btnRefersh.Location = new System.Drawing.Point(12, 27);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.Size = new System.Drawing.Size(55, 38);
            this.btnRefersh.TabIndex = 0;
            this.btnRefersh.Text = "Back";
            this.btnRefersh.UseVisualStyleBackColor = true;
            this.btnRefersh.Click += new System.EventHandler(this.btnRefersh_Click);
            // 
            // flpPhoneCate
            // 
            this.flpPhoneCate.AutoScroll = true;
            this.flpPhoneCate.Location = new System.Drawing.Point(12, 71);
            this.flpPhoneCate.Name = "flpPhoneCate";
            this.flpPhoneCate.Size = new System.Drawing.Size(344, 297);
            this.flpPhoneCate.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nmrDiscount);
            this.panel1.Controls.Add(this.txtPayMone);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Location = new System.Drawing.Point(365, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 58);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Discount";
            // 
            // nmrDiscount
            // 
            this.nmrDiscount.Location = new System.Drawing.Point(86, 8);
            this.nmrDiscount.Name = "nmrDiscount";
            this.nmrDiscount.Size = new System.Drawing.Size(120, 20);
            this.nmrDiscount.TabIndex = 9;
            // 
            // txtPayMone
            // 
            this.txtPayMone.Location = new System.Drawing.Point(42, 32);
            this.txtPayMone.Name = "txtPayMone";
            this.txtPayMone.ReadOnly = true;
            this.txtPayMone.Size = new System.Drawing.Size(164, 20);
            this.txtPayMone.TabIndex = 8;
            this.txtPayMone.Text = "0";
            this.txtPayMone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(313, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(107, 53);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(362, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 254);
            this.panel2.TabIndex = 7;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(420, 248);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 95;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quanlity";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 201;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtIdNewBill);
            this.panel3.Controls.Add(this.txtIdItemPhone);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.nmrAmount);
            this.panel3.Controls.Add(this.txtNamePhone);
            this.panel3.Location = new System.Drawing.Point(362, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 61);
            this.panel3.TabIndex = 8;
            // 
            // txtIdNewBill
            // 
            this.txtIdNewBill.Location = new System.Drawing.Point(142, 29);
            this.txtIdNewBill.Name = "txtIdNewBill";
            this.txtIdNewBill.Size = new System.Drawing.Size(100, 20);
            this.txtIdNewBill.TabIndex = 10;
            // 
            // txtIdItemPhone
            // 
            this.txtIdItemPhone.Location = new System.Drawing.Point(55, 4);
            this.txtIdItemPhone.Name = "txtIdItemPhone";
            this.txtIdItemPhone.Size = new System.Drawing.Size(80, 20);
            this.txtIdItemPhone.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(259, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 21);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(353, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(3, 29);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 20);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Text = "0";
            // 
            // nmrAmount
            // 
            this.nmrAmount.Location = new System.Drawing.Point(259, 4);
            this.nmrAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(88, 20);
            this.nmrAmount.TabIndex = 5;
            this.nmrAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNamePhone
            // 
            this.txtNamePhone.Location = new System.Drawing.Point(142, 3);
            this.txtNamePhone.Name = "txtNamePhone";
            this.txtNamePhone.Size = new System.Drawing.Size(111, 20);
            this.txtNamePhone.TabIndex = 0;
            // 
            // flpBill
            // 
            this.flpBill.Location = new System.Drawing.Point(12, 374);
            this.flpBill.Name = "flpBill";
            this.flpBill.Size = new System.Drawing.Size(347, 82);
            this.flpBill.TabIndex = 9;
            this.flpBill.Paint += new System.Windows.Forms.PaintEventHandler(this.flpBill_Paint);
            // 
            // frmTableManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.flpBill);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRefersh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpPhoneCate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTableManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Management";
            this.Load += new System.EventHandler(this.frmTableManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtsInformationAccount;
        private System.Windows.Forms.ToolStripMenuItem tsInformationPrivate;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefersh;
        private System.Windows.Forms.FlowLayoutPanel flpPhoneCate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.TextBox txtNamePhone;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIdItemPhone;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.FlowLayoutPanel flpBill;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayMone;
        private System.Windows.Forms.TextBox txtIdNewBill;
    }
}