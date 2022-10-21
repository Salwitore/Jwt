using Business;
using Data;
using Data.EntityClasses;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {

        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser(User user)
        {
            try
            {
                new MasterBusiness().AddUser(user);
                return Created("", user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddTicket")]
        public IActionResult AddTicket(Ticket ticket)
        {
            try
            {
                new MasterBusiness().AddTicket(ticket);
                return Created("", ticket);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int userId)
        {
            try
            {
                var user = new MasterBusiness().DeleteUser(userId);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPatch("UpdateUser")]
        public IActionResult UpdateUser(User updatedUser, int userId)
        {
            try
            {
                var user = new MasterBusiness().UpdateUser(updatedUser, userId);
                return Ok(user);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }
        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            return Ok(new MasterBusiness().GetUsers());
        }
        [HttpGet("GetUser")]
        public IActionResult GetUser(int userId)
        {
            try
            {
                return Ok(new MasterBusiness().GetUser(userId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddLoginUser")]
        public IActionResult AddLoginUser(LoginUser loginUser)
        {
            try
            {
                return Ok(new MasterBusiness().ad)
            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}