using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip_Application
{
    class payslipIO
    {
        public void writePayslipToXML(PayrollEmployee[] person)
        {
            string filename = @".\NewPayslipFile.xml";
            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
            payslipRecord[] temp = new payslipRecord[person.Length];

            for(int i = 0; i < person.Length; i++)
            {
                temp[i] = new payslipRecord();
                temp[i].setFields(person[i]);
            }

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(payslipRecord[]));
            writer.Serialize(file, temp);
            file.Close();
        }
    }

    public class payslipRecord
    {
        public string NINo;
        public string name;
        public double salary = 0.00;
        public string employeeType;
        public string payslipDetails;
        public double payThisMonth = 0.00;

        public void setFields(PayrollEmployee newPerson)
        {
            NINo = newPerson.getNINo();
            name = newPerson.getName();
            salary = newPerson.getSalary();
            employeeType = newPerson.getEmployeeType();
            payslipDetails = newPerson.get_payslipDetails();
            payThisMonth = newPerson.get_paysThisMonth();
        }
    }
}
