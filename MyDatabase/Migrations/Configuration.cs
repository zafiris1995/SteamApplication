namespace MyDatabase.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyDatabase.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyDatabase.ApplicationDbContext context)
        {
            Game g1 = new Game() { Title = "Starcraft", Price = 20 };
            Game g2 = new Game() { Title = "Diablo", Price = 10 };
            Game g3 = new Game() { Title = "Diablo II", Price = 15 };
            Game g4 = new Game() { Title = "Starcraft II", Price = 25 };
            Game g5 = new Game() { Title = "Diablo III", Price = 30 };

            Company c1 = new Company() { Name = "Blizzard" };
            Company c2 = new Company() { Name = "Sierra" };
            Company c3 = new Company() { Name = "Paradox" };
            Company c4 = new Company() { Name = "Sega" };
            Company c5 = new Company() { Name = "Nintendo" };

            Genre gen1 = new Genre() { Name = "Action" };
            Genre gen2 = new Genre() { Name = "RPG" };
            Genre gen3 = new Genre() { Name = "Strategy" };
            Genre gen4 = new Genre() { Name = "MOBA" };
            Genre gen5 = new Genre() { Name = "Adventure" };
        }
    }
}
