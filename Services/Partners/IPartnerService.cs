using Entities.Models.Main;
using Entities.ViewModels.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Partners
{
    public interface IPartnerService
    {
        Task<Partner> AddPartner(PartnerModel partnerModel);
    }
}
