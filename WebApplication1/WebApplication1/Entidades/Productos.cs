using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entidades
{
    public class Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }
        public string Producto { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public int CategoriaID { get; set; }
        public Categorias Categoria { get; set; }
        public ICollection<Carritos> Carritos { get; set; }

    }
}
