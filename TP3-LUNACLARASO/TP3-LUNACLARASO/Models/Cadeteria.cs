﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3_LUNACLARASO.Models
{
    public class Cadeteria
    {
        string Nombre;
        List<Cadete> ListadoCadetes;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public List<Cadete> ListadoCadetes1 { get => ListadoCadetes; set => ListadoCadetes = value; }
    }
}
