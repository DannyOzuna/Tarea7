using System.Runtime.Intrinsics.Arm.Arm64;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;
using Microsoft.EntityFrameworkCore;

namespace Tarea7.Data.Repositorio
{
    public class RepositorioVacuna:IRepositorioVacuna
    {
        public readonly AppDbContext context;

        public RepositorioVacuna(AppDbContext context) 
        {
            this.context = context;
        }

       

         

    }


}