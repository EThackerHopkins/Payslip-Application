using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip_Application
{
    class Invalid : PayrollEmployee //inherits from Employee
    {
         public Invalid() //constructor
        {
        }

        public override double calcPay()
        {
            payThisMonth = 0.00;
            payslipDetails = "Unknown personnel type - No pay calculation carried out";
            return 0.00;
        }

        //Invalid employees cannot have a salary calculated
    }
}
