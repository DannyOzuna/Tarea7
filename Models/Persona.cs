using System;
using System.ComponentModel.DataAnnotations;

namespace Tarea7.Models{
    public class Persona{
        [Key]
        public int id {get; set;}
        [Required (ErrorMessage = "Campo Vacío")]
        public string nombre {get; set;}
        [Required (ErrorMessage = "Campo Vacío")]
        public string apellido {get; set;}
        [Required (ErrorMessage = "Campo Vacío")]
        public string telefono {get; set;}
        public DateTime fecha_nacimiento {get; set;}
        public int id_vacuna {get; set;} 
        public int provincia {get; set;}
        [Required (ErrorMessage = "Campo Vacío")]
        public string cedula {get; set;}
        public DateTime fecha_vacuna1 {get; set;}
        public DateTime fecha_vacuna2 {get; set;}
        public string SignoZodiacal {get; set;} 
        public int estado {get; set;}
    }
}