using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip_Application
{
    class HourlyPaid : PayrollEmployee //inherits from Employee
    {
        //Attributes

        private double overtimeHoursWorked;

        //Methods

        public HourlyPaid() //constructor
        {
            overtimeHoursWorked = 0.0;
        }

        public double get_overtimeHoursWorked()
        {
            return overtimeHoursWorked;
        }

        public void set_overtimeHoursWorked(double inputHoursWorked)
        {
            overtimeHoursWorked = inputHoursWorked;
        }

        public override double calcPay()
        {
            double hourlyRate = Math.Round(getSalary() / 52 / 35 * 1.5, 2);
            payThisMonth = Math.Round((getSalary() / 12) + (overtimeHoursWorked * hourlyRate), 2);
            payslipDetails = String.Format("Monthly salary {0,8:C2}, plus {1,5:N2} hours overtime; {2,5:C2} per hour",
                getSalary() / 12, overtimeHoursWorked, hourlyRate);
            return payThisMonth;
        }

        //Hourly paid employees receive pay for up to thirty overtime hours
    }
}
