using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip_Application
{
    public class Personnel
    {
        // Attributes
        protected static int employeeCount;
        private int recordNo;
        private string NINo;
        private string Name;
        private double Salary = 0.00;     // for employee type HourlyPaid, this is their hourly rate * 35 * 52
        private string EmployeeType = "Invalid";


        // Methods
        public Personnel() // employee constructor
        {
            // Increment the employee count
            employeeCount++;
            recordNo = employeeCount;
        }

        public string setNINo(string newNINo)
        {
            if (newNINo.Length == 9)
            {
                NINo = newNINo;
                return "OK";
            }
            else
            {
                NINo = "Invalid";
                return ("INVALID NINo : National Insurance No. not 9 characters long");
            }

        }

        public void setName(string newName)
        {
            Name = newName;
        }

        public string setSalary(double newSalary)
        {
            if (newSalary >= 0 && newSalary <= 100000)
            {
                Salary = newSalary;
                return "OK";
            }
            else
            {
                Salary = 0.00;
                return ("INVALID Salary : Salary value of " + newSalary + 
                    " is outside allowable range : Salary set to 0.00");
            }
        }

        public string setEmployeeType(string newEmployeeType)
        {
            if (newEmployeeType == "HourlyPaid" ||
                newEmployeeType == "Administrator" ||
                newEmployeeType == "Salesperson" ||
                newEmployeeType == "Manager")
            {
                EmployeeType = newEmployeeType;
                return "OK";
            }
            else
            {
                EmployeeType = "Invalid";
                return ("INVALID Employee Type : set to Invalid \n MUST BE :" +
                    "\n\tHourlyPaid\n\tAdministrator\n\tSalesperson\n\tManager");
            }
        }

        // reset the Employee count to zero
        public static void resetEmployeeCount()
        {
            employeeCount = 0;
        }

        // class method to return the employee count as it is a static variable

        public static int getEmployeeCount()
        {
            return employeeCount;
        }

        public int getRecordNo()
        {
            return recordNo;
        }

        // accessor method to return the employee's Name
        public string getName()
        {
            return Name;
        }

        public string getNINo()
        {
            return NINo;
        }

        public double getSalary()
        {
            return Salary;
        }

        public string getEmployeeType()
        {
            return EmployeeType;
        }
    }
}
