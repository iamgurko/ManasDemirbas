using ManasDemirbas.Data;
using ManasDemirbas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManasDemirbas.Repositories
{
    public class VendorManager : Vendor
    {
        public static IEnumerable<Vendor> GetAll()
        {
           
            // var vendors = LoadTestData();

            var context = new FixtureContext();
            var vendors = context.Vendors.ToList();

            return vendors;
        }

        // Ekleme
        public static void Add(Vendor ven)
        {
            var context = new FixtureContext();
            context.Vendors.Add(ven);
            context.SaveChanges();
        }

        // Güncelleme
        public static void Update(Vendor ven)
        {
            var context = new FixtureContext();
            var existingVen = context.Vendors.SingleOrDefault(v => v.Id == ven.Id);

            existingVen.Name = ven.Name;
            context.SaveChanges();
        }

        // Deneme Data
        private static List<Vendor> LoadTestData()
        {
            var vendors = new List<Vendor>();

            vendors.Add(new Vendor { Id = 1, Name = "Pegavus Computer", PhoneNumber = "505-505-5005" });
            vendors.Add(new Vendor { Id = 2, Name = "Messi Computer", PhoneNumber = "505-505-5005" });
            vendors.Add(new Vendor { Id = 3, Name = "Cuma Zeytinyağları", PhoneNumber = "505-505-5005" });

            return vendors;
        }
    }
}
