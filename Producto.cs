﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaInventario
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public int Stock { get; set; }
    }
}
