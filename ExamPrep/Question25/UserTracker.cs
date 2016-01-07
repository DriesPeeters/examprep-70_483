using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question25
{
    public delegate void AddUserCallback(int i);
    class UserTracker
    {
        List<string> users = new List<string>();
        public void AddUser(string name, AddUserCallback callback)
        {
            users.Add(name);
            callback(users.Count);
        }
    }
}
