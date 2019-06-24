using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManasDemirbas.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string DeskNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual IEnumerable<Fixture> Fixtures { get; set; }

        public override string ToString()
        {
            return FirstName + ", " + LastName;
        }
    }
}
