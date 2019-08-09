namespace TheCarsApplication
{
    partial class FrmEditCar
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
            this.lblEditCar = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblCarMakeAndModel = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.btnEReturn = new System.Windows.Forms.Button();
            this.btnEClearForm = new System.Windows.Forms.Button();
            this.btnESaveCar = new System.Windows.Forms.Button();
            this.txtEComment = new System.Windows.Forms.TextBox();
            this.txtELastService = new System.Windows.Forms.TextBox();
            this.txtECarFuel = new System.Windows.Forms.TextBox();
            this.txtECarReg = new System.Windows.Forms.TextBox();
            this.txtECarMakeAndModel = new System.Windows.Forms.TextBox();
            this.txtECarID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEditCar
            // 
            this.lblEditCar.AutoSize = true;
            this.lblEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEditCar.Location = new System.Drawing.Point(147, 21);
            this.lblEditCar.Name = "lblEditCar";
            this.lblEditCar.Size = new System.Drawing.Size(82, 25);
            this.lblEditCar.TabIndex = 10;
            this.lblEditCar.Text = "Edit Car";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblComments.Location = new System.Drawing.Point(20, 325);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(113, 25);
            this.lblComments.TabIndex = 30;
            this.lblComments.Text = "Comments:";
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblServiceDate.Location = new System.Drawing.Point(20, 270);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(169, 25);
            this.lblServiceDate.TabIndex = 29;
            this.lblServiceDate.Text = "Last Serviced On:";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFuelType.Location = new System.Drawing.Point(20, 215);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(106, 25);
            this.lblFuelType.TabIndex = 28;
            this.lblFuelType.Text = "Fuel Type:";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegistration.Location = new System.Drawing.Point(20, 160);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(166, 25);
            this.lblRegistration.TabIndex = 27;
            this.lblRegistration.Text = "Registration Num:";
            // 
            // lblCarMakeAndModel
            // 
            this.lblCarMakeAndModel.AutoSize = true;
            this.lblCarMakeAndModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCarMakeAndModel.Location = new System.Drawing.Point(20, 102);
            this.lblCarMakeAndModel.Name = "lblCarMakeAndModel";
            this.lblCarMakeAndModel.Size = new System.Drawing.Size(204, 25);
            this.lblCarMakeAndModel.TabIndex = 26;
            this.lblCarMakeAndModel.Text = "Car Make And Model:";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCarID.Location = new System.Drawing.Point(20, 47);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(74, 25);
            this.lblCarID.TabIndex = 25;
            this.lblCarID.Text = "Car ID:";
            // 
            // btnEReturn
            // 
            this.btnEReturn.Location = new System.Drawing.Point(262, 399);
            this.btnEReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnEReturn.Name = "btnEReturn";
            this.btnEReturn.Size = new System.Drawing.Size(100, 28);
            this.btnEReturn.TabIndex = 24;
            this.btnEReturn.Text = "Return";
            this.btnEReturn.UseVisualStyleBackColor = true;
            this.btnEReturn.Click += new System.EventHandler(this.btnEReturn_Click);
            // 
            // btnEClearForm
            // 
            this.btnEClearForm.Location = new System.Drawing.Point(136, 399);
            this.btnEClearForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnEClearForm.Name = "btnEClearForm";
            this.btnEClearForm.Size = new System.Drawing.Size(100, 28);
            this.btnEClearForm.TabIndex = 23;
            this.btnEClearForm.Text = "Clear Form";
            this.btnEClearForm.UseVisualStyleBackColor = true;
            this.btnEClearForm.Click += new System.EventHandler(this.btnEClearForm_Click);
            // 
            // btnESaveCar
            // 
            this.btnESaveCar.Location = new System.Drawing.Point(12, 399);
            this.btnESaveCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnESaveCar.Name = "btnESaveCar";
            this.btnESaveCar.Size = new System.Drawing.Size(100, 28);
            this.btnESaveCar.TabIndex = 22;
            this.btnESaveCar.Text = "Save Car";
            this.btnESaveCar.UseVisualStyleBackColor = true;
            this.btnESaveCar.Click += new System.EventHandler(this.btnESaveCar_Click);
            // 
            // txtEComment
            // 
            this.txtEComment.Location = new System.Drawing.Point(25, 354);
            this.txtEComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtEComment.Name = "txtEComment";
            this.txtEComment.Size = new System.Drawing.Size(337, 22);
            this.txtEComment.TabIndex = 21;
            // 
            // txtELastService
            // 
            this.txtELastService.Location = new System.Drawing.Point(25, 299);
            this.txtELastService.Margin = new System.Windows.Forms.Padding(4);
            this.txtELastService.Name = "txtELastService";
            this.txtELastService.Size = new System.Drawing.Size(161, 22);
            this.txtELastService.TabIndex = 20;
            // 
            // txtECarFuel
            // 
            this.txtECarFuel.Location = new System.Drawing.Point(25, 244);
            this.txtECarFuel.Margin = new System.Windows.Forms.Padding(4);
            this.txtECarFuel.Name = "txtECarFuel";
            this.txtECarFuel.Size = new System.Drawing.Size(132, 22);
            this.txtECarFuel.TabIndex = 19;
            // 
            // txtECarReg
            // 
            this.txtECarReg.Location = new System.Drawing.Point(25, 189);
            this.txtECarReg.Margin = new System.Windows.Forms.Padding(4);
            this.txtECarReg.Name = "txtECarReg";
            this.txtECarReg.Size = new System.Drawing.Size(164, 22);
            this.txtECarReg.TabIndex = 18;
            // 
            // txtECarMakeAndModel
            // 
            this.txtECarMakeAndModel.Location = new System.Drawing.Point(25, 134);
            this.txtECarMakeAndModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtECarMakeAndModel.Name = "txtECarMakeAndModel";
            this.txtECarMakeAndModel.Size = new System.Drawing.Size(211, 22);
            this.txtECarMakeAndModel.TabIndex = 17;
            // 
            // txtECarID
            // 
            this.txtECarID.Location = new System.Drawing.Point(25, 76);
            this.txtECarID.Margin = new System.Windows.Forms.Padding(4);
            this.txtECarID.Name = "txtECarID";
            this.txtECarID.Size = new System.Drawing.Size(132, 22);
            this.txtECarID.TabIndex = 16;
            // 
            // FrmEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 437);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblServiceDate);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.lblCarMakeAndModel);
            this.Controls.Add(this.lblCarID);
            this.Controls.Add(this.btnEReturn);
            this.Controls.Add(this.btnEClearForm);
            this.Controls.Add(this.btnESaveCar);
            this.Controls.Add(this.txtEComment);
            this.Controls.Add(this.txtELastService);
            this.Controls.Add(this.txtECarFuel);
            this.Controls.Add(this.txtECarReg);
            this.Controls.Add(this.txtECarMakeAndModel);
            this.Controls.Add(this.txtECarID);
            this.Controls.Add(this.lblEditCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditCar";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditCar;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblCarMakeAndModel;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.Button btnEReturn;
        private System.Windows.Forms.Button btnEClearForm;
        private System.Windows.Forms.Button btnESaveCar;
        private System.Windows.Forms.TextBox txtEComment;
        private System.Windows.Forms.TextBox txtELastService;
        private System.Windows.Forms.TextBox txtECarFuel;
        private System.Windows.Forms.TextBox txtECarReg;
        private System.Windows.Forms.TextBox txtECarMakeAndModel;
        private System.Windows.Forms.TextBox txtECarID;
    }
}