using System;

namespace Entities.Models.Partner
{
    public class Salary : IEntity
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime WrittenDate { get; set; }
    }
}
