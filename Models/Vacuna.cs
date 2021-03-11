using System.ComponentModel.DataAnnotations;
public class Vacuna{
    [Key]
    public int id {get; set;}
    public string marca {get; set;}
    public int cantidad {get; set;}
    public int estado {get; set;}
}