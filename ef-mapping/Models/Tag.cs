using EfMapping.Models.Entities;

namespace EfMapping.Models
{
    public class Tag : Base
    {
        public string Name { get; set; }        

        public string Slug { get; set; }

        public List<Post> Posts { get; set; }
    }
}