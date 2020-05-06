using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheReddit.Entities
{
    public class User : IdentityUser
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public string Password { get; set; }
        public List<Post> Posts { get; set; }

    }
}
