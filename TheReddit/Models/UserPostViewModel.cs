using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Entities;

namespace TheReddit.Models
{
    public class UserPostViewModel
    {
        public Post Post { get; set; }
        public List<Post> Posts { get; set; }
        public User User { get; set; }
        public bool IsRegSuccess { get; set; }
        public bool IsLogSuccess { get; set; }
        public UserPostViewModel()
        {

        }
        public UserPostViewModel(List<Post> posts)
        {
            Posts = posts;
        }
        public UserPostViewModel(Post post)
        {
            Post = post;
        }
        public UserPostViewModel(bool isRegSuccess)
        {
            IsRegSuccess = isRegSuccess;
        }
    }
}
