using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip_Application
{
    class Manager : PayrollEmployee //inherits from Employee
    {
        //Attributes

        double bonusPercent;

        //Methods

        public Manager() //constructor
        {
            bonusPercent = 0.00;
        }

        public double get_bonusPercent()
        {
            return bonusPercent;
        }

        public void set_bonusPercent(double inputBonusPercent)
        {
            bonusPercent = inputBonusPercent;
        }

        public override double calcPay()
        {
            double bonus = Math.Round((getSalary() / 12) * bonusPercent / 100, 2);
            payThisMonth = Math.Round((getSalary() / 12) + bonus, 2);
            payslipDetails = String.Format("Monthly salary {0,8:C2}, plus bonus of {1,5:C2} at {2,5:P2}",
                getSalary() / 12, bonus, bonusPercent / 100);
            return payThisMonth;
        }

        //Managers receive a percentile bonus: between 0-8% of their initial monthly salary
    }
}
