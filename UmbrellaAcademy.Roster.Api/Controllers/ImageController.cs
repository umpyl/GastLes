using Microsoft.AspNetCore.Mvc;
using System.Net;
using UmbrellaAcademy.Roster.Data;

namespace UmbrellaAcademy.Roster.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    [Produces("application/json")]
    public class ImageController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public ImageController(IMemberService memberStore)
        {
            _memberService = memberStore;
        }

        [HttpGet]
        [Route("member/{number}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]        
        public IActionResult GetMemberImage(short number)
        {
            try
            {
                var member = _memberService.GetMember(number);
                if (member == null)
                {
                    return NotFound("Member not found.");
                }

                var image = member.Images?.ElementAtOrDefault(0);

                return Ok(image);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }
}
