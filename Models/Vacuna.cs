using System;
using System.ComponentModel.DataAnnotations;

namespace Tarea7.Models{
    public class Vacuna{
        [Key]
        public int id {get; set;}
         public string marca {get; set;}
          public int cantidad {get; set;}
           public bool estado {get; set;}
        
    }
}