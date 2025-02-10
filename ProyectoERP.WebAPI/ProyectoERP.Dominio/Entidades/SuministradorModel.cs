﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoERP.Dominio.Entidades
{
    public class SuministradorModel
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string DireccionLinea1 { get; set; }
        public string DireccionLinea2 { get; set; }
        public DateTime FechaDeRegistracion {  get; set; } 

    }
}
