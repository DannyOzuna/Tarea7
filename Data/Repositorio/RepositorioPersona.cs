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
        public async Task<Persona> Get(string cedula){
            var personadb = await context.Persona.FirstOrDefaultAsync(p => p.cedula == cedula);
            if(personadb == null){
                return null;
            }
            return personadb;
        }
        public async Task<List<PersonaJoin>> Get(int id){
            var personadb = await (from p in context.Persona 
                                    join v in context.Vacuna on p.id_vacuna equals v.id
                                    join pr in context.Provincias on p.provincia equals pr.ProvinciaID
                                    where p.id == id
                                    select new PersonaJoin
                                    {
                                        nombre = p.nombre,
                                        apellido = p.apellido,
                                        telefono = p.telefono,
                                        fecha_nacimiento = p.fecha_nacimiento,
                                        vacuna = v.marca,
                                        provincia = pr.Nombre,
                                        cedula = p.cedula,
                                        fecha_vacuna1 = p.fecha_vacuna1,
                                        fecha_vacuna2 = p.fecha_vacuna2,
                                        SignoZodiacal = p.SignoZodiacal,
                                        estado = p.estado
                                    }
                                    ).ToListAsync();
            if(personadb == null){
                return null;
            }
            return personadb;
        }
        public async Task<Persona> Add(Persona persona){
            if(persona != null){
                var personadb = await context.Persona.FirstOrDefaultAsync(p => p.cedula == persona.cedula);
                if(personadb == null){
                    persona.fecha_vacuna2 = persona.fecha_vacuna1;
                    persona.estado = 1;
                    await context.AddAsync(persona);
                    await context.SaveChangesAsync();
                    return persona;
                }else{
                    return null;
                }
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