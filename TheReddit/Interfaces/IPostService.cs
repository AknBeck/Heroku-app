using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Entities;

namespace TheReddit.Interfaces
{
    public interface IPostService
    {
        List<Post> GetAllPosts();
        void CreatePost(Post post);
        void RatingUpOrDown(long incOrDec, long id);
    }
}
