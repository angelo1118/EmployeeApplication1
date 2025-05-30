using System;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string department = txtDepartment.Text;
            string jobTitle = txtJobTitle.Text;

            int hoursWorked = int.Parse(txtHours.Text);
            double ratePerHour = double.Parse(txtRate.Text);

            PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, department, jobTitle);
            employee.computeSalary(hoursWorked, ratePerHour);

            lblResultFirstName.Text = "First name: " + employee.FirstName;
            lblResultLastName.Text = "Last name: " + employee.LastName;
            lblResultSalary.Text = "Basic Salary: " + employee.BasicSalary.ToString();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

    }
}
