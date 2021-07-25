using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities.Models.Main;
using Entities.Models.Partner;
using Entities.ViewModels.Dent;
using Entities.ViewModels.Main;

namespace Entities.Mapping
{
    public class DentMappingProfile : Profile
    {
        public DentMappingProfile()
        {
            PartnerDataMappingProfile();
            ArtMapping();
        }

        private void PartnerDataMappingProfile()
        {
            CreateMap<Partner, PartnerModel>()
                   .ForMember(dm => dm.ConnectionString, m => m.MapFrom(smp => smp.Connection))
                   .ForMember(dm => dm.Name, m => m.MapFrom(smp => smp.Name)).ReverseMap();
        }

        private void ArtMapping()
        {
            CreateMap<ArtModel, Art>().ReverseMap();
        }
    }
}
