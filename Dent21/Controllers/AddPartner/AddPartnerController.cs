using Entities.ViewModels.Main;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Partners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dent.Api.Controllers.AddPartner
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddPartnerController : ControllerBase
    {
        private readonly IPartnerService _partnerService;
        public AddPartnerController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        [HttpPost]
        public async Task<IActionResult> AddPartner(PartnerModel partner)
        {
            await _partnerService.AddPartner(partner);
            return Ok();
        }
    }
}
