using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payslip_Application
{
    public partial class Form1 : Form
    {
        PayrollEmployee[] employees; //global array to hold all Payroll details

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersonnelIO testFile = new PersonnelIO(); //create PersonnelIO object to read XML file
            Personnel[] persons = testFile.ReadPersonnelXML(@".\PersonnelFile.xml");
            //read XML file and load details into temporary Personnel array
            Personnel.resetEmployeeCount();
            employees = new PayrollEmployee[persons.Length];

            //for each employee, add corresponding employee type to global array
            for (int i = 0; i < persons.Length; i++)
            {
                switch (persons[i].getEmployeeType()) //check employee type
                {
                    case "HourlyPaid":
                        employees[i] = new HourlyPaid(); //adds HourlyPaid employee
                        break;

                    case "Administrator":
                        employees[i] = new Administrator(); //adds Administrator employee
                        break;

                    case "Salesperson":
                        employees[i] = new SalesPerson(); //adds Saleserson employee
                        break;

                    case "Manager":
                        employees[i] = new Manager(); //adds Manager employee
                        break;

                    default:
                        employees[i] = new Invalid(); //adds Invalid employee; only executed if no other match is found
                        break;
                }

                employees[i].setEmployeeType(persons[i].getEmployeeType());
                employees[i].setName(persons[i].getName());
                employees[i].setNINo(persons[i].getNINo());
                employees[i].setSalary(persons[i].getSalary());

            }

            lblListHeading.Text = String.Format("{0}{1,-9} {2,-25}  {3,-14}  {4}              {5}      {6}",
                "Rec.No.", "NI No.", "Employee Name", "Employee Type", "Salary", "Pay this month", "Payslip details");
            refreshSampleDataList();

        }

        private void refreshSampleDataList()
        {
            listbox_items.Items.Clear();

            foreach(PayrollEmployee dtl in employees) //loop through each entry in PayrollEmployee array
            {
                string textDetail = String.Format("{0,3} : {1,9} {2,-25} :{3,-14}  {4,10:C2}" +
                    "    This month: {5,10:C2} > {6}", dtl.getRecordNo(), dtl.getNINo(), dtl.getName(),
                    dtl.getEmployeeType(), dtl.getSalary(), dtl.get_paysThisMonth(), dtl.get_payslipDetails());

                listbox_items.Items.Add(textDetail); //add detail to list box
            }
        }

        private void listbox_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnl_update.Visible = true; //make panel visible

            //hide controls
            lbl_parameter1.Visible = false;
            txtbox_parameter1.Visible = false;
            lbl_parameter2.Visible = false;
            txtbox_parameter2.Visible = false;

            //display employee's details in the panel
            PayrollEmployee person = employees[listbox_items.SelectedIndex];
            lbl_personnelData.Text = String.Format("{2,-25}   -  ID No : {0,3}        NINo: {1,9}    {3,-14}" +
                "  Salary : {4,10:C2}\nThis month: {5,10:C2} > {6}", person.getRecordNo(), person.getNINo(),
                person.getName(), person.getEmployeeType(), person.getSalary(), person.get_paysThisMonth(),
                person.get_payslipDetails());

            switch(employees[listbox_items.SelectedIndex].getEmployeeType()) //get employee type
            {
                case "HourlyPaid":
                    double overtimeHours = ((HourlyPaid)employees[listbox_items.SelectedIndex]).get_overtimeHoursWorked();
                    set_parameter1Details("Overtime hours this month: ", overtimeHours.ToString());
                    break;

                case "Administrator":
                    set_parameter1Details("No further payroll data required.", "No value");
                    break;

                case "Salesperson":
                    double salesLastMonth = ((SalesPerson)employees[listbox_items.SelectedIndex]).get_salesLastMonth();
                    set_parameter1Details("Last month's sales: ", salesLastMonth.ToString());
                    double commission = ((SalesPerson)employees[listbox_items.SelectedIndex]).get_salesComission();
                    set_parameter2Details("Standard sales commission: {0}%", commission.ToString());
                    break;

                case "Manager":
                    double bonus = ((Manager)employees[listbox_items.SelectedIndex]).get_bonusPercent();
                    set_parameter1Details("Bonus: {0}%", bonus.ToString());
                    break;  

                default:
                    set_parameter1Details("Unknown employee type; unable to calculate pay.", "No value");
                    break;
            }
        }

        private void set_parameter1Details(string label, string text)
        {
            lbl_parameter1.Visible = true;
            lbl_parameter1.Text = label;

            if (text != "No value")
            {
                set_parameter1Details_(text);
            }
        }

        private void set_parameter1Details_(string text)
        {
            txtbox_parameter1.Visible = true;
            txtbox_parameter1.Text = text;
            txtbox_parameter1.Focus();
            txtbox_parameter1.Select(txtbox_parameter1.Text.Length, 0);
        }

        private void set_parameter2Details(string label, string text)
        {
            lbl_parameter2.Visible = true;
            lbl_parameter2.Text = label;
            txtbox_parameter2.Visible = true;
            txtbox_parameter2.Text = text;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pnl_update.Visible = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bool inputOK = false; //set to false initially; changed to true once input is validated
            
            switch(employees[listbox_items.SelectedIndex].getEmployeeType())
            {
                case "HourlyPaid":
                    double overtimeHours;
                    
                    try
                    {
                        overtimeHours = Convert.ToDouble(txtbox_parameter1.Text);

                        if (overtimeHours >= 0 && overtimeHours <= 30)
                        {
                            HourlyPaid temp = (HourlyPaid)employees[listbox_items.SelectedIndex];
                            temp.set_overtimeHoursWorked(overtimeHours);
                            inputOK = true;
                        }
                        else
                        {
                            MessageBox.Show("Overtime hours must be between 0 and 30 hours only.", "Invalid entry");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Invalid input " + ex.Message);
                    }
                    break;

                case "Administrator":
                    inputOK = true;
                    break;

                case "Salesperson":
                    double salesLastMonth;
                    double commission;

                    try
                    {
                        salesLastMonth = Convert.ToDouble(txtbox_parameter1.Text);
                        commission = Convert.ToDouble(txtbox_parameter2.Text);
                        SalesPerson temp = (SalesPerson)employees[listbox_items.SelectedIndex];
                        temp.set_salesComission(commission);

                        if(salesLastMonth >= 0 && salesLastMonth <= 100000)
                        {
                            temp.set_salesThisMonth(salesLastMonth);
                            inputOK = true;
                        }
                        else
                        {
                            MessageBox.Show("Sales last month must be between £0 and £100,000 only.", "Out of range");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Invald input " + ex.Message);
                    }
                    break;

                case "Manager":
                    {
                        double bonus;

                        try
                        {
                            bonus = Convert.ToDouble(txtbox_parameter1.Text);

                            if(bonus >= 0 && bonus <= 8)
                            {
                                Manager temp = (Manager)employees[listbox_items.SelectedIndex];
                                temp.set_bonusPercent(bonus);
                                inputOK = true;
                            }
                            else
                            {
                                MessageBox.Show("Performance bonus must be between 0% and 8%.", "Out of range");
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Invalid input " + ex.Message);
                        }
                        break;
                    }

                default:
                    inputOK = true;
                    break;
            }

            if(inputOK) //if the input is validated
            {
                pnl_update.Visible = false; //close panel
                employees[listbox_items.SelectedIndex].calcPay(); //calculate pay
                refreshSampleDataList(); //display details
            }
            else
            {
                set_parameter1Details_("0");
            }
        }

        private void btn_calcAllPay_Click(object sender, EventArgs e)
        {
            double totalPay = 0; //local variable to for total pay

            foreach(PayrollEmployee dtl in employees) //calculate monthly pay for each employee
            {
                totalPay += dtl.calcPay(); //add monthly pay to total pay
            }
            refreshSampleDataList(); //display details
            lbl_calcAllPay.Text = String.Format("Total pay \n {0,10:C2} \nData written\nto file", totalPay);

            pnl_update.Hide(); //close panel

            payslipIO XMLoutput = new payslipIO(); //instantiate new XML writer
            XMLoutput.writePayslipToXML(employees); //write to XML file
        }

        private void btn_closeProgram_Click(object sender, EventArgs e) //button to close program
        {
            string warning = "Do you wish to save employee details before closing?"; //warning message
            string caption = "Payslip Application"; //message box title
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel; //gives message box "Yes", "No", and "Cancel" buttons

            var result = MessageBox.Show(warning, caption, buttons); //gets result from message box

            if (result == DialogResult.Yes) //if yes
            {
                payslipIO XMLoutput = new payslipIO(); //save to file
                XMLoutput.writePayslipToXML(employees);
                Application.Exit(); //closes application
            }
            else if (result == DialogResult.No) //if no
            {
                Application.Exit(); //closes application without saving
            }
            
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(listbox_items, AppDomain.CurrentDomain.BaseDirectory + "help.htm");
        }
    }
}
