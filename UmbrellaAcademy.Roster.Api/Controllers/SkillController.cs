using Microsoft.AspNetCore.Mvc;
using System.Net;
using UmbrellaAcademy.Roster.Data;

namespace UmbrellaAcademy.Roster.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    [Produces("application/json")]
    public class SkillController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public SkillController(IMemberService memberStore)
        {
            _memberService = memberStore;
        }

        [HttpGet]
        [Route("member")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]        
        public IActionResult GetMemberSkills(string skill)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
