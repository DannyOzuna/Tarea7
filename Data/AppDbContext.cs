using System;
using Microsoft.EntityFrameworkCore;
using Tarea7.Models;

namespace Tarea7.Data{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }
        public DbSet<Persona> Persona {get; set;}
        public DbSet<Vacuna> Vacuna {get; set;}
    }    
}