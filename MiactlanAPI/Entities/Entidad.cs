﻿using MiactlanAPI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiactlanAPI.Entities
{
    public class Entidad
    {
        [Key]
        public int IdEntidad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string LatCentral { get; set; }
        public string LngCentral { get; set; }
        public int IdEstado { get; set; }
        [ForeignKey("IdEstado")]
        public Estado Estado { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Entrada> EntradasLista { get; set; }
    }
}
