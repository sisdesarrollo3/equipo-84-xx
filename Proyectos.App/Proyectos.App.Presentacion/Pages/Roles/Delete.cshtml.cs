using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Pages.Roles
{
    public class DeleteModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Rol formador  { get; set; } 

        public DeleteModel()
        {            
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int? rolId)
        {
            if (rolId.HasValue)
            {
                formador = _appContext.GetRol(rolId.Value);
            }
            if (formador == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        //se ejecuta al presionar Eliminar en el formulario
        public IActionResult OnPost()
        {
            if(formador.id > 0)
            {     
               _appContext.DeleteRol(formador.id);           
            }
            return Redirect("List");
        }
    }
}