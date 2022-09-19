using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class CrearVisitasModel : PageModel
    {
        private readonly IRepositorioVisitaPyP _repoVisita;
        [BindProperty]
        
        public VisitaPyP visitaPyP { get; set; }

        public CrearVisitasModel()
        {
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());
        }

        public IActionResult OnGet()
        {
            visitaPyP = new VisitaPyP();
            visitaPyP.FechaVisita = new DateTime();
            return Page();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            if (visitaPyP != null)
            {
                _repoVisita.AddVisitaPyP(visitaPyP);
            }
            
            return Page();
        }
    }
}
