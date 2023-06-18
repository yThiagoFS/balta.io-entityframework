using EntityFramework.Models.Entities;

namespace EntityFramework.Models
{
    public class Category : Base
    {
        public string Name { get; set; }

        public string Slug { get; set; }
    }
}