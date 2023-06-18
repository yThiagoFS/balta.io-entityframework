using EfMapping.Data;
using EfMapping.Models;

using var context = new BlogDataContext();

// context.Users.Add(new User 
// {
//     Name = "EfMapping",
//     Email = "efmapping@gmail.com",
//     Bio = "ef mapping test",
//     Image = "https://efmapping",
//     Slug = "ef-mapping",
//     PasswordHash = "efmappingpass"
// });

var user = context.Users.FirstOrDefault(x => x.Id == 17);

var post = new Post 
{
    Author = user,
    Body = "ef mapping article",
    Category = new Category { Name = "Mapping", Slug = "mapping" },
    CreatedDate = DateTime.Now,
    Slug = "my-article",
    Summary = "In this article, we're going...",
    Title = "My EF Article"
};

context.Posts.Add(post);
context.SaveChanges();
