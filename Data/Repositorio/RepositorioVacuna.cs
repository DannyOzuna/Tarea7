using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;
using Microsoft.EntityFrameworkCore;

namespace Tarea7.Data.Repositorio{
    public class RepositorioVacuna: IRepositorioVacuna{
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
        public async Task<List<Vacuna>> Getid(int id){

            var vacunadb = await (from v in context.Vacuna
            where v.id == id
            select v).ToListAsync();
            return  vacunadb;
        }


             public Task<Vacuna> Get(int id)
             {
                 throw new NotImplementedException(); 
             }
        


        //Actulizar una Vacuna
        public async Task<Vacuna> Update(Vacuna Vacuna)
        {
            try{
                    var vacunadb = await context.Vacuna.FindAsync(Vacuna.id);
                    vacunadb.marca = Vacuna.marca;
                    vacunadb.cantidad = Vacuna.cantidad;
                    vacunadb.estado = Vacuna.estado;
                    await context.SaveChangesAsync();
                    return vacunadb;

                 }
            catch(Exception x){
                    Console.WriteLine("Error",x);
                    return null;
            }
          
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
        public async Task Delete(int id){
            var vacunadb = await context.Vacuna.FindAsync(id);
            context.Remove(vacunadb);
            await context.SaveChangesAsync();
        }
    }
}