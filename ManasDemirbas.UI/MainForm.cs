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
    public partial class MainForm : Form
    {
        DepartmentData _deptLookupForm;
        EmployeeData _empLookupForm;
        FixtureCategoryData _aCatLookupForm;
        VendorData _venLookupForm;
        FixtureData _astLookupForm;
        FixtureAssignment _astAsgnLookupForm;

        public MainForm()
        {
            InitializeComponent();
        }

        // Employee Lookup Form
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_empLookupForm == null || _empLookupForm.IsDisposed)
            {
                _empLookupForm = new EmployeeData();
                _empLookupForm.MdiParent = this;
            }

            _empLookupForm.Show();
            _empLookupForm.BringToFront();
        }

        // Department Lookup Form
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_deptLookupForm == null || _deptLookupForm.IsDisposed)
            {
                _deptLookupForm = new DepartmentData();
                _deptLookupForm.MdiParent = this;
            }

            _deptLookupForm.Show();
            _deptLookupForm.BringToFront();
        }

        // Fixture Categories Lookup Form
        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (_aCatLookupForm == null || _aCatLookupForm.IsDisposed)
            {
                _aCatLookupForm = new FixtureCategoryData();
                _aCatLookupForm.MdiParent = this;
            }

            _aCatLookupForm.Show();
            _aCatLookupForm.BringToFront();
        }

        // Vendor Lookup Form
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_venLookupForm == null || _venLookupForm.IsDisposed)
            {
                _venLookupForm = new VendorData();
                _venLookupForm.MdiParent = this;
            }

            _venLookupForm.Show();
            _venLookupForm.BringToFront();
        }

        // Fixtures Lookup Form
        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_astLookupForm == null || _astLookupForm.IsDisposed)
            {
                _astLookupForm = new FixtureData();
                _astLookupForm.MdiParent = this;
            }

            _astLookupForm.Show();
            _astLookupForm.BringToFront();
        }

        //  Fixture Assignment Form
        private void manageAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_astAsgnLookupForm == null || _astAsgnLookupForm.IsDisposed)
            {
                _astAsgnLookupForm = new FixtureAssignment();
                _astAsgnLookupForm.MdiParent = this;
            }

            _astAsgnLookupForm.Show();
            _astAsgnLookupForm.BringToFront();
        }

        // Toolstrip buttons
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem1_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            viewToolStripMenuItem1_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem2_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            viewToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            manageAssignmentToolStripMenuItem_Click(sender, e);
        }
        // END: Toolstrip buttons

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
