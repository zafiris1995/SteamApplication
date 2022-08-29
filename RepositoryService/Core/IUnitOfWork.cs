using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryService.Core
{
    internal interface IUnitOfWork : IDisposable
    {
        IGameRepository Games { get; }

        int Complete();
    }
}
