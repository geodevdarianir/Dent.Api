using Entities.ViewModels.Dent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Dent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dent.Api.Controllers.Partner
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly IArtService _artService;
        public CharacterController(IArtService artService)
        {
            _artService = artService;
        }

        [HttpPost]
        public async Task<IActionResult> AddArt(ArtModel art)
        {
            try
            {
                var result = await _artService.AddArt(art);
                return Ok(new { result = $"სახეობა '{result.Name}' დაემატა მონაცემთა ბაზას!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message, error = ex.InnerException });
            }
        }
    }
}
