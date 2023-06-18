using EntityFramework.Models.Entities;

namespace EntityFramework.Models
{
    public class Role : Base
    {
        public string Name { get; set; }

        public string Slug { get; set; }
    }
}