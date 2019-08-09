namespace TheCarsApplication
{
    partial class FrmAddCar
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
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarMakeAndModel = new System.Windows.Forms.TextBox();
            this.txtCarReg = new System.Windows.Forms.TextBox();
            this.txtCarFuel = new System.Windows.Forms.TextBox();
            this.txtLastService = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblCreateCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(27, 89);
            this.txtCarID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(132, 22);
            this.txtCarID.TabIndex = 0;
            // 
            // txtCarMakeAndModel
            // 
            this.txtCarMakeAndModel.Location = new System.Drawing.Point(27, 146);
            this.txtCarMakeAndModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarMakeAndModel.Name = "txtCarMakeAndModel";
            this.txtCarMakeAndModel.Size = new System.Drawing.Size(211, 22);
            this.txtCarMakeAndModel.TabIndex = 1;
            // 
            // txtCarReg
            // 
            this.txtCarReg.Location = new System.Drawing.Point(27, 202);
            this.txtCarReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(164, 22);
            this.txtCarReg.TabIndex = 2;
            // 
            // txtCarFuel
            // 
            this.txtCarFuel.Location = new System.Drawing.Point(27, 257);
            this.txtCarFuel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarFuel.Name = "txtCarFuel";
            this.txtCarFuel.Size = new System.Drawing.Size(132, 22);
            this.txtCarFuel.TabIndex = 3;
            // 
            // txtLastService
            // 
            this.txtLastService.Location = new System.Drawing.Point(27, 313);
            this.txtLastService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastService.Name = "txtLastService";
            this.txtLastService.Size = new System.Drawing.Size(161, 22);
            this.txtLastService.TabIndex = 4;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(27, 367);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(337, 22);
            this.txtComment.TabIndex = 5;
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.Location = new System.Drawing.Point(13, 412);
            this.btnSaveCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(100, 28);
            this.btnSaveCar.TabIndex = 6;
            this.btnSaveCar.Text = "Save Car";
            this.btnSaveCar.UseVisualStyleBackColor = true;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(137, 412);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(100, 28);
            this.btnClearForm.TabIndex = 7;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(263, 412);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 28);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblCreateCar
            // 
            this.lblCreateCar.AutoSize = true;
            this.lblCreateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreateCar.Location = new System.Drawing.Point(121, 21);
            this.lblCreateCar.Name = "lblCreateCar";
            this.lblCreateCar.Size = new System.Drawing.Size(152, 25);
            this.lblCreateCar.TabIndex = 9;
            this.lblCreateCar.Text = "Create New Car";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Car ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Car Make And Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Registration Num:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(21, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fuel Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(21, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Last Serviced On:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(21, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Comments:";
            // 
            // FrmAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 452);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreateCar);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnSaveCar);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtLastService);
            this.Controls.Add(this.txtCarFuel);
            this.Controls.Add(this.txtCarReg);
            this.Controls.Add(this.txtCarMakeAndModel);
            this.Controls.Add(this.txtCarID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAddCar";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarMakeAndModel;
        private System.Windows.Forms.TextBox txtCarReg;
        private System.Windows.Forms.TextBox txtCarFuel;
        private System.Windows.Forms.TextBox txtLastService;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblCreateCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}