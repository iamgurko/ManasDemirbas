using ManasDemirbas.Repositories;
using ManasDemirbas.Domain;
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
    public partial class FixtureAssignment : Form
    {
        public FixtureAssignment()
        {
            InitializeComponent();
            PopulateInitialData();
        }

        private void PopulateInitialData()
        {
            uxEmployees.DataSource = EmployeeManager.GetAll();
            uxEmployees.ValueMember = "Id";
            uxEmployees.DisplayMember = "LastName";
            uxCategories.DataSource = FixtureCategoryManager.GetAll();
            uxCategories.DisplayMember = "Name";
            uxCategories.ValueMember = "Id";

            var firstEmployeeFixtures = FixtureManager.GetFixturesByEmployee(EmployeeManager.GetAll().First().Id);          
            var firstCategoryFixtures = FixtureManager.GetAvailableFixturesByCategory(FixtureCategoryManager.GetAll().First().Id);
            PopulateEmployeeFixtures(firstEmployeeFixtures);
            PopulateCategoryFixtures(firstCategoryFixtures);
            uxDepartmentName.Text = EmployeeManager.GetAll().First().Department.ToString();
        }

        private void PopulateEmployeeFixtures(IEnumerable<Fixture> EmployeeFixtures)
        {
            foreach (Fixture ast in EmployeeFixtures)
            {
                uxEmployeeFixtures.Items.Add(ast, true);
            }
        }

        private void PopulateCategoryFixtures(IEnumerable<Fixture> CategoryFixtures)
        {
            foreach (Fixture ast in CategoryFixtures)
            {
                uxAvailableFixtures.Items.Add(ast, false);
            }
        }

        private void uxEmployees_Format(object sender, ListControlConvertEventArgs e)
        {
            string fName = ((Employee)e.ListItem).FirstName;
            string lName = ((Employee)e.ListItem).LastName;
            e.Value = lName + ", " + fName;
        }

        private void uxEmployees_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedEmployee = (Employee)uxEmployees.SelectedItem;
            uxEmployeeFixtures.Items.Clear();
            var selectedEmployeeFixtures = FixtureManager.GetFixturesByEmployee(selectedEmployee.Id);
            PopulateEmployeeFixtures(selectedEmployeeFixtures);
            uxDepartmentName.Text = selectedEmployee.Department.ToString();
        }

        private void uxCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedCategory = (FixtureCategory)uxCategories.SelectedItem;
            uxAvailableFixtures.Items.Clear();
            var selectedCategoryFixtures = FixtureManager.GetAvailableFixturesByCategory(selectedCategory.Id);
            PopulateCategoryFixtures(selectedCategoryFixtures);
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxOk_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) personel ve kategori seçimi
                var selectedEmployee = (Employee)uxEmployees.SelectedItem;
                var selectedCategory = (FixtureCategory)uxCategories.SelectedItem;

                // 2-A) personel üzerinden alınacak demirbaşlar (http://stackoverflow.com/a/30264947/1420170)
                IEnumerable<Fixture> uncheckedFixtures = (from Fixture item in uxEmployeeFixtures.Items
                                                      where !uxEmployeeFixtures.CheckedItems.Contains(item)
                                                      select item);

                // 2-B) demirbaşları sil
                foreach (Fixture ast in uncheckedFixtures)
                {
                    FixtureManager.RemoveFixtureFromEmployee(ast.Id);
                }

                // 3-A) atanacak demirbaşları al
                IEnumerable<Fixture> checkedFixtures = (from Fixture item in uxAvailableFixtures.Items
                                                    where uxAvailableFixtures.CheckedItems.Contains(item)
                                                    select item);
                if (checkedFixtures.Count() > 0) {
                    // 3-B) More than one asset from a given category can't be assigned to this employee
                    // 3-B-i) Check if more than one asset within a category is checked
                    if (checkedFixtures.Count() > 1)
                    {
                        throw new Exception("You can only assign one asset from each category to an employee.");
                    }

                    // 3-B-ii) For the given category, make sure no related asset is already assigned
                    bool alreadyAssigned = FixtureManager.CategoryFixtureAlreadyAssignedToEmployee(selectedCategory.Id, selectedEmployee.Id);

                    if (alreadyAssigned == true)
                    {
                        throw new Exception("You can only assign one asset from each category to an employee.");
                    }

                    // 3-C) Assign this asset
                    foreach (Fixture ast in checkedFixtures)
                    {
                        FixtureManager.AssignFixturesToEmployee(ast.Id, selectedEmployee.Id);
                    }
                }

                // 4) Display success message for 2s (http://stackoverflow.com/a/15951830/1420170)
                var t = new Timer();
                t.Interval = 2000;
                t.Tick += (s, ev) =>
                {
                    uxSuccessMessage.Hide();
                    t.Stop();
                };
                uxSuccessMessage.Show();
                t.Start();

                // 5) Repopulate the checlistboxes
                uxEmployeeFixtures.Items.Clear();
                uxAvailableFixtures.Items.Clear();
                var selectedEmployeeFixtures = FixtureManager.GetFixturesByEmployee(selectedEmployee.Id);
                PopulateEmployeeFixtures(selectedEmployeeFixtures);
                var selectedCategoryFixtures = FixtureManager.GetAvailableFixturesByCategory(selectedCategory.Id);
                PopulateCategoryFixtures(selectedCategoryFixtures);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FixtureAssignment_Load(object sender, EventArgs e)
        {

        }
    }
}
