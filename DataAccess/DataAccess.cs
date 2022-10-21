using Data;
using Data.ContextClasses;
using Data.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MasterDataAccess
    {
        public IEnumerable<User> GetUsers()
        {
            var mastercontext = new MasterContext();
            return mastercontext.Users.ToList();
        }
        public IEnumerable<Ticket> GetTickets()
        {
            var mastercontext = new MasterContext();
            return mastercontext.Tickets.ToList();
        }

        public void AddUser(User user) 
        {
            var masterContext = new MasterContext();
            masterContext.Users.Add(user);
            masterContext.SaveChanges();
        }
        public void AddTicket (Ticket ticket)
        {
            var masterContext = new MasterContext();
            masterContext.Tickets.Add(ticket);
            masterContext.SaveChanges();
        }
        public void DeleteUser(User user)
        {
            var masterContext = new MasterContext();
            masterContext.Users.Remove(user);
            masterContext.SaveChanges();
        }
        public void DeleteTicket(Ticket ticket)
        {
            var masterContext = new MasterContext();
            masterContext.Tickets.Remove(ticket);
            masterContext.SaveChanges();
        }
        public User UpdateUser(User updateUser,int userId)
        {
            var masterContext = new MasterContext();
            var user = masterContext.Users.Where(user => user.UserId == userId).First();
            user.UserName = updateUser.UserName;
            user.UserSurname = updateUser.UserSurname;
            user.Email = updateUser.Email;
            user.Role = updateUser.Role;
            masterContext.SaveChanges();

            return user;

        }
        public IEnumerable<LoginUser> GetLoginUsers()
        {
            var masterContext = new MasterContext();
            var loginUsers = masterContext.LoginUsers.ToList();
            return loginUsers;
        }

        public void AddLoginUser(LoginUser loginUser)
        {
            var mastercontext = new MasterContext();
            mastercontext.LoginUsers.Add(loginUser);
        }

    }
}
