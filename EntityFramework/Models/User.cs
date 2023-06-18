using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EntityFramework.Models.Entities;

namespace EntityFramework.Models
{
    [Table("User")]
    public class User : Base
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Bio { get; set; }

        public string Image { get; set; }

        public string Slug { get; set; }
    }
}