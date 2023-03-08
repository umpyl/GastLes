using Microsoft.AspNetCore.Mvc;
using System.Net;
using UmbrellaAcademy.Roster.Api.Models;
using UmbrellaAcademy.Roster.Data;

namespace UmbrellaAcademy.Roster.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberStore)
        {
            _memberService = memberStore;
        }

        [HttpGet]
        [ProducesResponseType(typeof(MemberViewModel[]), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult GetMembers([FromQuery] int pageSize = 10, [FromQuery] int pageIndex = 0)
        {
            try
            {
                var members = _memberService.GetMembers(pageSize, pageIndex);
                return Ok(members);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpGet]
        [Route("{number}")]
        [ProducesResponseType(typeof(MemberViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public IActionResult GetMember(short number)
        {
            try
            {
                var member = _memberService.GetMember(number);
                return Ok(member);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}