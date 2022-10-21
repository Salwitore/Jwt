using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Configuration;
using System.Text;
using Utils.Auth;
using Utils.JWT;
using Data.EntityClasses;
using Microsoft.AspNetCore.Authorization;
using Utils.Helpers;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] //Controllerdaki Action metodları [Authorize] attribute’ü kullanılarak JWT ile korunmaktadır.
    public class LoginController : ControllerBase
    {

        //[HttpPost("AddLoginUser")]

        //public IActionResult AddLoginUser(LoginUser loginUser)
        //{
        //    try
        //    {
        //        new Authentication().AddLoginUser(loginUser);
        //        return Created("", loginUser);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);   
        //    }
        //}

        //[AllowAnonymous] //[AllowAnonymous] attribute’ü kullanarak ise public erişim’e izin vermiş oluruz.
        


        //[HttpPost("Login")]
        //public IActionResult Login(LoginUser loginUser)
        //{
        //    var jwtFactory = new JWTFactory();
        //}

    }
}
