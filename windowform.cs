using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataApp
{
    public partial class Form1 : Form
    {
        // Database connection string
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\ContactDB.mdf;
              Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Form Load Event
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Load data into DataGridView
        private void LoadData()
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM student";

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, connection);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading data:\n" + ex.Message);
                }
            }
        }

        // Add Student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() == "" ||
                txtLastName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "First Name and Last Name are required.");
                return;
            }

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query =
                    @"INSERT INTO student
                    (first_name, last_name, email, enrollment_date)
                    VALUES
                    (@first_name, @last_name, @email, @date)";

                    SqlCommand command =
                        new SqlCommand(query, connection);

                    command.Parameters.AddWithValue(
                        "@first_name",
                        txtFirstName.Text.Trim());

                    command.Parameters.AddWithValue(
                        "@last_name",
                        txtLastName.Text.Trim());

                    if (txtEmail.Text.Trim() == "")
                    {
                        command.Parameters.AddWithValue(
                            "@email", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(
                            "@email",
                            txtEmail.Text.Trim());
                    }

                    command.Parameters.AddWithValue(
                        "@date",
                        dtpEnrollmentDate.Value.Date);

                    command.ExecuteNonQuery();

                    MessageBox.Show(
                        "Student added successfully!");

                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Insert Error:\n" + ex.Message);
                }
            }
        }

        // Delete Student
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a row.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Delete this student?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            try
            {
                int studentId = Convert.ToInt32(
                    dataGridView1.CurrentRow
                    .Cells["student_id"].Value);

                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query =
                        "DELETE FROM student WHERE student_id=@id";

                    SqlCommand command =
                        new SqlCommand(query, connection);

                    command.Parameters.AddWithValue(
                        "@id", studentId);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Student deleted successfully.");

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Delete Error:\n" + ex.Message);
            }
        }

        // Clear Fields
        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();

            dtpEnrollmentDate.Value = DateTime.Now;

            txtFirstName.Focus();
        }
    }
}