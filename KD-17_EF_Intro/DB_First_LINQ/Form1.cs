using DB_First_LINQ.Contexts;
using DB_First_LINQ.Models;
using Microsoft.EntityFrameworkCore;

namespace DB_First_LINQ
{
    public partial class Form1 : Form
    {
        private NorthwindContext context;

        public Form1()
        {
            InitializeComponent();

            context = new NorthwindContext();

            IEnumerable<Employee> employees = context.Employees.ToList();

            dataGridView1.DataSource = context.Employees.Local.ToBindingList();

            dataGridView1.Columns["FirstName"].DisplayIndex = 1;
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            var RowsChanged = context.SaveChanges();

            dataGridView1.Refresh();

            MessageBox.Show($"{RowsChanged} rows changed");
        }

        private void Upsert(object sender, EventArgs e)
        {
            var id = int.Parse(string.IsNullOrWhiteSpace(employee_id.Text) ? "0" : employee_id.Text);
            var firstName = employee_firstname.Text;
            var lastName = employee_lastname.Text;

            if (id == 0)
            {
                // Insert
                var newEmployee = new Employee()
                {
                    FirstName = firstName,
                    LastName = lastName
                };
                context.Employees.Add(newEmployee);
                //context.Entry(newEmployee).State = EntityState.Added;
            }
            else
            {
                // Update
                Employee employeeFromDb = context.Employees.Find(id)!;
                employeeFromDb.FirstName = firstName;
                employeeFromDb.LastName = lastName;

                context.Employees.Update(employeeFromDb);
                //context.Entry(employeeFromDb).State = EntityState.Modified;
            }

            var RowsChanged = context.SaveChanges();

            dataGridView1.Refresh();

            MessageBox.Show($"{RowsChanged} rows changed");

        }

        private void Delete(object sender, EventArgs e)
        {
            // Get Id
            var id = (int)dataGridView1.CurrentRow.Cells["EmployeeId"].Value;

            // Get Employee with Id
            //var employeeToRemove = new Employee() { EmployeeId = id };
            var employeeToRemove = context.Employees.Find(id)!;

            // Delete Employee
            //context.Entry(employeeToRemove).State = EntityState.Deleted;
            context.Employees.Remove(employeeToRemove);

            // Save Changes
            var RowsChanged = context.SaveChanges();

            dataGridView1.Refresh();

            MessageBox.Show($"{RowsChanged} rows changed");
        }
    }
}
