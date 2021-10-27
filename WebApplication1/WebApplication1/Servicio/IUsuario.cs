using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entidades;

namespace WebApplication1.Servicio
{
    public interface IUsuario
    {
        void Insert(Usuarios user);
        void Update(Usuarios user);
        void Delete(Usuarios user);
        void Buscar(Usuarios user);
        List<Usuarios> Listar();
    }
}
