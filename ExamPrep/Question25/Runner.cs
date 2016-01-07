using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question25
{
    class Runner
    {
        UserTracker tracker = new UserTracker();
        public void Add(string name)
        {
            tracker.AddUser(name, (count) =>
            {
                Console.WriteLine($"{count} users in the user list");
            });
            tracker.AddUser(name, delegate (int count)
            {
                Console.WriteLine($"{count} users in the user list");
            });
            tracker.AddUser(name, UserAdded);
        }

        public void UserAdded(int count)
        {
            Console.WriteLine($"{count} users in the user list");
        }
    }
}
