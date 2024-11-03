

using DbFirst.DAL;
using Microsoft.EntityFrameworkCore;

using (var _context = new AppDbContext())
{
    var product = await _context.Products.ToListAsync();

    Console.WriteLine("Id : İsim");
    product.ForEach(p => 
    {
        

        Console.WriteLine($"{p.Id}  : {p.Name}");

    });
    Console.WriteLine("Id : İsim");
}