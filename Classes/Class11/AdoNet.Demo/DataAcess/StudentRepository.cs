using AdoNet.Demo.Models;
using Microsoft.Data.SqlClient;

namespace AdoNet.Demo.DataAcess
{
    internal class StudentRepository
    {
        private readonly string _connectionString;

        public StudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            // 1) Establish the connection to the Database
            //SqlConnection sqlConnection = new SqlConnection(_connectionString);
            //sqlConnection.Open();
            //sqlConnection.Close();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                // 2)Write the SQL query
                string query = @"
                                ";
            }


            return students;
        }
    }
}
