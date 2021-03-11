using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;

namespace Tarea7.Data.Repositorio{
    public interface IRepositorioVacuna{
        //Obtener el listado de Vacuna
        public Task<List<Vacuna>> Get();
        //Obtener una Vacuna en especifico
        public Task<Vacuna> Get(int id);
        //Actulizar una Vacuna
        public Task<Vacuna> Update(int id, Vacuna Vacuna);
        //Crea una Vacuna
        public Task<Vacuna> Add(Vacuna Vacuna);
        //Elimina una Vacuna
        public Task Delete(int id);


    }
}