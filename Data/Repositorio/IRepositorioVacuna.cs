using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;

namespace Tarea7.Data.Repositorio{
    public interface IRepositorioVacuna{
        //Obtener el listado de Persona
        public Task<List<Vacuna>> Get();
        //Obtener una persona en especifico
        public Task<Vacuna> Get(int id);
        //Actulizar una persona
        public Task<Vacuna> Update(int id, Vacuna persona);
        //Crea una persona
        public Task<Vacuna> Add(Vacuna persona);
        //Elimina una persona
        public Task Delete(int id);


    }
}