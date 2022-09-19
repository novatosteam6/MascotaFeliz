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
    public class ListaVisitasModel : PageModel
    {
        private readonly IRepositorioVisitaPyP _repoVisita; 
        public IEnumerable<VisitaPyP> listaVisitas {get;set;}

        public ListaVisitasModel()
        {
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());
        }
        
        public IActionResult OnGet(int? visitaId)
        {
            if (visitaId.HasValue)
            {
                _repoVisita.DeleteVisitaPyP(visitaId.Value);
            }

            listaVisitas = _repoVisita.GetAllVisitasPyP();
            return Page();
        }
    }
}
