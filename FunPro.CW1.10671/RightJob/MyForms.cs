using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightJob
{
    class MyForms
    {
        // to see only one form at a time. If the user clicks on the All applicatns or any other form, the program opens exisiting version of this form (already run). 
        public static T GetForm<T>() where T : class, new()
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault() ?? new T();
        }
    }
}
