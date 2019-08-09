namespace TheCarsApplication
{
    partial class MainForm
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
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.ltbCar = new System.Windows.Forms.ListBox();
            this.ltbGarage = new System.Windows.Forms.ListBox();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnCreateCompany = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.txtSearchGarage = new System.Windows.Forms.TextBox();
            this.txtCarSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.lblTempText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(23, 289);
            this.btnCreateCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(87, 44);
            this.btnCreateCar.TabIndex = 2;
            this.btnCreateCar.Text = "Create New Car";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(23, 336);
            this.btnEditCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(87, 44);
            this.btnEditCar.TabIndex = 3;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(23, 384);
            this.btnDeleteCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(87, 44);
            this.btnDeleteCar.TabIndex = 4;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // ltbCar
            // 
            this.ltbCar.FormattingEnabled = true;
            this.ltbCar.Location = new System.Drawing.Point(115, 289);
            this.ltbCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ltbCar.Name = "ltbCar";
            this.ltbCar.Size = new System.Drawing.Size(800, 147);
            this.ltbCar.TabIndex = 5;
            this.ltbCar.SelectedIndexChanged += new System.EventHandler(this.ltbCar_SelectedIndexChanged);
            // 
            // ltbGarage
            // 
            this.ltbGarage.FormattingEnabled = true;
            this.ltbGarage.Location = new System.Drawing.Point(116, 109);
            this.ltbGarage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ltbGarage.Name = "ltbGarage";
            this.ltbGarage.Size = new System.Drawing.Size(799, 147);
            this.ltbGarage.TabIndex = 7;
            this.ltbGarage.SelectedIndexChanged += new System.EventHandler(this.ltbGarage_SelectedIndexChanged);
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(24, 109);
            this.btnCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(87, 44);
            this.btnCompany.TabIndex = 8;
            this.btnCompany.Text = "Reload Companies";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnGarage_Click);
            // 
            // btnCreateCompany
            // 
            this.btnCreateCompany.Location = new System.Drawing.Point(23, 156);
            this.btnCreateCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateCompany.Name = "btnCreateCompany";
            this.btnCreateCompany.Size = new System.Drawing.Size(87, 44);
            this.btnCreateCompany.TabIndex = 9;
            this.btnCreateCompany.Text = "Create New Company";
            this.btnCreateCompany.UseVisualStyleBackColor = true;
            this.btnCreateCompany.Click += new System.EventHandler(this.btnCreateCompany_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Location = new System.Drawing.Point(23, 203);
            this.btnEditCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(87, 44);
            this.btnEditCompany.TabIndex = 10;
            this.btnEditCompany.Text = "Edit Company";
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // txtSearchGarage
            // 
            this.txtSearchGarage.Location = new System.Drawing.Point(372, 84);
            this.txtSearchGarage.Name = "txtSearchGarage";
            this.txtSearchGarage.Size = new System.Drawing.Size(409, 20);
            this.txtSearchGarage.TabIndex = 11;
            this.txtSearchGarage.TextChanged += new System.EventHandler(this.txtSearchGarage_TextChanged);
            // 
            // txtCarSearch
            // 
            this.txtCarSearch.Location = new System.Drawing.Point(372, 263);
            this.txtCarSearch.Name = "txtCarSearch";
            this.txtCarSearch.Size = new System.Drawing.Size(409, 20);
            this.txtCarSearch.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.Location = new System.Drawing.Point(236, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(473, 46);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Local Garage Companies";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblSub.Location = new System.Drawing.Point(529, 54);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(275, 22);
            this.lblSub.TabIndex = 14;
            this.lblSub.Text = "Find Companies, Cars And More.";
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(785, 83);
            this.btnSearch1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(128, 22);
            this.btnSearch1.TabIndex = 17;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(785, 262);
            this.btnSearch2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(128, 22);
            this.btnSearch2.TabIndex = 18;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // lblTempText
            // 
            this.lblTempText.AutoSize = true;
            this.lblTempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTempText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTempText.Location = new System.Drawing.Point(21, 85);
            this.lblTempText.Name = "lblTempText";
            this.lblTempText.Size = new System.Drawing.Size(345, 15);
            this.lblTempText.TabIndex = 19;
            this.lblTempText.Text = "Search: CompanyName, ID, Address , Post or Number of Cars:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search: Car Regestration, ID or The date the car was serviced:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTempText);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtCarSearch);
            this.Controls.Add(this.txtSearchGarage);
            this.Controls.Add(this.btnEditCompany);
            this.Controls.Add(this.btnCreateCompany);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.ltbGarage);
            this.Controls.Add(this.ltbCar);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnCreateCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Shown += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.ListBox ltbCar;
        private System.Windows.Forms.ListBox ltbGarage;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnCreateCompany;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.TextBox txtSearchGarage;
        private System.Windows.Forms.TextBox txtCarSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Label lblTempText;
        private System.Windows.Forms.Label label1;
    }
}

