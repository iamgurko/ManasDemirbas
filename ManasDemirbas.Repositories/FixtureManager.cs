using ManasDemirbas.Domain;
using ManasDemirbas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManasDemirbas.Repositories
{
    public class FixtureManager : Fixture
    {
        public static IEnumerable<Fixture> GetAll()
        {
         
            // var fixtures = LoadTestData();

            var context = new FixtureContext();
            var fixtures = context.Fixtures.ToList();
            
            return fixtures;
        }

        // Ekleme
        public static void Add(Fixture fixture)
        {
            var context = new FixtureContext();
            context.Fixtures.Add(fixture);
            context.SaveChanges();
        }

        // Güncelleme
        public static void Update(Fixture fixture)
        {
            var context = new FixtureContext();
            var existingFixture = context.Fixtures.SingleOrDefault(a => a.Id == fixture.Id);

            existingFixture.Name = fixture.Name;
            existingFixture.Description = fixture.Description;
            existingFixture.Serial = fixture.Serial;
            existingFixture.VendorId = fixture.VendorId;
            existingFixture.FixtureCategoryId = fixture.FixtureCategoryId;
            context.SaveChanges();
        }

        // Personel ID'ye göre Demirbaş çekme
        public static IEnumerable<Fixture> GetFixturesByEmployee(int employeeId)
        {
            var context = new FixtureContext();

            return context.Fixtures.Where(a => a.EmployeeId == employeeId).ToList();
        }

        // Demirbaş ID'ye göre Demirbaş çekme
        public static IEnumerable<Fixture> GetAvailableFixturesByCategory(int categoryId)
        {
            var context = new FixtureContext();

            return context.Fixtures.
                Where(a => a.FixtureCategoryId == categoryId).
                Where(a => a.EmployeeId == null).
                ToList(); 
        }

        // Atanan demirbaşı personel üzerinden silme
        public static void RemoveFixtureFromEmployee(int fixtureId)
        {
            var context = new FixtureContext();
            Fixture ast = context.Fixtures.SingleOrDefault(a => a.Id == fixtureId);
            ast.EmployeeId = null;
            ast.DateAssigned = null;
            context.SaveChanges();
        }

        // Personele demirbaş atama
        public static void AssignFixturesToEmployee(int fixtureId, int employeeId)
        {
            var context = new FixtureContext();
            Fixture ast = context.Fixtures.SingleOrDefault(a => a.Id == fixtureId);
            ast.EmployeeId = employeeId;
            ast.DateAssigned = DateTime.Now;
            context.SaveChanges();
        }

        // Demirbaş kontrol
        public static bool CategoryFixtureAlreadyAssignedToEmployee(int fixtureCategoryId, int employeeId)
        {
            var context = new FixtureContext();
            var fixtures = context.Fixtures.
                Where(a => a.FixtureCategoryId == fixtureCategoryId).
                Where(a => a.EmployeeId == employeeId).
                ToList();

            if (fixtures.Count > 0)
            {
                return true;
            }

            return false;
        }

        // Deneme
        private static List<Fixture> LoadTestData()
        {
            var fixtures = new List<Fixture>();

            fixtures.Add(new Fixture
            {
                Id = 1,
                Name = "Intel Core i7 Masaüstü HP Prodesk",
                Description = "ARGE Yazılım için Masaüstü",
                Serial = "IC7ENG-001",
                VendorId = 1,
                FixtureCategoryId = 1
            });
            fixtures.Add(new Fixture
            {
                Id = 2,
                Name = "Hesap Makinası",
                Description = "Hesap Makinası",
                Serial = "NFAACAL-001",
                VendorId = 2,
                FixtureCategoryId = 2
            });
            fixtures.Add(new Fixture
            {
                Id = 3,
                Name = "Telefon",
                Description = "Satış Pazarlama için Siemens Sabit Telefon",
                Serial = "TTFSAL-001",
                VendorId = 3,
                FixtureCategoryId = 3
            });

            return fixtures;
        }
    }
}
