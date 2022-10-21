using Data.EntityClasses;
using DataAccess;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.JWT;
using System.Security.Claims;
using Utils.Helpers;

namespace Utils.Auth
{
    public class Authentication
    {
        //Authentication


        

        
        
        //public bool LoginControl(LoginUser loginUser)
        //{
        //    var masterDataAccess = new MasterDataAccess();

        //    var loginUsers = masterDataAccess.GetLoginUsers();

        //    foreach (var item in loginUsers)
        //    {
        //        if (loginUser.LoginUserName.Equals(item.LoginUserName) && loginUser.LoginUserPassword.Equals(item.LoginUserPassword))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        
    }
}
