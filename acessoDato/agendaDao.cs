using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace acessoDato
{
    internal interface agendaDao
    {
         List<string> Select(string nombres);

        void insert(agendaDTO agenda);

         void update(agendaDTO agenda);

        void delete(int agenda);
    }
}
