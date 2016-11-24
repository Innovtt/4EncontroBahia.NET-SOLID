using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.ISP
{
    public interface IDatabaseEntityFramework
    {
        IQueryable<object> ObterTodos();
    }
}
