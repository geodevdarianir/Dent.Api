using System;
using System.Collections;
using System.Collections.Generic;

namespace Entities.Models.Partner
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public Guid MainDbId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public double Nummber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Work> Works { get; set; }
        //   public double PriceSum { get; set; }
    }
}
