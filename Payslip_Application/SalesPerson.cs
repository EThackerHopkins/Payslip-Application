using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip_Application
{
    class SalesPerson : PayrollEmployee //inherits from Employee
    {
        //Attributes

        private double salesLastMonth, salesComission;

        //Methods

        public SalesPerson() //constructor
        {
            salesLastMonth = 0.00;
            salesComission = 5.00;
        }

        public double get_salesLastMonth()
        {
            return salesLastMonth;
        }

        public void set_salesThisMonth(double inputSalesLastMonth)
        {
            salesLastMonth = inputSalesLastMonth;
        }

        public void set_salesComission(double inputSalesComission)
        {
            salesComission = inputSalesComission;
        }

        public double get_salesComission()
        {
            return salesComission;
        }

        public override double calcPay()
        {
            double comission = Math.Round(salesLastMonth * salesComission / 100, 2);
            payThisMonth = Math.Round((getSalary() / 12) + comission, 2);
            payslipDetails = String.Format("Monthly salary {0,8:C2}, plus {1,5:C2} comission on {2,5:C2} of sales",
                getSalary() / 12, comission, salesLastMonth);
            return payThisMonth;
        }

        //Salespeople receive a monthly salary and the commission percentage of the previous month’s sales
    }
}
