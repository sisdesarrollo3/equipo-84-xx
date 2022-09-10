using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;

namespace Proyectos.App.Presentacion.Formadores
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Formador formador { get; set; }
        public void OnGet()
        {
            //cargar los datos del registro seleccionado en la tabla de listar
          formador = new Formador{
                id = 1, 
                identificacion = "10266377",
                nombre = "Jhon Jairo Orozco D.",
                mail = "jorozco@ucaldas.edu.co",
                movil = "319xxxxx",
                vigente = true              
          };
        }
    }
}
