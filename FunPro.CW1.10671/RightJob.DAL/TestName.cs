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

        private string _name;
        public string Name 
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Enter the name of the course");
                _name = value;
            }
        }

        private string _question1;
        public string Question1
        {
            get => _question1;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Question 1 is missing");
                _question1 = value;
            }
        }

        private string _answer1;
        public string Answer1
        {
            get => _answer1;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Question 1 answer is missing");
                _answer1 = value;
            }
        }

        private string _question2;
        public string Question2
        {
            get => _question2;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Question 2 is missing");
                _question2 = value;
            }
        }

        private string _answer2;
        public string Answer2
        {
            get => _answer2;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Question 2 answer is missing");
                _answer2 = value;
            }
        }

        private string _question3;
        public string Question3
        {
            get => _question3;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Question 3 is missing");
                _question3 = value;
            }
        }

        private string _answer3;
        public string Answer3
        {
            get => _answer3;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Question 3 answer is missing");
                _answer3 = value;
            }
        }

        public TestName()
        {

        }

        // to show the names of courses taken on the user end
        public override string ToString()
        {
            return Name;
        }
    }
}
