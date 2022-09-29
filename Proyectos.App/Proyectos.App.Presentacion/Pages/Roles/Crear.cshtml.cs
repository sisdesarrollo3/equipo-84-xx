using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Formadores
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorios _appContext;
        [BindProperty]
        public Formador formador { get; set; }

        public CrearModel(){
            //cargar desde la base de datos tabla formador
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
            //cargarTemporales();
        }
       

        public IActionResult OnGet(int? formadorId)
        {
            if (formadorId.HasValue)
            {
                formador = _appContext.GetFormador(formadorId.Value);
            }
            else
            {
                formador = new Formador();
            }
            if (formador == null)
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
            if(formador.id > 0)
            {
               formador = _appContext.UpdateFormador(formador);
            }
            else
            {
                //formador.vigente = true;
               _appContext.AddFormador(formador);
            }
            return Redirect("List");
            
        }
    }
}