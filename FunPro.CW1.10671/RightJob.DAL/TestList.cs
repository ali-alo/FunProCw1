using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this class has only one function and returns the list of all tests in the database
namespace RightJob.DAL
{
    public class TestList
    {
        public List<TestName> GetAllTests()
        {
            return new TestManager().GetAll();
        }
    }
}
