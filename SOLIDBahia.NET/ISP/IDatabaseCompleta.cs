using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.ISP
{
    //Se eu obrigar uma classe implementar essa interface, 
    //ela estará herdando tanto métodos do EF quanto de acesso ADO
    public interface IDatabaseCompleta
    {
        List<object> ExecutaSQL();
        //Fingindo que esse é um método que faz interação com o Entity Framework
        IQueryable<object> ObterTodos();
        object ExecutaProcedure();
    }
}
