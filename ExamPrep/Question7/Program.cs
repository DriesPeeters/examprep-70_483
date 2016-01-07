using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            var fs = File.Open("afile.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
        }
    }
}
