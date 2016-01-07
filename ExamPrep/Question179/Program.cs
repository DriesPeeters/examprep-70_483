using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question179
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ;
            }
            catch(SqlException ex)
            {
                LogHelper.Log(ex);
                throw; // only this way no change to the stack trace
                // throw ex; //=> would reset call stack to this point
            }
        }
    }

    public class LogHelper
    {
        public static void Log(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
