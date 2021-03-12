using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;

namespace Tarea7.Data.Repositorio{
    public interface IProvincias{
        //Obtener el listado de Persona
        public Task<List<Provincias>> Get();

    }
}