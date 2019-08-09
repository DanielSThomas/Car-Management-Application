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
    public partial class FrmEditCompany : Form
    {
        // Initialization///////////////////////////////////////////////////////////
        public FrmEditCompany()
        {
            InitializeComponent();
            ReadInCompanyData();
        }

        //Methods///////////////////////////////////////////////////////////////////
        private void ReadInCompanyData()
        {
            //local copies

            Company currentCompany = (Company)MainForm.companyArray[MainForm.selectedCompany];

            //Read in from Main
            txtCompanyID.Text = currentCompany.getidNumber();
            txtCompanyName.Text = currentCompany.getname();
            txtCompanyAddress.Text = currentCompany.getaddress();
            txtCompanyPostCode.Text = currentCompany.getpostCode();

        }


        private void SaveCompany02()
        {
            Company currentCompany = (Company)MainForm.companyArray[MainForm.selectedCompany];


            //get num of cars
            string companyNumberOfCars = currentCompany.getnumberOfCars();

            //Read Text Fields
            string companyID = txtCompanyID.Text;
            string companyName = txtCompanyName.Text;
            string companyAddress = txtCompanyAddress.Text;
            string companyPostCode = txtCompanyPostCode.Text;
            ArrayList newCarArray = currentCompany.getcarDetails();

            //Create company

            Company customCompany = new Company(companyID, companyName, companyAddress, companyPostCode, companyNumberOfCars, newCarArray);

            //Find Current company and replace (not currently working)


            MainForm.companyArray[MainForm.selectedCompany] = customCompany;


            //Recreate file
            MainForm.RecreateFile(MainForm.companyArray);
        }
      
        //Inputs////////////////////////////////////////////////////////////////////

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            SaveCompany02();
        }
    
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.formkeepinfo.Show();        
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtCompanyID.Text = null;
            txtCompanyName.Text = null;
            txtCompanyAddress.Text = null;
            txtCompanyPostCode.Text = null;
        }
    }
}
