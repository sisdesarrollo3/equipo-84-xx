using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Entidades
{
    public class Formador
    {
        //atributos de la clase formador
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Nro. Identficación")]
        public string identificacion{ get; set; }
        [Required]        
        [Display(Name = "Nombre del Formador")]
        public string nombre{ get; set; }
        [Required]        
        [Display(Name = "Correo Electrónico")]
        public string mail{ get; set; }
        [Required]        
        [Display(Name = "Celular")]
        public string movil{ get; set; }
        public bool vigente{ get; set; }
    }
}

