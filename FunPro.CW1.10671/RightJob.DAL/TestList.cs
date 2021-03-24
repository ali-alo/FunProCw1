using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this class sends all tests from the database and also search particular tests
namespace RightJob.DAL
{
    public class TestList
    {
        public List<TestName> GetAllTests()
        {
            return new TestManager().GetAll();
        }

        public List<TestName> Search(string value)
        {
            return GetAllTests().Where(a => a.Name.ToUpper().Contains(value.ToUpper())).ToList();

        }
    }
}
