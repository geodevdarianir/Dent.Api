using Entities.Context;
using Entities.Models.Main;
using Entities.ViewModels.Main;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Partners
{
    public class PartnerService : IPartnerService
    {
        private readonly IRepository<Partner> _partner;
        private readonly MainDbContext _context;
        public PartnerService(IRepository<Partner> partner, MainDbContext context)
        {
            _partner = partner;
            _context = context;
        }

        public async Task<Partner> AddPartner(PartnerModel partnerModel)
        {
            return await _partner.CreateAsync(new Partner()
            {
                Connection = partnerModel.ConnectionString,
                Name = partnerModel.Name,
            }
            );
        }

    }
}
