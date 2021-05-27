using Entities.Models.Main;
using Entities.ViewModels.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Main
{
    public interface IPartnerService
    {
        Task<PartnerModel> AddPartner(PartnerModel partnerModel);
    }
}
