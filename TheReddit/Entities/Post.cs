using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheReddit.Entities
{
    public class Post
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Url { get; set; }
        [DefaultValue(0)]
        public long Likes { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        public User Owner { get; set; }

        public Post()
        {
            DateTime = DateTime.Now;
        }
    }
}
