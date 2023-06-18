using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EntityFramework.Models.Entities;

namespace EntityFramework.Models
{
    [Table("Post")]
    public class Post : Base
    {
        public string Title { get; set; }

        public string Summary { get; set; }

        public string Body { get; set; }

        public string Slug { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        //Propriedade de NAVEGAÇÃO -> referencia uma categoria através do CategoryId
        public Category Category { get; set; }

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }

        public User Author { get; set; }
    }
}