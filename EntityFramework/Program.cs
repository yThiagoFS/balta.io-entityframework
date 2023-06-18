using EntityFramework.Data;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

using(var context = new BlogDataContext())
{
    // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };

    // context.Tags.Add(tag);
    // context.SaveChanges();

    var tag = context.Tags.FirstOrDefault(x => x.Id == 1);

    tag.Name = ".NET";
    tag.Slug = "dotnet";

    context.Tags.Update(tag);
    context.SaveChanges();

    /*Para leitura, utilizar AsNoTracking() para trazer a query de forma mais performática*/
    //Ao ler como AsNoTracking, ele entende como um objeto novo, por conta disso, não posso utilizar para selecionar um elemento e fazer um update/delete, apenas leitura.

    var tags = context.Tags.AsNoTracking().ToList();

    foreach(var tagg in tags)
        Console.WriteLine($"{tagg.Name}");
}