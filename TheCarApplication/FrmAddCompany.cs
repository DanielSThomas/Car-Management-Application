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

namespace TheCarsApplication
{
    public partial class FrmAddCompany : Form
    {
        // Initialization///////////////////////////////////////////////////////////
        public FrmAddCompany()
        {
            InitializeComponent();
        }

        //Methods///////////////////////////////////////////////////////////////////
        private void SaveCompany()
        {
            string companyID = Convert.ToString(txtCompanyID.Text);
            string companyName = Convert.ToString(txtCompanyName.Text);
            string companyAddress = Convert.ToString(txtCompanyAddress.Text);
            string companyPost = Convert.ToString(txtCompanyPostCode.Text);

            ArrayList blankcararray = new ArrayList();

            Company customCompany = new Company(companyID, companyName, companyAddress, companyPost, Convert.ToString(0), blankcararray);

            MainForm.companyArray.Add(customCompany);
        }

        //Inputs////////////////////////////////////////////////////////////////////
        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            SaveCompany();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtCompanyID.Text = null;
            txtCompanyName.Text = null;
            txtCompanyAddress.Text = null;
            txtCompanyPostCode.Text = null;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.formkeepinfo.Show();
        }
        
    }
}
