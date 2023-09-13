using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace AdoNet02
{
    public partial class Form1 : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");

        private SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();

            adapter = new SqlDataAdapter("SELECT * from Employees", cnn);

            PopulateTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PopulateTable()
        {
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            new SqlCommandBuilder(adapter);
            var rowsChanged = adapter.Update((DataTable)dataGridView1.DataSource);
            
            PopulateTable();

            MessageBox.Show($"{rowsChanged} rows changed");
        }

        private void AddNewEmployee(object sender, EventArgs e)
        {
            var firstName = textBox1.Text;
            var lastName = textBox2.Text;

            //SqlCommand add = new SqlCommand($"INSERT INTO Employees (FirstName, LastName) VALUES ('{firstName}', '{lastName}')", cnn);

            SqlCommand add = new SqlCommand("INSERT INTO Employees (FirstName, LastName) VALUES (@FirstName, @LastName)", cnn);
            add.Parameters.AddWithValue("@FirstName", firstName);
            add.Parameters.AddWithValue("@LastName", lastName);

            cnn.Open();
            var rowsAdded = add.ExecuteNonQuery();
            cnn.Close();

            MessageBox.Show($"{rowsAdded} rows added");

            PopulateTable();
        }
    }
}
