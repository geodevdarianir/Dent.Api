using Entities.Models.Partner;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public class PartnerDbContext : DbContext
    {
        public PartnerDbContext(DbContextOptions<PartnerDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Art> Arts { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<EmployeesAtWork> EmployeesAtWorks { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Tooth> Teeth { get; set; }
        public virtual DbSet<TypeOfWork> TypeOfWorks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Work> Works { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
