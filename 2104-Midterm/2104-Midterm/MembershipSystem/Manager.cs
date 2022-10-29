using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Midterm.MembershipSystem
{
    public class Manager : StandardEmployee
    {
        public Manager(string id, int dateCreated) : base(id, dateCreated)
        {
            this.VacationDays = 20;
            this.SetSalary();
        }
        protected override void SetSalary()
        {
            this.Salary = SalaryConfiguration.DefaultManagerSalary;
        }
    }
}
