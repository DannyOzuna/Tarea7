using System;

namespace Tarea7.Models{
    public class PersonaJoin{
        public int id {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string telefono {get; set;}
        public DateTime fecha_nacimiento {get; set;}
        public string vacuna {get; set;} 
        public string provincia {get; set;}
        public string cedula {get; set;}
        public DateTime fecha_vacuna1 {get; set;}
        public DateTime fecha_vacuna2 {get; set;}
        public string SignoZodiacal {get; set;} 
        public int estado {get; set;}
    }
}