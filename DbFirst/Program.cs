

using DbFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext(DbContextInitializer.optionsBuilder.Options))
{
    var product = await _context.Products.ToListAsync();

    Console.WriteLine("Id : İsim");
    product.ForEach(p => 
    {
        

        Console.WriteLine($"{p.Id}  : {p.Name}");

    });
    Console.WriteLine("Id : İsim");
}