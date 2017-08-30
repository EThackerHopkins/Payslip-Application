using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip_Application
{
    class PersonnelIO
    {
        public void WritePersonnelXML(Personnel[] person, string fileName)
        {
            //string fileName = @".\PersonnelFile.xml";// @ needed to read backslashes correctly
            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
            PersonnelRecord[] tmp = new PersonnelRecord[person.Length];
            for (int i = 0; i < person.Length; i++)
            {
                tmp[i] = new PersonnelRecord();
                tmp[i].setFields(person[i]);
            }

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(PersonnelRecord[]));

            writer.Serialize(file, tmp);
            file.Close();
        }

        public Personnel[] ReadPersonnelXML(string fileName)
        {
            //string fileName = @".\PersonnelFile.xml"; // @ needed to read backslashes correctly
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(PersonnelRecord[]));
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
            //PersonnelRecord[] tmp = new PersonnelRecord[0];
            PersonnelRecord[] tmp = (PersonnelRecord[])reader.Deserialize(file);
            file.Close();
            Personnel[] personsTmp = new Personnel[tmp.Length];
            for (int i = 0; i < tmp.Length; i++)
            {
                personsTmp[i] = tmp[i].getFields();
            }


            return personsTmp;
        }
    }

    public class PersonnelRecord
    {

        public string NINo;
        public string Name;
        public double Salary = 0.00;
        public string EmployeeType;

        public void setFields(Personnel newPerson)
        {
            NINo = newPerson.getNINo();
            Name = newPerson.getName();
            Salary = newPerson.getSalary();
            EmployeeType = newPerson.getEmployeeType();
        }

        public Personnel getFields()
        {
            Personnel newPerson = new Personnel();
            newPerson.setEmployeeType(EmployeeType);
            newPerson.setName(Name);
            newPerson.setNINo(NINo);
            newPerson.setSalary(Salary);

            return newPerson;
        }
    }
}
