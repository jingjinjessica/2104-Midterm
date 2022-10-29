using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Midterm.MembershipSystem
{
    public class Owner : StandardEmployee
    {
        public Owner(string id, int dateCreated) : base(id, dateCreated)
        {
            this.VacationDays = 50;
            this.SetSalary();
        }
    }
}
