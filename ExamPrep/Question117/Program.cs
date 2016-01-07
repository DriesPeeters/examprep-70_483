using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Question117
{
    class Program
    {
        static void Main(string[] args)
        {
            GetHash("SHA");
        }

        public static byte[] GetHash(string algorithmType)
        {
            var hasher = HashAlgorithm.Create(algorithmType);
            byte[] bytes = { 1, 2, 3, 4 };
            var result = hasher.ComputeHash(bytes);
            Console.WriteLine(string.Join(" ",result));
            var hash = hasher.Hash;
            Console.WriteLine(string.Join(" ", hash));

            
            return hash;
        }
    }
}
