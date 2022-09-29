using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Pages.Equipos
{
    public class EditModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Equipo Equipo  { get; set; } 

        public EditModel()
        {            
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? EquipoId)
        {
            if (EquipoId.HasValue)
            {
                Equipo = _appContext.GetEquipo(EquipoId.Value);
            }
            if (Equipo == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        //se ejecuta al presionar Editar en el formulario
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
            return Redirect("List");
        }
    }
}