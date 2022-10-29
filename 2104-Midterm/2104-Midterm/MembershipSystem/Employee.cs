using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Midterm.MembershipSystem
{
    public  class Employee
    {
        public string ID { get;  set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateCreated { get; set; }
        public string Email { get; set; }
        public string DepartmentID { get; set; }
       
        protected Employee(string id)
        {
            ID = id;
        }

        public Employee(string id, string FirstName, string LastName, int DateCreated, string Email, string DepartmentID)
        {
            this.ID = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateCreated = DateCreated;
            this.Email = Email;
            this.DepartmentID = DepartmentID;
        }

        public Employee()
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateCreated = DateCreated;
            this.Email = Email;
            this.DepartmentID = DepartmentID;
        }

        public  void DisplayProperties()
        {
            Console.WriteLine(
                String.Format(
                   "ID:{0}  FirstName:{1}  LastName:{2}  DateCreated:{3}  Email:{4}  DepartmentID:{5}",
                   this.ID,
                   this.FirstName,
                   this.LastName,
                  this.DateCreated,
                   this.Email,
                   this.DepartmentID
                    ));
        }
    }
}
