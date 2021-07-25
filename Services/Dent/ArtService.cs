using AutoMapper;
using Entities.Models.Partner;
using Entities.ViewModels.Dent;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dent
{
    public class ArtService: IArtService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Art> _repository;
        public ArtService(IMapper mapper, IRepository<Art> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ArtModel> AddArt(ArtModel art)
        {
            Art tempArt = _mapper.Map<Art>(art);
            Art result = await _repository.CreateAsync(tempArt);
            ArtModel resultMap = _mapper.Map<ArtModel>(result);
            return resultMap;
        }
    }
}
