using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip_Application
{
    public abstract class PayrollEmployee : Personnel
    {
        //Attributes

        protected string payslipDetails;
        protected double payThisMonth = 0.00;

        //Methods

        public string get_payslipDetails()
        {
            return payslipDetails;
        }

        public double get_paysThisMonth()
        {
            return payThisMonth;
        }

        public abstract double calcPay(); //forces subclasses to include code for calcPay() method
    }
}
