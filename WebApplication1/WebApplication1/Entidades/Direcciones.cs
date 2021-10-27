﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entidades
{
    public class Direcciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DireccionID { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; }
        public int CP { get; set; }
        public ICollection<DetalleDeCompras> DetalleDeCompras { get; set; }

    }
}
