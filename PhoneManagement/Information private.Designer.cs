namespace PhoneManagement
{
    partial class frmInformationPrivate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIPExit = new System.Windows.Forms.Button();
            this.btnIPUpdate = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIPReEnterPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtIPNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIPDisplayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIPPassword = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIPUserName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIPExit);
            this.panel1.Controls.Add(this.btnIPUpdate);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(103, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 367);
            this.panel1.TabIndex = 2;
            // 
            // btnIPExit
            // 
            this.btnIPExit.AccessibleName = "";
            this.btnIPExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIPExit.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPExit.Location = new System.Drawing.Point(409, 322);
            this.btnIPExit.Name = "btnIPExit";
            this.btnIPExit.Size = new System.Drawing.Size(75, 42);
            this.btnIPExit.TabIndex = 5;
            this.btnIPExit.Text = "Exit";
            this.btnIPExit.UseVisualStyleBackColor = true;
            this.btnIPExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnIPUpdate
            // 
            this.btnIPUpdate.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPUpdate.Location = new System.Drawing.Point(328, 322);
            this.btnIPUpdate.Name = "btnIPUpdate";
            this.btnIPUpdate.Size = new System.Drawing.Size(75, 42);
            this.btnIPUpdate.TabIndex = 3;
            this.btnIPUpdate.Text = "Update";
            this.btnIPUpdate.UseVisualStyleBackColor = true;
            this.btnIPUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtIPReEnterPass);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(3, 261);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(496, 55);
            this.panel6.TabIndex = 4;
            // 
            // txtIPReEnterPass
            // 
            this.txtIPReEnterPass.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F);
            this.txtIPReEnterPass.Location = new System.Drawing.Point(202, 15);
            this.txtIPReEnterPass.Name = "txtIPReEnterPass";
            this.txtIPReEnterPass.Size = new System.Drawing.Size(279, 27);
            this.txtIPReEnterPass.TabIndex = 1;
            this.txtIPReEnterPass.UseSystemPasswordChar = true;
            this.txtIPReEnterPass.TextChanged += new System.EventHandler(this.txbReEnterPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Write Password again:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtIPNewPassword);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(496, 55);
            this.panel5.TabIndex = 3;
            // 
            // txtIPNewPassword
            // 
            this.txtIPNewPassword.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F);
            this.txtIPNewPassword.Location = new System.Drawing.Point(202, 17);
            this.txtIPNewPassword.Name = "txtIPNewPassword";
            this.txtIPNewPassword.Size = new System.Drawing.Size(279, 27);
            this.txtIPNewPassword.TabIndex = 1;
            this.txtIPNewPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "New\'s Password:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtIPDisplayName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(496, 55);
            this.panel4.TabIndex = 2;
            // 
            // txtIPDisplayName
            // 
            this.txtIPDisplayName.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F);
            this.txtIPDisplayName.Location = new System.Drawing.Point(202, 15);
            this.txtIPDisplayName.Name = "txtIPDisplayName";
            this.txtIPDisplayName.Size = new System.Drawing.Size(279, 27);
            this.txtIPDisplayName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display\'s name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtIPPassword);
            this.panel3.Controls.Add(this.txbPassword);
            this.panel3.Location = new System.Drawing.Point(3, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 55);
            this.panel3.TabIndex = 1;
            // 
            // txtIPPassword
            // 
            this.txtIPPassword.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F);
            this.txtIPPassword.Location = new System.Drawing.Point(202, 17);
            this.txtIPPassword.Name = "txtIPPassword";
            this.txtIPPassword.Size = new System.Drawing.Size(279, 27);
            this.txtIPPassword.TabIndex = 1;
            this.txtIPPassword.UseSystemPasswordChar = true;
            // 
            // txbPassword
            // 
            this.txbPassword.AutoSize = true;
            this.txbPassword.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.txbPassword.Location = new System.Drawing.Point(3, 16);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(89, 16);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.Text = "Password:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtIPUserName);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 55);
            this.panel2.TabIndex = 0;
            // 
            // txtIPUserName
            // 
            this.txtIPUserName.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPUserName.Location = new System.Drawing.Point(202, 15);
            this.txtIPUserName.Name = "txtIPUserName";
            this.txtIPUserName.ReadOnly = true;
            this.txtIPUserName.Size = new System.Drawing.Size(279, 27);
            this.txtIPUserName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(3, 16);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(89, 16);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(495, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "INFORMATION PRIVATE";
            // 
            // frmInformationPrivate
            // 
            this.AcceptButton = this.btnIPUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIPExit;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "frmInformationPrivate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information private";
            this.Load += new System.EventHandler(this.frmInformationPrivate_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIPExit;
        private System.Windows.Forms.Button btnIPUpdate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIPReEnterPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtIPNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIPDisplayName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtIPPassword;
        private System.Windows.Forms.Label txbPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIPUserName;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label label4;
    }
}