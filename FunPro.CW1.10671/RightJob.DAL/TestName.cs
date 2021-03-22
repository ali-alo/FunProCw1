using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightJob.DAL
{
    public class TestName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Question1 { get; set; }
        public string Answer1 { get; set; }
        public string Question2 { get; set; }
        public string Answer2 { get; set; }
        public string Question3 { get; set; }
        public string Answer3 { get; set; }

        public TestName()
        {

        }

        public TestName(string name)
        {
            Name = name;
        }

        public TestName(string name, string q1, string a1, string q2, string a2, string q3, string a3)
        {
            Name = name;
            Question1 = q1;
            Answer1 = a1;
            Question2 = q2;
            Answer2 = a2;
            Question3 = q3;
            Answer3 = a3;
        }
    }
}
