using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Pages.Tutores
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorios _appContext;
        [BindProperty]
        public Tutor tutor { get; set; }

        public CrearModel(){
            //cargar desde la base de datos tabla tutor
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
            //cargarTemporales();
        }
       

        public IActionResult OnGet(int? tutorId)
        {
            if (tutorId.HasValue)
            {
                tutor = _appContext.GetTutor(tutorId.Value);
            }
            else
            {
                tutor = new Tutor();
            }
            if (tutor == null)
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
            if(tutor.id > 0)
            {
               tutor = _appContext.UpdateTutor(tutor);
            }
            else
            {
               _appContext.AddTutor(tutor);
               return RedirectToPage("List");
            }
            return Page();
            
        }
    }
}