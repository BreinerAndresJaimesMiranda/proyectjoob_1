﻿using System;
using Microsoft.EntityFrameworkCore;
using Entity;

namespace Datos
{
    public class ProyectjoobContext:DbContext
    {

        public ProyectjoobContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Aspirante> Aspirantes { get; set; }
        public DbSet<DatoAcademico> DatosAcademicos { get; set; }
        public DbSet<DatoLaboral> DatosLaborales { get; set; }
        public DbSet<HojaDeVida> HojasDeVida { get; set; }

    }
}
