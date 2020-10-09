using System.Collections.Generic;

namespace VMindbookeClient.Domain
{
    public class User
    {
        public int Id { get; set; }
        
        public string Token { get; set; }
        
        public string Name { get; set; }
        
        public List<Like> Likes { get; set; }

        public void AddLike(Like like)
        {
            lock (Likes)
            {
                Likes.Add(like);
            }
        }
    }
}