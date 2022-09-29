using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Entidades
{
    public class Tutor
    {
        //atributos de la clase tutor
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Nro. Identificación")]
        public string identificacion{ get; set; }
        [Required]        
        [Display(Name = "Nombre del Tutor")]
        public string nombre{ get; set; }
        [Required]        
        [Display(Name = "Correo Electrónico")]
        public string mail{ get; set; }
        [Required]        
        [Display(Name = "Celular")]
        public string movil{ get; set; }
         [Display(Name = "Vigente")]
         public bool vigente{ get; set; }
    }
}

