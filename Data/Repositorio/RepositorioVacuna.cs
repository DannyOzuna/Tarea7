using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;
using Microsoft.EntityFrameworkCore;

namespace Tarea7.Data.Repositorio{
    public class RepositorioVacuna:IRepositorioVacuna{
        public readonly AppDbContext context;
        public RepositorioVacuna(AppDbContext context){
            this.context = context;
        }

        public async Task<List<Vacuna>> Select(){
            return await context.Vacuna.Where(v => v.cantidad > 0).ToListAsync();
        }
        public async Task<List<Vacuna>> Get(){
            return await context.Vacuna.ToListAsync();
        }
        //Obtener una Vacuna en especifico
        public Task<Vacuna> Get(int id){
            throw new NotImplementedException();
        }
        //Actulizar una Vacuna
        public Task<Vacuna> Update(int id, Vacuna Vacuna){
            throw new NotImplementedException();
        }
        //Crea una Vacuna
        public async Task<Vacuna> Add(Vacuna Vacuna){
          if(Vacuna != null)
            {
                await context.AddAsync(Vacuna);
                await context.SaveChangesAsync();
                return Vacuna;
            }
            return null;
        }
        //Elimina una Vacuna
        public Task Delete(int id){
            throw new NotImplementedException();
        }
    }
}