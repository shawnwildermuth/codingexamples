using System.Collections;
using ComposingLinq.Data;
using ComposingLinq.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using static System.Console;

var coll = new ServiceCollection();
coll.AddDbContext<ProductContext>(ServiceLifetime.Transient);
var svcs = coll.BuildServiceProvider();

var ctx = svcs.GetRequiredService<ProductContext>();

List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

// Query Syntax
IEnumerable<int> qrySyntax =
    from num in numbers
    where num % 2 == 0
    orderby num
    select num;

WriteLine(string.Join(",", qrySyntax));

// Method Syntax
IEnumerable<int> methodSyntax = numbers
  .Where(n => n % 2 == 0)
  .OrderBy(n => n)
  .ToList();

WriteArray(methodSyntax);

var excludeFours = true;

// Composing Linq
var qry = numbers.Where(n => n % 2 == 0);

if (excludeFours)
{
  // Extend the Query
  qry = qry.Where(n => n % 4 != 0);
}

// Add more linq operations
qry = qry.OrderBy(n => n);

var noFours = qry.ToList();

// Execute the final query
WriteArray(noFours);

bool dateOrder = true;

IQueryable<Order> query = ctx.Orders
  .Include(o => o.Items);;

if (dateOrder) query = query.OrderByDescending(o => o.OrderDate);

var result = await query.ToListAsync();

WriteLine(result.Count());



void WriteArray(IEnumerable<int> array) => WriteLine(string.Join(",", array));