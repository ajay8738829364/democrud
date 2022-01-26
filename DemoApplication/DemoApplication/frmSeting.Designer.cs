namespace InventoryManagementSystem
{
    partial class frmSeting
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
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtSever = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUID = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.ItCB = new System.Windows.Forms.CheckBox();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.ItCB);
            this.leftPanel.Controls.Add(this.btnConnect);
            this.leftPanel.Controls.Add(this.txtPass);
            this.leftPanel.Controls.Add(this.lblPass);
            this.leftPanel.Controls.Add(this.txtUserId);
            this.leftPanel.Controls.Add(this.lblUID);
            this.leftPanel.Controls.Add(this.txtDB);
            this.leftPanel.Controls.Add(this.lblDB);
            this.leftPanel.Controls.Add(this.txtSever);
            this.leftPanel.Controls.Add(this.lblServerName);
            this.leftPanel.Size = new System.Drawing.Size(255, 476);
            this.leftPanel.Controls.SetChildIndex(this.topLeftPanle, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblServerName, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtSever, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblDB, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtDB, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblUID, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtUserId, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblPass, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtPass, 0);
            this.leftPanel.Controls.SetChildIndex(this.btnConnect, 0);
            this.leftPanel.Controls.SetChildIndex(this.ItCB, 0);
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(750, 63);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(14, 146);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(95, 18);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "Server Name";
            // 
            // txtSever
            // 
            this.txtSever.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSever.Location = new System.Drawing.Point(17, 166);
            this.txtSever.Name = "txtSever";
            this.txtSever.Size = new System.Drawing.Size(222, 24);
            this.txtSever.TabIndex = 2;
            // 
            // txtDB
            // 
            this.txtDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDB.Location = new System.Drawing.Point(17, 212);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(222, 24);
            this.txtDB.TabIndex = 4;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.Location = new System.Drawing.Point(14, 192);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(73, 18);
            this.lblDB.TabIndex = 3;
            this.lblDB.Text = "DataBase";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(17, 259);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(222, 24);
            this.txtUserId.TabIndex = 6;
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUID.Location = new System.Drawing.Point(14, 239);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(55, 18);
            this.lblUID.TabIndex = 5;
            this.lblUID.Text = "User Id";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(17, 306);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(222, 24);
            this.txtPass.TabIndex = 8;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(14, 286);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(75, 18);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(17, 368);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(222, 34);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItCB
            // 
            this.ItCB.AutoSize = true;
            this.ItCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItCB.Location = new System.Drawing.Point(17, 336);
            this.ItCB.Name = "ItCB";
            this.ItCB.Size = new System.Drawing.Size(148, 22);
            this.ItCB.TabIndex = 10;
            this.ItCB.Text = "Integrated Security";
            this.ItCB.UseVisualStyleBackColor = true;
            this.ItCB.CheckedChanged += new System.EventHandler(this.ItCB_CheckedChanged);
            // 
            // frmSeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 476);
            this.ControlBox = false;
            this.Name = "frmSeting";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmSeting_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.TextBox txtSever;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.CheckBox ItCB;
    }
}