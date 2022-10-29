using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Midterm.MembershipSystem
{
    public abstract class StandardEmployee : Employee
    {
        protected int VacationDays;
        protected double Salary;
        private int dateCreated;

        public StandardEmployee(string id, int dateCreated) : this(id)
        {
            this.dateCreated = dateCreated;
        }

        protected StandardEmployee(string id) : base(id)
        {
        }

        public virtual int GetVacationDays()
        {
            return this.VacationDays;
        }

        protected virtual void SetSalary()
        {
                this.Salary = SalaryConfiguration.DefaultSalary;

        }
    }
}
