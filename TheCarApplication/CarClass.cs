using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCarsApplication
{
    class Car
    {
        //Class Varribles
        string carIDNumber;
        string carMakeAndModel;
        string carRegistration;
        string carFuelType;
        string carServicedDate;
        string comments;

        //constructor
        public Car(string conid, string conmakeandmodel, string conreg, string confuel, string conserviced, string concomment)
        {
            carIDNumber = conid;
            carMakeAndModel = conmakeandmodel;
            carRegistration = conreg;
            carFuelType = confuel;
            carServicedDate = conserviced;
            comments = concomment;
        }

        //Getters
        public string getAllInfo()
        {
            string output = "";
            output = "Car registration: " + carRegistration + " Car ID: " + carIDNumber + " Make and Model: " + carMakeAndModel + " " + " Fuel: " + carFuelType + " Last serviced on " + carServicedDate + " Comment: " + comments;
            return output;
        }

        public string getcarID()
        {
            return carIDNumber;
        }

        public string getCarMakeAndModel()
        {
            return carMakeAndModel;
        }

        public string getcarReg()
        {
            return carRegistration;
        }

        public string getcarFuel()
        {
            return carFuelType;
        }

        public string getcarServiced()
        {
            return carServicedDate;
        }

        public string getcomment()
        {
            return comments;
        }

        //Setters

        public void setcarID(string inputcarID)
        {
            carIDNumber = inputcarID;
        }

        public void setcarMake(string inputCarMakeAndModel)
        {
            carMakeAndModel = inputCarMakeAndModel;
        }

        public void setcarReg(string inputcarReg)
        {
            carRegistration = inputcarReg;
        }

        public void setcarFuel(string inputcarFuel)
        {
            carFuelType = inputcarFuel;
        }

        public void setcarServiced(string inputcarServiced)
        {
            carServicedDate = inputcarServiced;
        }

        public void setcomment(string inputcarcomment)
        {
            comments = inputcarcomment;
        }

    }
}