using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Database;
using TheReddit.Entities;
using TheReddit.Interfaces;

namespace TheReddit.Services
{
    public class PostDBService : IPostService
    {
        public ApplicationDBContext Context { get; set; }

        public PostDBService(ApplicationDBContext context)
        {
            Context = context;
        }

        public List<Post> GetAllPosts()
        {
            return Context.Posts.OrderByDescending(f => f.Likes).Take(10).ToList();
        }

        public void CreatePost(Post post)
        {
            Context.Posts.Add(post);
            Context.SaveChanges();
        }
        public void RatingUpOrDown(long incOrDec, long id)
        {
            var post = Context.Posts.Find(id);
            post.Likes += incOrDec;
            Context.SaveChanges();
        }

    }
}
