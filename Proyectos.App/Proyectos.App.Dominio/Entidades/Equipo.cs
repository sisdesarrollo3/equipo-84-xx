using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Entidades
{
    public class Equipo
    {
        //atributos de la clase tutor
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Código")]
        public string codigo{ get; set; }
        [Required]        
        [Display(Name = "Nombre del Equipo")]
        public string nombre{ get; set; }
        [Required]        
        [Display(Name = "Meet")]
        public string meet{ get; set; }
        [Required]        
        [Display(Name = "WhatsApp")]
        public string whatsapp{ get; set; }
        [Required]        
        [Display(Name = "Tema")]
        public string tema{ get; set; }
        [Required]        
        [Display(Name = "Fecha Inicio")]
        public DateTime fechaInicio{ get; set; }
        [Required]        
        [Display(Name = "Fecha Final")]
        public DateTime fechaFinal{ get; set; }
        [Required]        
        [Display(Name = "Formador")]
        public int formador{ get; set; }
        [Required]        
        [Display(Name = "Tutor")]
        public int tutor{ get; set; }
        [Required]        
        [Display(Name = "Estado Proyecto")]
        public int estadoProyecto{ get; set; }
        [Display(Name = "Vigente")]
        public bool vigente{ get; set; }
    }
}

