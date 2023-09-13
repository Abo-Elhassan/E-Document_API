using EDocument_Data.Consts.Enums;
using EDocument_Data.Consts;
using EDocument_Data.DTOs.User;
using EDocument_Services.Auth_Service;
using EDocument_Services.Mail_Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EDocument_API.Controllers.V1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    // [ApiVersion("2.0")]
    public class ValuesController : ControllerBase
    {
        private readonly IMailService _mailService;

        public ValuesController(IMailService mailService)
        {
            _mailService = mailService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            (bool Succeeded, string Message, LoginReadDto? LoginReadDto) response = (false, "", null);

            try
            {
                //Path to your LDAP directory server
                Authentication adAuth = new Authentication(ApplicationConsts.ADPath);
                if (!adAuth.IsAuthenticated(ApplicationConsts.ADDomain, "almuhammad", "#FER#Del10#IT#"))
                {
                    response.Succeeded = false;
                    response.Message = $"Usermame or Password is incorrect";
                    return BadRequest(response);
                }

                return Ok(response);
            }
            catch (COMException ex)
            {
                response.Succeeded = false;
                response.Message = ex.Message;
                return BadRequest(response);
            }

        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
