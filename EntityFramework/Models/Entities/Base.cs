using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models.Entities
{
    public abstract class Base 
    {
        [Key]
        public int Id { get; set; }
    }
}