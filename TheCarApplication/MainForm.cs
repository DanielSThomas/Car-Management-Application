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
    public partial class MainForm : Form 
    {
        //Global Variables///////////////////////////////////////////////////////////
        public static MainForm formkeepinfo = null;
        public static ArrayList carArray = new ArrayList();
        public static ArrayList companyArray = new ArrayList();
        public static int selectedCompany = 0;
        public static int selectedCar = 0;
        public static string filePath;


        // Initialization///////////////////////////////////////////////////////////
        public MainForm() 
        {
            SelectFile();
            InitializeComponent();
            formkeepinfo = this;
            LoadCompanies();
            CheckCompanies();
            CheckInfo();
            ltbGarage.SelectedIndex = 0;
            ltbCar.SelectedIndex = 0;
        }


        //Methods///////////////////////////////////////////////////////////////////
        public static void RecreateFile(ArrayList companies) // Recreate File
        {
            StreamWriter outputcars = new StreamWriter(filePath);

            foreach (Company currentCompany in companies)
            {
                outputcars.WriteLine(currentCompany.getidNumber());
                outputcars.WriteLine(currentCompany.getname());
                outputcars.WriteLine(currentCompany.getaddress());
                outputcars.WriteLine(currentCompany.getpostCode());
                outputcars.WriteLine(currentCompany.getnumberOfCars());




                foreach (Car currentCar in currentCompany.getcarDetails())
                {
                    outputcars.WriteLine(currentCar.getcarID());
                    outputcars.WriteLine(currentCar.getCarMakeAndModel());
                    outputcars.WriteLine(currentCar.getcarReg());
                    outputcars.WriteLine(currentCar.getcarFuel());
                    outputcars.WriteLine(currentCar.getcarServiced());
                    outputcars.WriteLine(currentCar.getcomment());
                }
            }
            outputcars.Close();

        }

        private void SelectFile() //Select File
        {
            MessageBox.Show("Select garage file.");

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";           
           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                filePath = openFileDialog.FileName;
            }
                  
        } 

        private void LoadCompanies()//Load in file 
        {
            try
            {


                StreamReader scar = new StreamReader(filePath);

                string CompanyID = scar.ReadLine();
                while (CompanyID != null)
                {
                    //loop to read in company info 
                    string companyName = scar.ReadLine();
                    string companyAddress = scar.ReadLine();
                    string companyPostCode = scar.ReadLine();
                    string numberOfCars = scar.ReadLine();

                    int numCars = Convert.ToInt32(numberOfCars);

                    carArray = new ArrayList();
                    for (int i = 0; i < numCars; i++)
                    {
                        //loop to read in car info
                        string carIDNumber = scar.ReadLine();
                        string carMakeAndModel = scar.ReadLine();
                        string carRegistration = scar.ReadLine();
                        string carFuelType = scar.ReadLine();
                        string carServicedDate = scar.ReadLine();
                        string comments = scar.ReadLine();

                        Car Cars = new Car(carIDNumber, carMakeAndModel, carRegistration, carFuelType, carServicedDate, comments);

                        carArray.Add(Cars);
                    }

                    Company companies = new Company(CompanyID, companyName, companyAddress, companyPostCode, numberOfCars, carArray);

                    companyArray.Add(companies); //Companies array

                    CompanyID = scar.ReadLine();
                }

                scar.Close();
            }
            catch
            {
                DialogResult result = MessageBox.Show ("File Format Invalid. " + filePath);
                if (result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                    
            }
        } 

        private void CheckInfo() // Check Car Info Within Selected Company
        {
          
            {

                

                Company currentCompany = (Company)companyArray[selectedCompany];

                ltbCar.Items.Clear();

                foreach (Car theCurrentCar in currentCompany.getcarDetails())
                {
                    ltbCar.Items.Add(theCurrentCar.getAllInfo());
                    ltbCar.SelectedIndex = 0;
                }
            }
  
         
            
           
        } 

        private void CheckCompanies() // CheckCompany Info
        {
            string output;

            ltbGarage.Items.Clear();

            foreach (Company currentCompany in companyArray)
            {
                output = currentCompany.getAllInfo();
                ltbGarage.Items.Add(output);
                ltbGarage.SelectedIndex = 0;
            }
        }
    
        private void Search(ListBox List, TextBox Text) // Search
        {


            for (int i = 0; i < List.Items.Count; i++)
            {
                if (List.Items[i].ToString().ToLower().Contains(Text.Text.ToLower()))
                {
                    List.SetSelected(i, true);
                }
            }
        }


        //Inputs////////////////////////////////////////////////////////////////////
        private void ltbGarage_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCompany = ltbGarage.SelectedIndex;
            CheckInfo();
        }

        private void btnGarage_Click(object sender, EventArgs e)
        {
            CheckCompanies();
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            FrmAddCar tempAddNewCar = new FrmAddCar();
            tempAddNewCar.Show();
            Hide();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            FrmEditCar tempEditCar = new FrmEditCar();
            tempEditCar.Show();
            Hide();
        }

        private void ltbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCar = ltbCar.SelectedIndex;
        }
      
        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            Company currentCompany = (Company)companyArray[MainForm.selectedCompany];
            Car currentCar = (Car)currentCompany.getcarDetails()[MainForm.selectedCar];


            currentCompany.getcarDetails().Remove(currentCar);

            int NumberOfCars = -1 + Convert.ToInt32(currentCompany.getnumberOfCars());

            currentCompany.setnumOfCars(Convert.ToString(NumberOfCars));

            RecreateFile(companyArray);

            CheckInfo();
        }

        private void btnCreateCompany_Click(object sender, EventArgs e)
        {
            FrmAddCompany tempCreateCompany = new FrmAddCompany();
            tempCreateCompany.Show();
            Hide();
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            FrmEditCompany tempEditCompany = new FrmEditCompany();
            tempEditCompany.Show();
            Hide();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {            
            Search(ltbGarage, txtSearchGarage);
        }
        
        private void btnSearch2_Click(object sender, EventArgs e)
        { 
            Search(ltbCar, txtCarSearch);
        }

        private void txtSearchGarage_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
    } 
}
