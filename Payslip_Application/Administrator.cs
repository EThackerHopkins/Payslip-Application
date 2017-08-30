using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip_Application
{
    class Administrator : PayrollEmployee //inherits from Employee
    {
        public Administrator() //constructor
        {
        }

        //methods

        public override double calcPay()
        {
            payThisMonth = Math.Round((getSalary() / 12), 2);
            payslipDetails = String.Format("Monthly salary {0,8:C2} - No extras", getSalary() / 12);
            return payThisMonth;
        }

        //Administrators receive no pay bonuses
    }
}
