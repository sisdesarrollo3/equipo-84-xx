using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Roles
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorios _appContext;
        [BindProperty]
        public Rol Rol { get; set; }

        public CrearModel(){
            //cargar desde la base de datos tabla Rol
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
            //cargarTemporales();
        }
       

        public IActionResult OnGet(int? RolId)
        {
            if (RolId.HasValue)
            {
                Rol = _appContext.GetRol(RolId.Value);
            }
            else
            {
                Rol = new Rol();
            }
            if (Rol == null)
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
            if(Rol.id > 0)
            {
               Rol = _appContext.UpdateRol(Rol);
            }
            else
            {
                //Rol.vigente = true;
               _appContext.AddRol(Rol);
            }
            return Redirect("List");
            
        }
    }
}