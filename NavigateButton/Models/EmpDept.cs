using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavigateButton.Models
{
    public class EmpDept
    {
        Employee e1= new Employee();

        public string Fname
        {
            get { return e1.Fname; }
            set { e1.Fname = value; }
        }

         Department d1 = new Department();

        public string DeptName
        {
            get { return d1.Deptname; }
            set { d1.Deptname = value; }
        }
    }
}