﻿using EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ApplicationDbContext())
            {

            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
