using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Question234
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = doOperation("SubNumb", 2, 3);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public int AddNumb(int numb1,int numb2)
        {
            int result = numb1 + numb2;
            return result;
        }

        public int SubNumb(int numb1, int numb2)
        {
            int result = numb1 - numb2;
            return result;
        }

        public static string doOperation(string operationName, int numb1, int numb2)
        {
            object[] mParam = new object[] { numb1, numb2 };
            Program myProgram = new Program();
            Type myType = myProgram.GetType();
            //Type myType = typeof(Program);
            MethodInfo myMethodInfo = myType.GetMethod(operationName);
            return myMethodInfo.Invoke(myProgram, mParam).ToString();
        }
    }
}
