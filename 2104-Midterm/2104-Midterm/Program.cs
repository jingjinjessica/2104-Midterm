
using _2104_Midterm.MembershipSystem;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.Immutable;
using Microsoft.VisualBasic.FileIO;

namespace _2104_Midterm
{
    class Program :UserRepository
    {
        static void Main(string[] args)
        {
            /*new Program().Add(new Employee()
            {
                ID = "001",
                FirstName = "Jin",
                LastName = "Jing",
                DateCreated = 2010,
                Email = "jj@email",
                DepartmentID = "M001"
            });*/

            /*new Program().Add(new Employee()
            {
                ID = "002",
                FirstName = "Erica",
                LastName = "Jing",
                DateCreated = 2002,
                Email = "Ej@email",
                DepartmentID = "A001"
            });
*/
            //new Program().Delete("001");
            new Program().Get("001");
        }

        

        
    }






}