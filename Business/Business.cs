using Data;
using Data.EntityClasses;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MasterBusiness
    {

        public void AddUser(User user)
        {
            new MasterDataAccess().AddUser(user);
        }

        public User DeleteUser(int userId)
        {   
            var masterDataAccess = new MasterDataAccess();
            var user = masterDataAccess.GetUsers().Where(user => user.UserId == userId).First();
            masterDataAccess.DeleteUser(user);
            return user;
        }
        public User GetUser(int userId)
        {
            var user = new MasterDataAccess().GetUsers().Where(user => user.UserId == userId).First();
            return user;
        }
        public IEnumerable<User> GetUsers()
        {
            return new MasterDataAccess().GetUsers();
        }
        public void AddTicket(Ticket ticket)
        {
            new MasterDataAccess().AddTicket(ticket);
        }
        public Ticket GetTicket(int ticketId)
        {
            var ticket = new MasterDataAccess().GetTickets().Where(ticket => ticket.TicketId == ticketId).First();
            return ticket;
        }
        public Ticket DeleteTicket(int ticketId)
        {
            var masterDataAccess = new MasterDataAccess();
            var ticket = masterDataAccess.GetTickets().Where(ticket => ticket.TicketId == ticketId).First();
            masterDataAccess.DeleteTicket(ticket);
            return ticket;
        }
        public User UpdateUser(User updateUser,int userId)
        {
            var masterDataAccess = new MasterDataAccess();
   
            var updatedUser = masterDataAccess.UpdateUser(updateUser,userId);
            return updatedUser;
        }


    }
}
