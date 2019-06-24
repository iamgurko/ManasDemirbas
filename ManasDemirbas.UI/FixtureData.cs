using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManasDemirbas.Domain;
using ManasDemirbas.Repositories;

namespace ManasDemirbas.UI
{
    public partial class FixtureData : Form
    {
        public FixtureData()
        {
            InitializeComponent();
            PopulateFixtures();
        }

        private void PopulateFixtures()
        {
            uxFixtures.DataSource = FixtureManager.GetAll();
            uxFixtures.Columns[0].Visible = false;
            uxFixtures.Columns[4].Visible = false;
            uxFixtures.Columns[5].Visible = false;
            uxFixtures.Columns[7].Visible = false;

            uxFixtures.Columns[1].Width = 150;
            uxFixtures.Columns[2].Width = 300;
            uxFixtures.Columns[3].Width = 200;
        }

        private void addAssignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FixtureProcess();
            frm.ShowDialog();
            PopulateFixtures();
        }

        private void editAssignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get fixture from the grid
            var fixture = (Fixture)uxFixtures.CurrentRow.DataBoundItem;

            // pass it to the constructor of the maintenance form
            var frm = new FixtureProcess(fixture);
            frm.ShowDialog();
            PopulateFixtures();
        }
    }
}
