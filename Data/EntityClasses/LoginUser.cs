using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.EntityClasses
{
    public class LoginUser
    {

        [JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int LoginUserId { get; set; }
        public string LoginUserName { get; set; }
        public string LoginUserPassword { get; set; }


        public int UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; }

    }
}
