using ManasDemirbas.Domain;
using ManasDemirbas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManasDemirbas.Repositories
{
    public class FixtureCategoryManager: FixtureCategory
    {
        public static IEnumerable<FixtureCategory> GetAll()
        {
         
            // var categories = LoadTestData();

            var context = new FixtureContext();
            var categories = context.FixtureCategories.ToList();
            
            return categories;
        }

        // Ekleme
        public static void Add(FixtureCategory aCat)
        {
            var context = new FixtureContext();
            context.FixtureCategories.Add(aCat);
            context.SaveChanges();
        }

        // Güncelleme
        public static void Update(FixtureCategory aCat)
        {
            var context = new FixtureContext();
            var existingACat = context.FixtureCategories.SingleOrDefault(ac => ac.Id == aCat.Id);

            existingACat.Name = aCat.Name;
            context.SaveChanges();
        }

        // Deneme Data
        private static List<FixtureCategory> LoadTestData()
        {
            var categories = new List<FixtureCategory>();

            categories.Add(new FixtureCategory { Id = 1, Name = "Desktop PCs" });
        
            return categories;
        }
    }
}

