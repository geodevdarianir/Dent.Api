using System;

namespace Entities.Models.Partner
{
    public class Payment : IEntity
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public Work Work { get; set; }
    }
}
