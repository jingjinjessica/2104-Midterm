using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Midterm.MembershipSystem
{
    public interface IUserRepository
    {

         void Add(Employee employee);
         void Update(Employee employee);
         void Delete(string id);
         Employee Get(string id);

         List<Employee> Get(string FirstName, string LastName);




    }
}
