using System.ComponentModel.DataAnnotations;
namespace Tarea7.Models{
    public class Provincias{
        [Key]
        public int ProvinciaID {get; set;}
        public string Nombre {get; set;}
    }
}