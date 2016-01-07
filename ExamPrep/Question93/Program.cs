using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question93
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new UseResources();
            ((IFile)manager).Open();
            ((IDbConnection)manager).Open();
        }
    }

    interface IFile
    {
        void Open();
    }

    interface IDbConnection
    {
        void Open();
    }

    class UseResources : IFile, IDbConnection
    {
        // NO ACCES MODIFIER!!!
        void IFile.Open() { }

        void IDbConnection.Open() { }
    }
}
