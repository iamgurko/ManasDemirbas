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
    public partial class EmployeeData : Form
    {
        public EmployeeData()
        {
            InitializeComponent();
            PopulateEmployees();
        }

        private void PopulateEmployees()
        {
            uxEmployees.DataSource = EmployeeManager.GetAll();
            uxEmployees.Columns[0].Visible = false;
            uxEmployees.Columns[6].Visible = false;
            uxEmployees.Columns[8].Visible = false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // datagrid üzerinden personel getir
            var emp = (Employee)uxEmployees.CurrentRow.DataBoundItem;

            // constructor'a form gönder
            var frm = new EmployeeProcess(emp);
            frm.ShowDialog();
            PopulateEmployees();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new EmployeeProcess();
            frm.ShowDialog();
            PopulateEmployees();
        }

        private void uxEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
