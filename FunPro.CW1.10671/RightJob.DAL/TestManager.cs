using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// this class applies user's edits in the ts_table table to the database
namespace RightJob.DAL
{
    public class TestManager : DbManager  // Inheritance where DbManager is a superclass
    {
        // when user will be adding a new test
        public void Create(TestName t)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
INSERT INTO ts_test 
(ts_name_10671, ts_q1_10671, ts_q1_answer_10671, ts_q2_10671, ts_q2_answer_10671, ts_q3_10671, ts_q3_answer_10671)
VALUES ('{t.Name}', '{t.Question1}', '{t.Answer1}', '{t.Question2}', '{t.Answer2}', '{t.Question3}', '{t.Answer3}')";
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

        // when user will be updating a test
        public void Update(TestName t)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
UPDATE ts_test SET 
    ts_name_10671 = '{t.Name}', 
    ts_q1_10671 = '{t.Question1}',
    ts_q1_answer_10671 = '{t.Answer1}',
    ts_q2_10671 = '{t.Question2}',
    ts_q2_answer_10671 = '{t.Answer2}',
    ts_q3_10671 = '{t.Question3}',
    ts_q3_answer_10671 = '{t.Answer3}'
WHERE ts_id_10671 = {t.Id}";
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

        // when user will be deleting a test
        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM ts_test WHERE ts_id_10671 = {id}";
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

        // shows a particular test from the database
        public TestName GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
SELECT ts_name_10671, ts_q1_10671, ts_q1_answer_10671, ts_q2_10671, ts_q2_answer_10671, ts_q3_10671, ts_q3_answer_10671
FROM ts_test WHERE ts_id_10671 = {id}";
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

            // if compiler gets here, means the program couldn't find a test. something went wrong
            return null;
        }

        // shows the entire list of tests from the database
        public List<TestName> GetAll()
        {
            var connection = Connection;
            var result = new List<TestName>();
            try
            {
                var sql = "SELECT ts_id_10671, ts_name_10671, ts_q1_10671, ts_q1_answer_10671, ts_q2_10671, ts_q2_answer_10671, ts_q3_10671, ts_q3_answer_10671 FROM ts_test";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var t = GetFromReader(reader);
                    result.Add(t);
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

            // returns the list of all tests
            return result;
        }

        // reusability of retrieveing data from the database
        private TestName GetFromReader(SqlCeDataReader reader)
        {
            var t = new TestName
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                Name = Convert.ToString(reader.GetValue(1)),
                Question1 = Convert.ToString(reader.GetValue(2)),
                Answer1 = Convert.ToString(reader.GetValue(3)),
                Question2 = Convert.ToString(reader.GetValue(4)),
                Answer2 = Convert.ToString(reader.GetValue(5)),
                Question3 = Convert.ToString(reader.GetValue(6)),
                Answer3 = Convert.ToString(reader.GetValue(7)),
            };

            return t;
        }
    }
}
