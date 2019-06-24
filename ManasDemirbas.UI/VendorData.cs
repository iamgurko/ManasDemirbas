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
    public partial class VendorData : Form
    {
        public VendorData()
        {
            InitializeComponent();
            PopulateVendors();
        }

        private void PopulateVendors()
        {
            uxVendors.DataSource = VendorManager.GetAll();
            uxVendors.Columns[0].Visible = false;
            uxVendors.Columns[3].Visible = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new VendorProcess();
            frm.ShowDialog();
            PopulateVendors();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get vendor from the grid
            var ven = (Vendor)uxVendors.CurrentRow.DataBoundItem;

            // pass it to the constructor of the maintenance form
            var frm = new VendorProcess(ven);
            frm.ShowDialog();
            PopulateVendors();
        }
    }
}
