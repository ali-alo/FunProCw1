using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightJob.DAL
{
    // this class is responsible fore searching / filtering and sending all applicants to the user
    public class ApplicantList
    {
        public List<Applicant> GetAllApplicants()
        {
            return new ApplicantManager().GetAll();
        }

        public List<Applicant> Sort(ByAttribute attribute)
        {
            var result = GetAllApplicants();

            switch (attribute)
            {
                case ByAttribute.Name:
                    result.Sort(new ByNameComparer());
                    return result;
                case ByAttribute.Score:
                    result.Sort(new ByScoreComparer());
                    // I think it is better to display scores from top to bottom (highest marks on top), that's why list method .Reverse()
                    result.Reverse();
                    return result;
            }

            //if we are here - something went wrong
            return null;
        }


        private class ByNameComparer : IComparer<Applicant>
        {
            // compares two strings, similart to the Bubble Sort. 
            public int Compare(Applicant x, Applicant y)
            {
                // evaluation process of two strings
                return string.Compare(x.Name, y.Name);
            }
        }

        private class ByScoreComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                // there is no such method int.Compare, but it is possible to convert integers into strings and compare them
                return string.Compare(x.Score.ToString(), y.Score.ToString());
            }
        }

        // smart searching 
        public List<Applicant> Search(string value)
        {
            // cheking for both lower and uppercased letters
            return GetAllApplicants().Where(a => a.Name.ToUpper().Contains(value.ToUpper())).ToList();

        }
    }
}
