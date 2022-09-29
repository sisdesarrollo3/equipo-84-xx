using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Entidades
{
    public class Rol
    {
        //atributos de la clase tutor
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Nombre del Rol")]
        public string nombre{ get; set; }
        [Required]        
        [Display(Name = "Descripcion del Rol")]
        public string descripcion{ get; set; }
        public bool vigente{ get; set; }
    }
}

