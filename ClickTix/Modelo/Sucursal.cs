﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Modelo
{
    internal class Sucursal
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string cuit { get; set; }
        public string direccion { get; set; }
        public string abreviatura { get; set; }

        public int numerosalas { get; set; }

    }
}
