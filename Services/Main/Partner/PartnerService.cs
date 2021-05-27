using AutoMapper;
using Common;
using Entities.Context;
using Entities.Models.Main;
using Entities.ViewModels.Main;
using Helper;
using Repositories.Repository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Main
{
    public class PartnerService : IPartnerService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Partner> _partner;
        public PartnerService(IMapper mapper, IRepository<Partner> partner)
        {
            _mapper = mapper;
            _partner = partner;
        }

        public async Task<PartnerModel> AddPartner(PartnerModel partnerModel)
        {
            partnerModel.ConnectionString = EncryptionService.EncryptString(partnerModel.ConnectionString, AppConfiguration.Key);
            var tempPartner = _mapper.Map<Partner>(partnerModel);
            var result = await _partner.CreateAsync(tempPartner);
            return _mapper.Map<PartnerModel>(result);
        }
    }
}
