using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace forum.Controllers
{
    [Route("api/threads")]
    public class ThreadsController : Controller
    {
        [HttpGet()]
        public IEnumerable<Models.Thread> Threads(int page)
        {
            IEnumerable<Models.Thread> result = new List<forum.Models.Thread>();

            return result;
        }

        [HttpGet("{threadID}/posts")]
        public IEnumerable<Models.Post> Posts(int threadID, int page)
        {
            List<Models.Post> result = new List<Models.Post>();
            result.Add(new Models.Post(threadID));
            return result;
        }

        [HttpPatch("{threadID}/posts/{postID}")]
        public String PatchPost(int threadID, int postID)
        {
            return $"threadID: {threadID}, postID: {postID}";
        }

        [HttpPost("{threadID}/posts/{postID}/like")]
        public String LikePost(int threadID, int postID)
        {
            return $"threadID: {threadID}, postID: {postID}";
        }

        [HttpDelete("{threadID}/posts/{postID}/like")]
        public String UnlikePost(int threadID, int postID)
        {
            return $"threadID: {threadID}, postID: {postID}";
        }
    }
}
