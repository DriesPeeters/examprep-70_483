﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question125
{
    class Program
    {
        static void Main(string[] args)
        {
            Department[] departments =
            {
                new Department { Id = 1, Name = "Accounting", Manager = "User1", BuildingId = 15 },
                new Department { Id = 2, Name = "Sales", Manager = "User", BuildingId = 3 },
                new Department { Id = 3, Name = "IT", Manager = "User3", BuildingId = 15 },
                new Department { Id = 4, Name = "Marketing", Manager = "User4", BuildingId = 3 },
            };

            var output =
                (from d in departments
                 group d by d.BuildingId into dp
                 select dp).ToList() ;

            var output2 =
                (from d in departments
                 group d by d.BuildingId into dp
                 select new { sorted = dp.Key, Department = dp }).ToList();

            Console.ReadKey();

        }

        public class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Manager { get; set; }
            public int BuildingId { get; set; }
        }

    }
}
