using Entities.ViewModels.Main;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Main;
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
            try
            {
                var result = await _partnerService.AddPartner(partner);
                return Ok(new { result = $"პარტნიორი '{result.Name}' დაემატა მონაცემთა ბაზას!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message, error = ex.InnerException });
            }
        }
    }
}
