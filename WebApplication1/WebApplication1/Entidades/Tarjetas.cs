﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entidades
{
    public class Tarjetas
    {
        [Key]
        public int Numero { get; set; }
        public string Fecha { get; set; }
        public int CVV { get; set; }
    }
}
