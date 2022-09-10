using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;

namespace Proyectos.App.Presentacion.Formadores
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Formador formador { get; set; }

        public void OnGet()        
        {
        }
    }
}
