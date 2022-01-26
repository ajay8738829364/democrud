namespace InventoryManagementSystem
{
    partial class frmUsers
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblUserNameError = new System.Windows.Forms.Label();
            this.lblPassError = new System.Windows.Forms.Label();
            this.lblphoneError = new System.Windows.Forms.Label();
            this.lblMailError = new System.Windows.Forms.Label();
            this.userDataGrid = new System.Windows.Forms.DataGridView();
            this.UserIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridPnl.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.topLeftPanle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // topLeftpanel2
            // 
            this.topLeftpanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.topLeftpanel2.Dock = System.Windows.Forms.DockStyle.None;
            this.topLeftpanel2.Location = new System.Drawing.Point(3, 69);
            this.topLeftpanel2.Size = new System.Drawing.Size(252, 44);
            // 
            // dataGridPnl
            // 
            this.dataGridPnl.Controls.Add(this.userDataGrid);
            this.dataGridPnl.Size = new System.Drawing.Size(762, 383);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.txtEmail);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.txtPhone);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.txtPassword);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.txtUserName);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.txtName);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.lblNameError);
            this.leftPanel.Controls.Add(this.lblUserNameError);
            this.leftPanel.Controls.Add(this.lblPassError);
            this.leftPanel.Controls.Add(this.lblphoneError);
            this.leftPanel.Controls.Add(this.lblMailError);
            this.leftPanel.Size = new System.Drawing.Size(255, 496);
            this.leftPanel.Controls.SetChildIndex(this.lblMailError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblphoneError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblPassError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblUserNameError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblNameError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtName, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtUserName, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtPassword, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtPhone, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtEmail, 0);
            this.leftPanel.Controls.SetChildIndex(this.topLeftpanel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.topLeftPanle, 0);
            // 
            // topLeftPanle
            // 
            this.topLeftPanle.Size = new System.Drawing.Size(255, 57);
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(762, 63);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(132, 0);
            this.label1.Size = new System.Drawing.Size(123, 57);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 329);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "E-mail";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(15, 288);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(227, 20);
            this.txtPhone.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Phone (+91XXXXXXXX)";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 247);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(227, 20);
            this.txtPassword.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(13, 203);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(227, 20);
            this.txtUserName.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "User Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 164);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNameError.Location = new System.Drawing.Point(81, 148);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(20, 25);
            this.lblNameError.TabIndex = 32;
            this.lblNameError.Text = "*";
            this.lblNameError.Visible = false;
            // 
            // lblUserNameError
            // 
            this.lblUserNameError.AutoSize = true;
            this.lblUserNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserNameError.Location = new System.Drawing.Point(81, 187);
            this.lblUserNameError.Name = "lblUserNameError";
            this.lblUserNameError.Size = new System.Drawing.Size(20, 25);
            this.lblUserNameError.TabIndex = 33;
            this.lblUserNameError.Text = "*";
            this.lblUserNameError.Visible = false;
            // 
            // lblPassError
            // 
            this.lblPassError.AutoSize = true;
            this.lblPassError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPassError.Location = new System.Drawing.Point(81, 231);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(20, 25);
            this.lblPassError.TabIndex = 34;
            this.lblPassError.Text = "*";
            this.lblPassError.Visible = false;
            // 
            // lblphoneError
            // 
            this.lblphoneError.AutoSize = true;
            this.lblphoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblphoneError.Location = new System.Drawing.Point(144, 270);
            this.lblphoneError.Name = "lblphoneError";
            this.lblphoneError.Size = new System.Drawing.Size(20, 25);
            this.lblphoneError.TabIndex = 35;
            this.lblphoneError.Text = "*";
            this.lblphoneError.Visible = false;
            // 
            // lblMailError
            // 
            this.lblMailError.AutoSize = true;
            this.lblMailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMailError.Location = new System.Drawing.Point(81, 313);
            this.lblMailError.Name = "lblMailError";
            this.lblMailError.Size = new System.Drawing.Size(20, 25);
            this.lblMailError.TabIndex = 36;
            this.lblMailError.Text = "*";
            this.lblMailError.Visible = false;
            // 
            // userDataGrid
            // 
            this.userDataGrid.AllowUserToAddRows = false;
            this.userDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.userDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.userDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIdGV,
            this.NameGV,
            this.UserNameGV,
            this.PasswordGV,
            this.PhoneGV,
            this.EmailGV,
            this.statusGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.userDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGrid.Location = new System.Drawing.Point(0, 0);
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userDataGrid.RowHeadersVisible = false;
            this.userDataGrid.Size = new System.Drawing.Size(762, 383);
            this.userDataGrid.TabIndex = 7;
            // 
            // UserIdGV
            // 
            this.UserIdGV.HeaderText = "UserId";
            this.UserIdGV.Name = "UserIdGV";
            this.UserIdGV.ReadOnly = true;
            this.UserIdGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // UserNameGV
            // 
            this.UserNameGV.HeaderText = "UserName";
            this.UserNameGV.Name = "UserNameGV";
            this.UserNameGV.ReadOnly = true;
            // 
            // PasswordGV
            // 
            this.PasswordGV.HeaderText = "Password";
            this.PasswordGV.Name = "PasswordGV";
            this.PasswordGV.ReadOnly = true;
            this.PasswordGV.Visible = false;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone";
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // EmailGV
            // 
            this.EmailGV.HeaderText = "E-mail";
            this.EmailGV.Name = "EmailGV";
            this.EmailGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 496);
            this.Name = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.dataGridPnl.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.topLeftPanle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblUserNameError;
        private System.Windows.Forms.Label lblPassError;
        private System.Windows.Forms.Label lblphoneError;
        private System.Windows.Forms.Label lblMailError;
        private System.Windows.Forms.DataGridView userDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;


    }
}