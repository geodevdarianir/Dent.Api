using System;
using System.Collections.Generic;

namespace Entities.Models.Partner
{
    public class Work : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string PatientName { get; set; }
        public double Price { get; set; }
        public double RestMoney { get; set; }
        public double PaidMoney { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; } // //aqtiuri,dawyebuli(in progress),dasrulebuli
        public ICollection<User> Users { get; set; }
    }
}
