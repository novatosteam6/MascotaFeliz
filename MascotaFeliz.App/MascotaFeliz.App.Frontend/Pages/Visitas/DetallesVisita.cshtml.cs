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
    public class DetallesVisitaModel : PageModel
    {
        private readonly IRepositorioVisitaPyP _repoVisita; 
        public VisitaPyP visitaPyP {get;set;}

        public DetallesVisitaModel()
        {
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());
        }

        public IActionResult OnGet(int visitaId)
        {
            visitaPyP =_repoVisita.GetVisitaPyP(visitaId);
            if (visitaPyP == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}
