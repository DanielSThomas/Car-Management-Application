namespace TheCarsApplication
{
    partial class FrmAddCompany
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
            this.lblCompanyPost = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.lblCreateCompany = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnSaveCompany = new System.Windows.Forms.Button();
            this.txtCompanyPostCode = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCompanyPost
            // 
            this.lblCompanyPost.AutoSize = true;
            this.lblCompanyPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCompanyPost.Location = new System.Drawing.Point(21, 216);
            this.lblCompanyPost.Name = "lblCompanyPost";
            this.lblCompanyPost.Size = new System.Drawing.Size(195, 25);
            this.lblCompanyPost.TabIndex = 29;
            this.lblCompanyPost.Text = "Company PostCode:";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCompanyAddress.Location = new System.Drawing.Point(21, 161);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(181, 25);
            this.lblCompanyAddress.TabIndex = 28;
            this.lblCompanyAddress.Text = "Company Address:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCompanyName.Location = new System.Drawing.Point(21, 103);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(160, 25);
            this.lblCompanyName.TabIndex = 27;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCompanyID.Location = new System.Drawing.Point(21, 48);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(127, 25);
            this.lblCompanyID.TabIndex = 26;
            this.lblCompanyID.Text = "Company ID:";
            // 
            // lblCreateCompany
            // 
            this.lblCreateCompany.AutoSize = true;
            this.lblCreateCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreateCompany.Location = new System.Drawing.Point(105, 9);
            this.lblCreateCompany.Name = "lblCreateCompany";
            this.lblCreateCompany.Size = new System.Drawing.Size(205, 25);
            this.lblCreateCompany.TabIndex = 25;
            this.lblCreateCompany.Text = "Create New Company";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(264, 290);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 28);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(152, 290);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(100, 28);
            this.btnClearForm.TabIndex = 23;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.Location = new System.Drawing.Point(23, 290);
            this.btnSaveCompany.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(116, 28);
            this.btnSaveCompany.TabIndex = 22;
            this.btnSaveCompany.Text = "Save Company";
            this.btnSaveCompany.UseVisualStyleBackColor = true;
            this.btnSaveCompany.Click += new System.EventHandler(this.btnSaveCompany_Click);
            // 
            // txtCompanyPostCode
            // 
            this.txtCompanyPostCode.Location = new System.Drawing.Point(26, 245);
            this.txtCompanyPostCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyPostCode.Name = "txtCompanyPostCode";
            this.txtCompanyPostCode.Size = new System.Drawing.Size(132, 22);
            this.txtCompanyPostCode.TabIndex = 19;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(26, 190);
            this.txtCompanyAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(164, 22);
            this.txtCompanyAddress.TabIndex = 18;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(26, 135);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(211, 22);
            this.txtCompanyName.TabIndex = 17;
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(26, 77);
            this.txtCompanyID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(132, 22);
            this.txtCompanyID.TabIndex = 16;
            // 
            // FrmAddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 345);
            this.Controls.Add(this.lblCompanyPost);
            this.Controls.Add(this.lblCompanyAddress);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCompanyID);
            this.Controls.Add(this.lblCreateCompany);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnSaveCompany);
            this.Controls.Add(this.txtCompanyPostCode);
            this.Controls.Add(this.txtCompanyAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtCompanyID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddCompany";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCompanyPost;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.Label lblCreateCompany;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnSaveCompany;
        private System.Windows.Forms.TextBox txtCompanyPostCode;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCompanyID;
    }
}