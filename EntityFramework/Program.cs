using EntityFramework.Data;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();

#region Modulo 1 

   // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };

    // // context.Tags.Add(tag);
    // // context.SaveChanges();

    // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);

    // tag.Name = ".NET";
    // tag.Slug = "dotnet";

    // context.Tags.Update(tag);
    // context.SaveChanges();

    // /*Para leitura, utilizar AsNoTracking() para trazer a query de forma mais performática*/
    // //Ao ler como AsNoTracking, ele entende como um objeto novo, por conta disso, não posso utilizar para selecionar um elemento e fazer um update/delete, apenas leitura.

    // var tags = context.Tags.AsNoTracking().ToList();

    // foreach(var tagg in tags)
    //     Console.WriteLine($"{tagg.Name}");
#endregion

#region Modulo 2 
    // var user = new User 
    // {
    //     Name = "Name",
    //     Slug = "slug-user",
    //     Email = "email@123.com",
    //     Bio = "Developer",
    //     Image = "https://",
    //     PasswordHash = "0123456",
    // };

    // var category = new Category 
    // {
    //     Name = "Backend",
    //     Slug = "backend"
    // };

    // var post = new Post 
    // {
    //     Author = user,
    //     Category = category,
    //     Body = "Hello world",
    //     Slug = "getting-start-with-ef-core2",
    //     Summary = "we are going to learn ef-core",
    //     Title = "Getting started with ef core",
    //     CreatedDate = DateTime.Now,
    //     LastUpdateDate = DateTime.Now
    // };

    // context.Posts.Add(post);
    // context.SaveChanges();

    //o EF Gerencia tudo em memória, faz a adição do user e da category e após isso, cria o post relacionando-os.

    var posts = context
        .Posts
        .AsNoTracking()
        .Include(x => x.Author)
        .Include(x => x.Category)
        //ThenInclude -> fica incluso na categoria (caso a categoria tivesse um relacionamento por exemplo)
        //.ThenInclude(x => x.Propriedade da Categoria)
        .Where(x => x.AuthorId == 14) // Por ter o AuthorId na classe, não é necessário fazer um inner join com o Author
        .OrderBy(x => x.LastUpdateDate)
        .ToList();

        //Por padrão, o EF não preenche os objetos automáticamente
        //Exemplo: não traz o autor no Post
        //Por isso, devemos usar o INCLUDE.

        foreach(var post in posts)
            Console.WriteLine($"{post.Title} - Escrito por: {post.Author?.Name} em {post.Category?.Name}");
#endregion



 
