using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Estudiantes
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorios _appContext;
        [BindProperty]
        public Estudiante estudiante { get; set; }

        public CrearModel(){
            //cargar desde la base de datos tabla estudiante
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
            //cargarTemporales();
        }
       

        public IActionResult OnGet(int? estudianteId)
        {
            if (estudianteId.HasValue)
            {
                estudiante = _appContext.GetEstudiante(estudianteId.Value);
            }
            else
            {
                estudiante = new Estudiante();
            }
            if (estudiante == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(estudiante.id > 0)
            {
               estudiante = _appContext.UpdateEstudiante(estudiante);
            }
            else
            {
                //estudiante.vigente = true;
               _appContext.AddEstudiante(estudiante);
            }
            return Redirect("List");
            
        }
    }
}