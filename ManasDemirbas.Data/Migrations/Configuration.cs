namespace ManasDemirbas.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ManasDemirbas.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<ManasDemirbas.Data.FixtureContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            Database.SetInitializer<FixtureContext>(null);
        }

        protected override void Seed(ManasDemirbas.Data.FixtureContext context)
        {
          
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var departments = new Department[] {
                new Department { Name = "ARGE Yazýlým" },
                new Department { Name = "ARGE Donaným" },
                new Department { Name = "Satýþ Pazarlama" }
            };

            context.Departments.AddOrUpdate(d => d.Name, departments);
            context.SaveChanges();

            var dept1 = context.Departments.Find(1);
            var dept2 = context.Departments.Find(2);
            var dept3 = context.Departments.Find(3);

            var employees = new Employee[] {
                new Employee {
                    FirstName = "CuCuCuCu",
                    LastName = "Cosplay",
                    HireDate = new DateTime(2010, 12, 27),
                    DeskNumber = "ACC-03",
                    PhoneNumber = "403-928-7623",
                    Department = dept1
                },
                new Employee {
                    FirstName = "Korkusuz",
                    LastName = "Pegavus",
                    HireDate = new DateTime(2012, 1, 11),
                    DeskNumber = "ENG-12",
                    PhoneNumber = "587-432-8821",
                    Department = dept2
                },
                new Employee {
                    FirstName = "Pegavus",
                    LastName = "Zeytinyaðlý",
                    HireDate = new DateTime(2013, 8, 2),
                    DeskNumber = "SAL-08",
                    PhoneNumber = "403-226-2823",
                    Department = dept3
                }
            };

            context.Employees.AddOrUpdate(e => e.DeskNumber, employees);
            context.SaveChanges();

            var vendors = new Vendor[] {
                new Vendor { Name = "Messi Bilgisayar", PhoneNumber = "505-321-9452" },
                new Vendor { Name = "Lenovo Computer", PhoneNumber = "505-762-2971" },
                new Vendor { Name = "Vatan Bilgisayar", PhoneNumber = "505-902-7821" }
            };

            context.Vendors.AddOrUpdate(v => v.Name, vendors);
            context.SaveChanges();

            var fixtureCategories = new FixtureCategory[] {
                new FixtureCategory { Name = "Masaüstü Bilgisayar" },
                new FixtureCategory { Name = "Laptop Bilgisayar" },
                new FixtureCategory { Name = "Telefonlar" }
            };

            context.FixtureCategories.AddOrUpdate(ac => ac.Name, fixtureCategories);
            context.SaveChanges();

            var employee1 = context.Employees.Find(1);
            var employee2 = context.Employees.Find(2);
            var employee3 = context.Employees.Find(3);

            var vendor1 = context.Vendors.Find(1);
            var vendor2 = context.Vendors.Find(2);
            var vendor3 = context.Vendors.Find(3);

            var aCat1 = context.FixtureCategories.Find(1);
            var aCat2 = context.FixtureCategories.Find(2);
            var aCat3 = context.FixtureCategories.Find(3);

            var fixtures = new Fixture[] {
                new Fixture {
                    Name = "Intel Core i7 Desktop",
                    Description = "Desktop for Engineering Department",
                    Serial = "IC7ENG-001",
                    Vendor = vendor1,
                    FixtureCategory = aCat1,
                    Employee = employee2,
                    DateAssigned = new DateTime(2015,12,1)
                },
                new Fixture {
                    Id = 2,
                    Name = "Nasio Full Accounting",
                    Description = "Accounting Calculator",
                    Serial = "NFAACAL-001",
                    Vendor = vendor2,
                    FixtureCategory = aCat2,
                    Employee = employee1,
                    DateAssigned = new DateTime(2015,6,17)
                },
                new Fixture {
                    Id = 3,
                    Name = "Twinkle Telephone and Fax System",
                    Description = "Telephone and fax system for Sales Department",
                    Serial = "TTFSAL-001",
                    Vendor = vendor3,
                    FixtureCategory = aCat3,
                    Employee = employee3,
                    DateAssigned = new DateTime(2015,9,3)
                }
            };

            context.Fixtures.AddOrUpdate(a => a.Serial, fixtures);
            context.SaveChanges();
        }
    }
}
