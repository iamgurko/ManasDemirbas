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
    public partial class FixtureCategoryProcess : Form
    {
        public FixtureCategory AsCat { get; set; }

        public FixtureCategoryProcess()
        {
            InitializeComponent();
           
        }

        public FixtureCategoryProcess(FixtureCategory aCat)
        {
            InitializeComponent();
            AsCat = aCat;
            uxACatName.Text = AsCat.Name;
            Text = "Demirbaş Kategori";
        }

        private void uxOk_Click(object sender, EventArgs e)
        {
            if (AsCat == null)
            {
                // ekle
                AsCat = new FixtureCategory();
                AsCat.Name = uxACatName.Text;
                FixtureCategoryManager.Add(AsCat);
            }
            else
            {
                // güncelle
                AsCat.Name = uxACatName.Text;
                FixtureCategoryManager.Update(AsCat);
            }
            Close();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
