using System;
using System.ComponentModel.DataAnnotations;

namespace Tarea7.Models{
    public class Persona{
        [Key]
        public int id {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string telefono {get; set;}
        public string fecha_nacimiento {get; set;}
        [Required (ErrorMessage = "La Vacuna es requeria")]
        public int id_vacuna {get; set;} 
        public string provincia {get; set;}
        public string fecha_vacuna1 {get; set;}
        public string fecha_vacuna2 {get; set;}
        public int estado {get; set;}
    }
}