using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Data.Enums;

namespace Data.EntityClasses
{
    public class User
    {
        [JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key,Column(Order = 0)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string Email { get; set; }
        public  Roles  Role { get; set; }


        [JsonIgnore]
        public string? Token { get; set; }


        [JsonIgnore]
        public IList<UserTicket>? UserTickets { get; set; }

        [JsonIgnore]
        public LoginUser? LoginUser { get; set; }

        
    }
}
