using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;
using Microsoft.EntityFrameworkCore;

namespace Tarea7.Data.Repositorio{
    public class RepositorioProvincia : IProvincias{
        public readonly AppDbContext context;
        public RepositorioProvincia(AppDbContext context){
            this.context = context;
        }
        public async Task<List<Provincias>> Get(){
            return await context.Provincias.ToListAsync();
        }
    }
}