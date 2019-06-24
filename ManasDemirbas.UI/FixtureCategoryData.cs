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
    public partial class FixtureCategoryData : Form
    {
        public FixtureCategoryData()
        {
            InitializeComponent();
            PopulateFixturesCategories();
        }

        private void PopulateFixturesCategories()
        {
            uxACats.DataSource = FixtureCategoryManager.GetAll();
            uxACats.Columns[0].Visible = false;
            uxACats.Columns[2].Visible = false;
            uxACats.Columns[1].Width = 200;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FixtureCategoryProcess();
            frm.ShowDialog();
            PopulateFixturesCategories();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // datagrid seçili satır
            var aCat = (FixtureCategory)uxACats.CurrentRow.DataBoundItem;

            // constructor'a aktar
            var frm = new FixtureCategoryProcess(aCat);
            frm.ShowDialog();
            PopulateFixturesCategories();
        }
    }
}
