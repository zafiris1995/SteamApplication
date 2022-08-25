using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Game

    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public Game(string title, int price)
        {
            Title = title;
            Price = price;
        }
        public Game()
        {

        }
    }
}
