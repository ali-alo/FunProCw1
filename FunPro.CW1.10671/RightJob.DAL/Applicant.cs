using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightJob.DAL
{
    public class Applicant
    {
        public int Id { get; set; }
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Enter applicant's name");
                _name = value;
            }
        }
        
        // nud properties do not allow user to set inappropriate values, so no need to user extra recourses on validation here
        public int Score { get; set; }
        public string TestsTaken { get; set; }

        public Applicant()
        {

        }
    }
}
