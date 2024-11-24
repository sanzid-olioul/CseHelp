using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CseHelp.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public Task<bool> SaveAsync();
    }
}
