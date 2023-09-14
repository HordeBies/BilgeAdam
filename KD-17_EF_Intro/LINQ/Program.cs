// See https://aka.ms/new-console-template for more information

// Libraries
// Microsoft.EntityFrameworkCore.SqlServer
// Microsoft.EntityFrameworkCore.Tools
// Microsoft.EntityFrameworkCore.Design

// Console command
// Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
// scaffold-dbcontext "connection-string" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Contexts -Context NorthwindContext

// LETS LINQ

// CTRL + K + D = Format the document
#region Where 
using LINQ.Contexts;
using LINQ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
// Where();

void Where()
{
    string[] words = { "the", "quick", "brown", "fox", "jumps" };

    var filteredWords = words.Where(item => item.Count() == 3);

    filteredWords.ToList().ForEach(r => Console.WriteLine(r));

    Console.WriteLine();

    var filteredWords2 = from item in words
                         where item.Count() == 3
                         select item;

    filteredWords2.ToList().ForEach(r => Console.WriteLine(r));
}
#endregion


#region Select





void Select()
{
    using var context = new NorthwindContext();

    var employees = context.Employees.Select(employee => new
    {
        employee.FirstName,
        employee.LastName,
        ReportsToName = employee.ReportsToNavigation.FirstName + " " + employee.ReportsToNavigation.LastName
    }).ToList();

    employees.ForEach(employee => Console.WriteLine($"{employee.FirstName} {employee.LastName} reports to {employee.ReportsToName}"));

    Console.WriteLine();

    var employees2 = (from employee in context.Employees
                      select new
                      {
                          employee.FirstName,
                          employee.LastName,
                          ReportsToName = employee.ReportsToNavigation.FirstName + " " + employee.ReportsToNavigation.LastName
                      }).ToList();

    employees2.ForEach(employee => Console.WriteLine($"{employee.FirstName} {employee.LastName} reports to {employee.ReportsToName}"));
}

//Select();

#endregion

#region Sorting

void Sorting()
{
    string[] words = { "the", "quick", "brown", "test", "fox", "jumps" };
    //var orderedWords = words.OrderBy(w => w.Length); // Order by length
    //orderedWords = orderedWords.ThenBy(w => w); // Order by character
    var orderedWords = words.OrderBy(w => w.Length).ThenBy(w => w); // Order by length then character
    orderedWords.ToList().ForEach(Console.WriteLine);

}
//Sorting();
#endregion

#region Quantifiers
void Quantifiers()
{
    string[] words = { "the", "quick", "brown", "test", "fox", "jumps" };

    var isThereAny = words.Any(r => r.StartsWith('t'));

    var isThereAnyThe = words.Contains("the");

    Console.WriteLine($"is there any that starts with a 't': {isThereAny}");
    Console.WriteLine($"is there any that is 'the': {isThereAnyThe}");
}
//Quantifiers();
#endregion

#region Partitioning
void Partitioning()
{
    using var context = new NorthwindContext();

    int totalPages = 10;
    int pageSize = 10;

    for (int pageNumber = 1; pageNumber <= totalPages; pageNumber++)
    {
        Console.WriteLine($"Page #{pageNumber}");

        var result = context.Orders.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();

        result.ForEach(result => Console.WriteLine($"{result.OrderId} {result.CustomerId} {result.OrderDate} {result.ShippedDate} {result.Freight}"));

        Console.WriteLine();
    }
}
//Partitioning();
#endregion


//string[] words = { "the", "quick", "brown", "test", "fox", "jumps" };
//List<string> words2 = new() { "the", "quick", "brown", "test", "fox", "jumps" };
//if (words.SequenceEqual(words2)) 



// Join
void Join()
{
    using var context = new NorthwindContext();

    var test = context.Orders.Join(context.Customers, order => order.CustomerId, customer => customer.CustomerId, (order, customer) => new
    {
        order.OrderId,
        order.CustomerId,
        order.OrderDate,
        order.ShippedDate,
        order.Freight,
        order.ShipVia,
        customer.CompanyName
    }).Join(context.Shippers, orderCustomers => orderCustomers.ShipVia, shippers => shippers.ShipperId, (oc, shippers) => new
    {
        oc.OrderId,
        oc.CustomerId,
        oc.OrderDate,
        oc.ShippedDate,
        oc.Freight,
        ShipmentCompany = shippers.CompanyName,
        CustomerCompany = oc.CompanyName
    }).GroupBy(r => r.ShipmentCompany).ToList();

    foreach (var group in test)
    {
        Console.WriteLine("Company Name: " + group.Key);

        foreach (var item in group)
        {
            Console.WriteLine($"\t{item.OrderId} {item.CustomerId} {item.OrderDate} {item.ShippedDate} {item.Freight} {item.ShipmentCompany} {item.CustomerCompany}");
        }
    }
}
Join();