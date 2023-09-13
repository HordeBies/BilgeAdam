using AdoNet01;
using System.Data.SqlClient;
# nullable disable

SqlConnection cnn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");

SqlCommand cmd = new SqlCommand("SELECT * from Employees", cnn);
//cmd.Connection = cnn;

cnn.Open();

SqlDataReader reader = cmd.ExecuteReader();

List<Employee> employees = new();

while (reader.Read())
{
    string firstName = reader["FirstName"].ToString();
    string lastName = reader["LastName"].ToString();
    string city = reader["City"]?.ToString();

    // 3. New Employee
    employees.Add(new Employee
    {
        FirstName = firstName,
        LastName = lastName,
        City = city
    });
}

cnn.Close();

// 4. Print Employees
//employees.ForEach(e => Console.WriteLine($"{e.FirstName} {e.LastName} {e.City}"));

foreach (var e in employees)
{
    Console.WriteLine($"{e.FirstName} {e.LastName} {e.City}");
}