using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;
using Microsoft.EntityFrameworkCore;

namespace Tarea7.Data.Repositorio{
    public class RepositorioPersona:IRepositorioPersona{
        public readonly AppDbContext context;
        public RepositorioPersona(AppDbContext context){
            this.context = context;
        }
        public async Task<List<Persona>> Get(){
            return await context.Persona.ToListAsync();
        }
        public async Task<Persona> Get(int id){
            var personadb = await context.Persona.FindAsync(id);
            if(personadb == null){
                return new Persona();
            }
            return personadb;
        }
        public async Task<Persona> Add(Persona persona){
            if(persona != null){
                await context.AddAsync(persona);
                await context.SaveChangesAsync();
                return persona;
            }else{
                return new Persona();
            }
        }
        public async Task<Persona> Update(int id, Persona persona){
            var personadb = await context.Persona.FindAsync(id);
            personadb.nombre = persona.nombre; 
            personadb.apellido = persona.apellido; 
            personadb.telefono = persona.telefono; 
            personadb.fecha_nacimiento = persona.fecha_nacimiento; 
            personadb.id_vacuna = persona.id_vacuna; 
            personadb.provincia = persona.provincia; 
            personadb.fecha_vacuna1 = persona.fecha_vacuna1; 
            personadb.fecha_vacuna2 = persona.fecha_vacuna2; 
            personadb.estado = persona.estado; 
            await context.SaveChangesAsync();
            return personadb;

        }
        public async Task Delete(int id){
            var personadb = await context.Persona.FindAsync(id);
            context.Remove (personadb);
            await context.SaveChangesAsync();
        }
    }
}