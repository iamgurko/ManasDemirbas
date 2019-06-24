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
    public partial class FixtureProcess : Form
    {
        public Fixture Fixture { get; set; }

        public FixtureProcess()
        {
            InitializeComponent();
            PopulateVendorsAndCategories();
            Text = "Add New Fixture";
        }

        public FixtureProcess(Fixture ast)
        {
            InitializeComponent();
            Fixture = ast;
            PopulateVendorsAndCategories();
            PopulateFields();
            Text = "Edit Fixture";
        }

        private void PopulateVendorsAndCategories()
        {
            uxAstVen.DataSource = VendorManager.GetAll();
            uxAstVen.DisplayMember = "Name";
            uxAstVen.ValueMember = "Id";
            uxAstCat.DataSource = FixtureCategoryManager.GetAll();
            uxAstCat.DisplayMember = "Name";
            uxAstCat.ValueMember = "Id";
        }
        
        private void PopulateFields()
        {
            uxAstName.Text = Fixture.Name;
            uxAstSer.Text = Fixture.Serial;
            uxAstDesc.Text = Fixture.Description;
            uxAstVen.SelectedValue = Fixture.VendorId;
            uxAstCat.SelectedValue = Fixture.FixtureCategoryId;
        }

        private void uxOk_Click(object sender, EventArgs e)
        {
            if (Fixture == null)
            {
                // doing an insert
                Fixture = new Fixture();
                SetFixture();
                FixtureManager.Add(Fixture);
            }
            else
            {
                // doing an update
                SetFixture();
                FixtureManager.Update(Fixture);
            }
            Close();
        }

        private void SetFixture()
        {
            Fixture.Name = uxAstName.Text;
            Fixture.Serial = uxAstSer.Text;
            Fixture.Description = uxAstDesc.Text;
            Fixture.VendorId = (int)uxAstVen.SelectedValue;
            Fixture.FixtureCategoryId = (int)uxAstCat.SelectedValue;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
