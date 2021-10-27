using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Entidades;
using WebApplication1.Servicio;

namespace WebApplication1.Repositorio
{
    public class ImgRepositorio : IIMG
    {
        private ApplicationDBContext DB;
        public ImgRepositorio(ApplicationDBContext DB)
        {
            this.DB = DB;
        }
        public List<Imagenes> listado()
        {
            return DB.imagenes.ToList();
        }
    }
}
