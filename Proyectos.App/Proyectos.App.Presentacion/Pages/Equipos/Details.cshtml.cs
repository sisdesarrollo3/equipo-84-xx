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
    public class DetailsModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Equipo Equipo  { get; set; } 

        public DetailsModel()
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
    }
}