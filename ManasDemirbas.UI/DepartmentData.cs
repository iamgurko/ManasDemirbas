using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManasDemirbas.Repositories;
using ManasDemirbas.Domain;

namespace ManasDemirbas.UI
{
    public partial class DepartmentData : Form
    {
        public DepartmentData()
        {
            InitializeComponent();
            PopulateDepartments();
        }

        private void PopulateDepartments()
        {
            uxDepartments.DataSource = DepartmentManager.GetAll();
            uxDepartments.Columns[0].Visible = false;
            uxDepartments.Columns[2].Visible = false;
            uxDepartments.Columns[1].Width = 200;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DepartmentProcess();
            frm.ShowDialog();
            PopulateDepartments();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // datagrid üzerinden veri getir
            var dept = (Department)uxDepartments.CurrentRow.DataBoundItem;

            // constructor'a formu gönder
            var frm = new DepartmentProcess(dept);
            frm.ShowDialog();
            PopulateDepartments();
        }
    }
}
