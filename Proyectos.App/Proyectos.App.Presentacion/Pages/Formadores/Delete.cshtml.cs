using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;

namespace Proyectos.App.Presentacion.Formadores
{
    
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Formador formador { get; set; }

        public void OnGet()
        {
            formador = new Formador {
               id = 3, 
               identificacion = "7777777",
               nombre = "CARGANDO NOMBRE DE PRUEBA",
               mail = "jorozco",
               movil = "12345",
               vigente = true
            };
        }
    }
}
