using ManasDemirbas.Domain;
using ManasDemirbas.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManasDemirbas.UI
{
    public partial class EmployeeProcess : Form
    {
        public Employee Employee { get; set; }
        public EmployeeProcess()
        {
            InitializeComponent();
            PopulateDepartments();
        }
        
        public EmployeeProcess(Employee emp)
        {
            InitializeComponent();
            Employee = emp;
            PopulateFields();

            Text = "Edit Employee";
        }

        private void PopulateDepartments()
        {
            uxDept.DataSource = DepartmentManager.GetAll();
            uxDept.ValueMember = "Id";
            uxDept.DisplayMember = "Name";
        }

        private void PopulateFields()
        {
            uxFName.Text = Employee.FirstName;
            uxLName.Text = Employee.LastName;
            uxDeskNum.Text = Employee.DeskNumber;
            uxTel.Text = Employee.PhoneNumber;
            uxHireDate.Text = Employee.HireDate.ToString();
            PopulateDepartments();
            uxDept.SelectedValue = Employee.DepartmentId;
        }

        private void uxOk_Click(object sender, EventArgs e)
        {
            if (Employee == null)
            {
                // doing an insert
                Employee = new Employee();
                SetEmployee();
                EmployeeManager.Add(Employee);
            }
            else
            {
                // doing an update
                SetEmployee();
                EmployeeManager.Update(Employee);
            }
            Close();
        }

        private void SetEmployee()
        {
            Employee.FirstName = uxFName.Text;
            Employee.LastName = uxLName.Text;
            Employee.DeskNumber = uxDeskNum.Text;
            Employee.PhoneNumber = uxTel.Text;
            Employee.HireDate = uxHireDate.Value;
            Employee.DepartmentId = (int)uxDept.SelectedValue;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeeMaintenance_Load(object sender, EventArgs e)
        {

        }
    }
}
