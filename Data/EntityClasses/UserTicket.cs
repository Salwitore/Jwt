using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.EntityClasses
{
    public class UserTicket
    {
        
        public int UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; }
        public int TicketId { get; set; }
        [JsonIgnore]
        public Ticket? Ticket { get; set; }
    }
}
