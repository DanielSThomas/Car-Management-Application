using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TheCarsApplication
{
    class Company
    {

        //ClassVarribles
        string companyIDNumber;
        string companyName;
        string companyAddress;
        string companyPostCode;
        string numberOfCars;
        ArrayList Cars;




        //Constructor
        public Company(string conid, string conname, string conaddress, string conpostCode, string concarsNum, ArrayList conCars)
        {
            companyIDNumber = conid;
            companyName = conname;
            companyAddress = conaddress;
            companyPostCode = conpostCode;
            numberOfCars = concarsNum;
            Cars = conCars;
        }

        //Getters
        public string getAllInfo()
        {
            string output = "";
            output = "ID Number: " + companyIDNumber + " Name: " + companyName + " Address: " + companyAddress + " ," + companyPostCode + " Number of Cars: " + numberOfCars;
            return output;
        }

        public string getidNumber()
        {
            return companyIDNumber;
        }

        public string getname()
        {
            return companyName;
        }

        public string getaddress()
        {
            return companyAddress;
        }

        public string getpostCode()
        {
            return companyPostCode;
        }

        public string getnumberOfCars()
        {
            return numberOfCars;
        }
        public ArrayList getcarDetails()
        {
            return Cars;
        }

        //Setters

        public void setidNumber(string inputCompanyID)
        {
            companyIDNumber = inputCompanyID;
        }

        public void setname(string inputCompanyName)
        {
            companyName = inputCompanyName;
        }

        public void setaddress(string inputCompanyAddress)
        {
            companyAddress = inputCompanyAddress;
        }

        public void setpostCode(string inputCompanyPostCode)
        {
            companyPostCode = inputCompanyPostCode;
        }

        public void setnumOfCars(string inputCompanyNumberOfCars)
        {
            numberOfCars = inputCompanyNumberOfCars;
        }

        public void setcars(ArrayList inputcars)
        {
            Cars = inputcars;
        }

    }
}
