using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question162
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetTypeDefault(DbType.DateTime) ?? "null" );
            Console.WriteLine(GetTypeDefault(DbType.Int64) ?? "null");
            Console.WriteLine(GetTypeDefault(DbType.Double) ?? "null");

            Console.ReadKey();
        }

        public static Object GetTypeDefault(DbType dbDataType)
        {
            switch (dbDataType)
            {
                case DbType.Boolean:
                    return false;
                case DbType.DateTime:
                    return DateTime.MinValue;
                case DbType.Decimal:
                    return 0m;
                case DbType.Int32:
                    return 0;
                case DbType.String:
                    return String.Empty;
                default:
                    return null;
            }
        }

        public enum DbType
        {
            Boolean,
            DateTime,
            Decimal,
            Int32,
            Int64,
            String,
            Double
        }
    }
}
