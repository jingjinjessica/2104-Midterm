using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Midterm.MembershipSystem
{
    public class AdministratorUser : StandardEmployee
    {
        public AdministratorUser(string id, int DateCreated) : base(id,DateCreated)
        {
            this.VacationDays = 10;
            this.SetSalary();
        }

        public override int GetVacationDays()
        {
            if (DateTime.Now.Year - this.DateCreated >= 5)
            {
                return this.VacationDays + 5;
            }

            return this.VacationDays;
        }

    }
}
