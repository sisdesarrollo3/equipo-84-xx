using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Equipos
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorios _appContext;
        [BindProperty]
        public Equipo Equipo { get; set; }
        public IEnumerable<Formador> formadores {get; set;} 
        public IEnumerable<Tutor> tutores {get; set;} 
        public IEnumerable<EstadoProyecto> estadoProyectos {get; set;} 
        public string searchString;     

        public CrearModel(){
            //cargar desde la base de datos tabla Equipo
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
            //cargarTemporales();
        }
       

        public IActionResult OnGet(int? EquipoId)
        {
            formadores = _appContext.GetAllFormadores(searchString);
            tutores    = _appContext.GetAllTutores(searchString);
            estadoProyectos    = _appContext.GetAllEstadoProyectos(searchString);
            if (EquipoId.HasValue)
            {                
                Equipo = _appContext.GetEquipo(EquipoId.Value);
            }
            else
            {
                Equipo = new Equipo();
            }
            if (Equipo == null)
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
            if(Equipo.id > 0)
            {
               Equipo = _appContext.UpdateEquipo(Equipo);
            }
            else
            {
                //Equipo.vigente = true;
               _appContext.AddEquipo(Equipo);
            }
            return Redirect("List");
            
        }
    }
}