﻿using Entities;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();            

            var games = db.Games.ToList();

            foreach (var item in games)
            {
                Console.WriteLine(item.Title + "\t" + item.Price);
            }
        }
    }
}
