using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company(string name)
        {
            Name = name;
        }
        public Company()
        {

        }
    }
}
