using AutoMapper;
using Common;
using Entities.Models.Main;
using Entities.ViewModels.Main;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
    public class PartnerDataMappingProfile : Profile
    {
        public PartnerDataMappingProfile()
        {
            CreateMap<Partner, PartnerModel>()
                .ForMember(dm => dm.ConnectionString, m => m.MapFrom(smp => smp.Connection))
                .ForMember(dm => dm.Name, m => m.MapFrom(smp => smp.Name)).ReverseMap();
        }
    }
}
