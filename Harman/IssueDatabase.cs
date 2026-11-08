using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Harman
{
    // Handles all database work for facilities issues using ADO.NET.
    public class IssueDatabase
    {
        private string connectionString;

        public IssueDatabase()
        {
            string dbPath = Path.Combine(Application.StartupPath, "FacilitiesIssueDB.mdf");
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30";
        }

        public DataTable GetAllIssues()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT IssueID, Location, IssueCategory, Description, DateReported, Priority, Status, ReportedBy FROM FacilitiesIssues ORDER BY IssueID";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(table);
            }

            return table;
        }

        public void AddIssue(FacilitiesIssue issue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO FacilitiesIssues (Location, IssueCategory, Description, DateReported, Priority, Status, ReportedBy) " +
                             "VALUES (@Location, @IssueCategory, @Description, @DateReported, @Priority, @Status, @ReportedBy)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Location", issue.Location);
                command.Parameters.AddWithValue("@IssueCategory", issue.IssueCategory);
                command.Parameters.AddWithValue("@Description", issue.Description);
                command.Parameters.AddWithValue("@DateReported", issue.DateReported.Date);
                command.Parameters.AddWithValue("@Priority", issue.Priority);
                command.Parameters.AddWithValue("@Status", issue.Status);
                command.Parameters.AddWithValue("@ReportedBy", issue.ReportedBy);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateIssue(FacilitiesIssue issue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE FacilitiesIssues SET Location = @Location, IssueCategory = @IssueCategory, Description = @Description, " +
                             "DateReported = @DateReported, Priority = @Priority, Status = @Status, ReportedBy = @ReportedBy " +
                             "WHERE IssueID = @IssueID";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Location", issue.Location);
                command.Parameters.AddWithValue("@IssueCategory", issue.IssueCategory);
                command.Parameters.AddWithValue("@Description", issue.Description);
                command.Parameters.AddWithValue("@DateReported", issue.DateReported.Date);
                command.Parameters.AddWithValue("@Priority", issue.Priority);
                command.Parameters.AddWithValue("@Status", issue.Status);
                command.Parameters.AddWithValue("@ReportedBy", issue.ReportedBy);
                command.Parameters.AddWithValue("@IssueID", issue.IssueID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteIssue(int issueID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM FacilitiesIssues WHERE IssueID = @IssueID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IssueID", issueID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Search by location, category or status. Empty values are ignored.
        public DataTable SearchIssues(string location, string category, string status)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT IssueID, Location, IssueCategory, Description, DateReported, Priority, Status, ReportedBy " +
                             "FROM FacilitiesIssues WHERE 1 = 1";

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                if (!string.IsNullOrWhiteSpace(location))
                {
                    sql = sql + " AND Location LIKE @Location";
                    command.Parameters.AddWithValue("@Location", "%" + location.Trim() + "%");
                }

                if (!string.IsNullOrWhiteSpace(category) && category != "All")
                {
                    sql = sql + " AND IssueCategory = @IssueCategory";
                    command.Parameters.AddWithValue("@IssueCategory", category);
                }

                if (!string.IsNullOrWhiteSpace(status) && status != "All")
                {
                    sql = sql + " AND Status = @Status";
                    command.Parameters.AddWithValue("@Status", status);
                }

                sql = sql + " ORDER BY IssueID";
                command.CommandText = sql;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }

            return table;
        }
    }
}
