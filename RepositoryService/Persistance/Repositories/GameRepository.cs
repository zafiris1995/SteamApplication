using Entities;
using MyDatabase;
using RepositoryService.Persistance;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryService
{
    public class GameRepository : GenericRepository<Game> , IGameRepository
    {
        

        public GameRepository(ApplicationDbContext context) : base(context)
        {
            
        }

        
    }
}
