using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Partner
{
    // Mitarbeiter der Arbeit
    public class EmployeesAtWork : IEntity
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public bool IsFromAdminAccepted { get; set; }
        public Work Work { get; set; }
        public User User { get; set; }
    }
}
