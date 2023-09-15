// See https://aka.ms/new-console-template for more information
using CodeFirst.Data;
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

// Context +

// Model(s) +

// Migrations +

// Update-Database +

using var context = new AppDbContext();

////CREATE
//var product = new Product
//{
//   Name = "Product 1",
//   Price = 100.0m,
//   Description = "Description 1"
//};
//context.Products.Add(product);
//context.SaveChanges();


////READ
//var productNames = context.Products.Select(r => r.Name).ToList();
//productNames.ForEach(Console.WriteLine);

////UPDATE

////Scenario 1
//var productToUpdate = context.Products.First(r => r.Name == "Product 1");
//productToUpdate.Description = "Description 1 updated";
//context.SaveChanges();


////Scenario 2
//var p2 = new Product
//         {
//             Id = 1,
//             Name = "Product 1",
//             Price = 200.0m,
//             Description = "Description 2"
//         };
//p2.Name = "Product 13";
//context.Products.Update(p2);
//context.SaveChanges();

////DELETE

////Scenario 1
//context.Products.Remove(new Product { Id = 1 });
////Scenario 2
//var productToDelete = context.Products.Find(1);
//if (productToDelete is null) Console.WriteLine("There are no such product with id " + 1);
//else context.Products.Remove(productToDelete);

//context.SaveChanges();

//var p1 = new Product
//{
//    Name = "Product 1",
//    Price = 100.0m,
//    Description = "Description 1"
//};

//var p2 = new Product
//{
//    Name = "Product 2",
//    Price = 200.0m,
//    Description = "Description 2"
//};

//context.Products.AddRange(new Product[]{ p1, p2 });
//context.SaveChanges();


var products = context.Products.Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }).ToList();

products.ForEach(r => Console.WriteLine($"{r.Name} {r.Price} {r.CategoryName}"));