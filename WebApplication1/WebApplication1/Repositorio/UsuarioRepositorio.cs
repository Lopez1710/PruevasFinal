using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Entidades;
using WebApplication1.Servicio;

namespace WebApplication1.Repositorio
{
    public class UsuarioRepositorio : IUsuario
    {
        private ApplicationDBContext DB;

        public UsuarioRepositorio(ApplicationDBContext DB)
        {
            this.DB = DB;
        }

        public void Buscar(Usuarios user)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuarios user)
        {
            DB.Remove(user);
        }

        public void Insert(Usuarios user)
        {
            DB.Add(user);
            DB.SaveChanges();
        }

        public List<Usuarios> Listar()
        {
            throw new NotImplementedException();
        }

        public void Update(Usuarios user)
        {
            DB.Update(user);
            DB.SaveChanges();
        }
    }
}
