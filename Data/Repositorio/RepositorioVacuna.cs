using System.Runtime.Intrinsics.Arm.Arm64;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics;

namespace Tarea7.Data.Repositorio
{
    public class RepositorioVacuna:IRepositorioVacuna
    {
        public readonly AppDbContext context;

        public RepositorioVacuna(AppDbContext context) 
        {
            this.context = context;
        }


        
        public async Task<List<Vacuna>> Get(){
            return await context.Vacuna.ToListAsync();
        }

        public async Task<Vacuna> Get(int id){
            var vacunadb = await context.Vacuna.FindAsync(id);
            if(vacunadb == null){
                return new Vacuna();
            }
            return vacunadb;
        }


        public async Task<Vacuna> Add(Vacuna vacuna){
            if(vacuna != null){
                await context.AddAsync(vacuna);
                await context.SaveChangesAsync();
                return vacuna;
            }else{
                return new Vacuna();
            }
        }

        public async Task<Vacuna> Update(int id, Vacuna vacuna){
            var vacunadb = await context.Vacuna.FindAsync(id);
            vacunadb.marca = vacuna.marca; 
            vacunadb.cantidad = persona.cantidad; 
            vacunadb.estado = persona.estado; 
            await context.SaveChangesAsync();
            return vacunadb;

        }
        public async Task Delete(int id){
            var vacunadb = await context.Vacuna.FindAsync(id);
            context.Remove (vacunadb);
            await context.SaveChangesAsync();
        }


    }


}