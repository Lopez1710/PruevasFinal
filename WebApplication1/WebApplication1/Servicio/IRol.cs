using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entidades;

namespace WebApplication1.Servicio
{
    public interface IRol
    {
        void buscar(Roles r);
        List<Roles> Listar();
    }
}
