using EfMapping.Models.Entities;

namespace EfMapping.Models
{
    public class Role : Base
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public List<User> Users { get; set; }
    }
}