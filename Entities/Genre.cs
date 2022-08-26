﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Kind { get; set; }
        public Genre(string kind )
        {
            Kind = kind;
        }
        public Genre()
        {

        }
    }
}
