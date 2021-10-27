using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Entidades;
using WebApplication1.Servicio;

namespace WebApplication1.Repositorio
{
    public class RolRepositorio : IRol
    {
        private ApplicationDBContext DB;
        public RolRepositorio(ApplicationDBContext DB)
        {
            this.DB = DB;
        }

        public void buscar(Roles r)
        {
            DB.Roles.Find(r);
            
        }

        public List<Roles> Listar()
        {
            return DB.Roles.ToList();
        }
    }
}
