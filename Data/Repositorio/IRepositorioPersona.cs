using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;

namespace Tarea7.Data.Repositorio{
    public interface IRepositorioPersona{
        //Obtener el listado de Persona
        public Task<List<Persona>> Get();
        //Obtener una persona en especifico
        public Task<Persona> Get(int id);
        //Actulizar una persona
        public Task<Persona> Update(int id, Persona persona);
        //Crea una persona
        public Task<Persona> Add(Persona persona);
        //Elimina una persona
        public Task Delete(int id);


    }
}