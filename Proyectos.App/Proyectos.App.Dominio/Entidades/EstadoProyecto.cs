using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Entidades
{
    public class EstadoProyecto
    {
        //atributos de la clase tutor
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Nombre del Estado")]
        public string nombre{ get; set; }
    }
}

