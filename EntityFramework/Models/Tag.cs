using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EntityFramework.Models.Entities;

namespace EntityFramework.Models
{
    [Table("Tag")]
    public class Tag : Base
    {
        public string Name { get; set; }        

        public string Slug { get; set; }
    }
}