using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;


namespace TheCarsApplication
{
    public partial class FrmEditCar : Form
    {
        // Initialization///////////////////////////////////////////////////////////
        public FrmEditCar()
        {
            InitializeComponent();
            ReadInCarData();
        }

        //Methods///////////////////////////////////////////////////////////////////
        private void ReadInCarData()
        {
            //local copies
            Company currentCompany = (Company)MainForm.companyArray[MainForm.selectedCompany];
            Car currentCar = (Car)currentCompany.getcarDetails()[MainForm.selectedCar];

            //Read in from Main
            txtECarID.Text = currentCar.getcarID();
            txtECarMakeAndModel.Text = currentCar.getCarMakeAndModel();
            txtECarReg.Text = currentCar.getcarReg();
            txtECarFuel.Text = currentCar.getcarFuel();
            txtELastService.Text = currentCar.getcarServiced();
            txtEComment.Text = currentCar.getcomment();
        }
        private void SaveCar02()
        {
            Company currentCompany = (Company)MainForm.companyArray[MainForm.selectedCompany];

            //Read Text Fields
            string carId = txtECarID.Text;
            string carMakeAndModel = txtECarMakeAndModel.Text;
            string carRegistration = txtECarReg.Text;
            string carFuelType = txtECarFuel.Text;
            string carServiceDate = txtELastService.Text;
            string carComments = txtEComment.Text;
            //Create Car

            Car customcar = new Car(carId, carMakeAndModel, carRegistration, carFuelType, carServiceDate, carComments);

            //Find Current Car and replace
            currentCompany.getcarDetails()[MainForm.selectedCar] = customcar;
            //Recreate file
            MainForm.RecreateFile(MainForm.companyArray);
        }


        //Inputs////////////////////////////////////////////////////////////////////
        private void btnEReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.formkeepinfo.Show();
            
        }

        private void btnEClearForm_Click(object sender, EventArgs e)
        {
            txtECarID.Text = null;
            txtECarMakeAndModel.Text = null;
            txtECarReg.Text = null;
            txtECarFuel.Text = null;
            txtELastService.Text = null;
            txtEComment.Text = null;
        }

        private void btnESaveCar_Click(object sender, EventArgs e)
        {
            SaveCar02();
        }
                           
        
    }
}
