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
    public partial class FrmAddCar : Form
    {
        public FrmAddCar()
        {
            InitializeComponent();
        }


        private void SaveCar()
        {
            //my local copy of the company
            Company tempCompany = (Company)MainForm.companyArray[MainForm.selectedCompany];


            //get car details from form
            string carId = Convert.ToString(txtCarID.Text);
            string carMakeAndModel = Convert.ToString(txtCarMakeAndModel.Text);
            string carRegistration = Convert.ToString(txtCarReg.Text);
            string carFuelType = Convert.ToString(txtCarFuel.Text);
            string carServiceDate = Convert.ToString(txtLastService.Text);
            string carComments = Convert.ToString(txtComment.Text);

            //create car
            Car customcar = new Car(carId, carMakeAndModel, carRegistration, carFuelType, carServiceDate, carComments);

            tempCompany.getcarDetails().Add(customcar);

            //Update Company Number of Cars
            int NumberOfCars = 1 + Convert.ToInt32(tempCompany.getnumberOfCars());
            tempCompany.setnumOfCars(Convert.ToString(NumberOfCars));

            MainForm.companyArray[MainForm.selectedCompany] = tempCompany;

            MainForm.RecreateFile(MainForm.companyArray);
        }

        //Inputs////////////////////////////////////////////////////////////////////
        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            SaveCar();         
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtCarID.Text = null;
            txtCarMakeAndModel.Text = null;
            txtCarReg.Text = null;
            txtCarFuel.Text = null;
            txtLastService.Text = null;
            txtComment.Text = null;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.formkeepinfo.Show();
        }

        private void txtCarID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

