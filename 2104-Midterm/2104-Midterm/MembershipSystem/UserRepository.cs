﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Midterm.MembershipSystem
{
    public class UserRepository : IUserRepository
    {
        public virtual IList<Employee>Employee { get; set; }
        public void Add(Employee employee)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee()
            {
                ID = "",
                FirstName = "",
                LastName = "",
                DateCreated = 0,
                Email = "",
                DepartmentID = ""
            });
            
            employee.DisplayProperties();
            
        }


        public void Delete(string id)
        {
        
            Employee.Remove(Employee.Where(employee => employee.ID == id).First());
           

        }
         public void Update(Employee employee)
         {
           
         }

     



        public Employee Get(string id)
        {

          
          var k =  Employee.Where(e => e.ID == id);

        }

        public List<Employee> Get(string FirstName, string LastName)
        {
            throw new NotImplementedException();
        }

       
    }
}
