using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// this class applies user's edits to the database
namespace RightJob.DAL
{
    class ApplicantManager
    {
        // when user will be adding a new applicant
        public void Create(Applicant a)
        {
            var connection = new SqlCeConnection("");
            try
            {
                var sql = $"INSERT INTO ap_applicant (ap_name_10671, ap_score_10671) VALUES ('{a.Name}', {a.Score})";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                // we don't expect any data to come back,that's why ExecuteNonQuerry()
                command.ExecuteNonQuery();
            }
            // in case we encounter an error, show a user-friendly message to the user, but don't collapse the program
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // no matter if there was an error or not, if sql connection still open, close it
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        // when user will be updating an applicant
        public void Update(Applicant a)
        {
            var connection = new SqlCeConnection("");
            try
            {
                var sql = $@"
UPDATE ap_applicant SET 
    ap_name_10671 = '{a.Name}', 
    ap_score_10671 = '{a.Score}',
    ap_tests_taken_10671 = '{a.TestsTaken}'
WHERE Id = {a.Id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }
        }

        // when user will be deleting an applicant
        public void Delete(int id)
        {
            var connection = new SqlCeConnection("");
            try
            {
                var sql = $"DELETE FROM ap_applicant WHERE Id = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        // shows a particular user from the database
        public Applicant GetById(int id)
        {
            var connection = new SqlCeConnection("") ;
            try
            {
                var sql = $"SELECT ap_id_10671, ap_name_10671, ap_score_10671, ap_tests_taken_10671 FROM ap_applicant WHERE ID = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // to follow the DRY rule, some lines of code were transfered to the GetFromReader() method
                    var a = GetFromReader(reader);
                    return a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            // if compiler gets here, means the program couldn't find an applicant. something went wrong
            return null;
        }

        // shows the entire list of applicants from the database
        public List<Applicant> GetAll()
        {
            var connection = new SqlCeConnection("");
            var result = new List<Applicant>();
            try
            {
                var sql = "SELECT ap_id_10671, ap_name_10671, ap_score_10671, ap_tests_taken_10671 FROM ap_applicant";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = GetFromReader(reader);
                    result.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            // returns the list of all applicants
            return result;
        }

        // reusability of retrieveing data from the database
        private Applicant GetFromReader(SqlCeDataReader reader)
        {
            var a = new Applicant
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                Name = reader.GetValue(1).ToString(),
                Score = Convert.ToInt32(reader.GetValue(2)),
                TestsTaken = reader.GetValue(3).ToString()

            };

            return a;
        }

    }
}
