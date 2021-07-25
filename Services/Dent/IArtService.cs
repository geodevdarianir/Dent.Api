using Entities.ViewModels.Dent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dent
{
    public interface IArtService
    {
        Task<ArtModel> AddArt(ArtModel art);
    }
}
