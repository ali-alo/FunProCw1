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
        public string Name { get; set; }
        public int Score { get; set; }
        public string TestsTaken { get; set; }

        public Applicant(string name)
        {
            Name = name;
            Score = 0;
            TestsTaken = "";
        }

        public Applicant()
        {

        }

        public Applicant(string name, int score, string testsTaken)
        {
            Name = name;
            Score = score;
            TestsTaken = testsTaken;
        }
    }
}
