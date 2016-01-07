using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question116
{
    class Program
    {
        static void Main(string[] args)
        {
            var u = new User();
            u.UserGroup = Group.Users | Group.Administrators;

            Console.WriteLine(u.UserGroup.ToString());

            if(u.UserGroup == Group.Users)
            {
                Console.WriteLine("Only a user");
            }

            if((u.UserGroup & Group.Users) == Group.Users)
            {
                Console.WriteLine("User is a user (maybe more)");
            }

            Console.ReadKey();


        }

        [Flags]
        public enum Group
        {
            Users = 1,
            Supervisors = 2,
            Managers = 4,
            Administrators = 8
        }

        public class User
        {
            public Group UserGroup { get; set; }
        }
    }
}
