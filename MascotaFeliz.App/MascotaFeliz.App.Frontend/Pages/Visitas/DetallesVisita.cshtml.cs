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
        private readonly IRepositorioHistoria _repoHistoria; 
        private readonly IRepositorioMascota _repoMascota; 

        public VisitaPyP visitaPyP {get;set;}
        public Historia historia {get;set;}
        public Mascota mascota {get;set;}

        public DetallesVisitaModel()
        {
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        }

        public IActionResult OnGet(int visitaId, int historiaId, int mascotaId)
        {
            visitaPyP =_repoVisita.GetVisitaPyP(visitaId);
            historia =_repoHistoria.GetHistoria(historiaId);
            mascota =_repoMascota.GetMascota(mascotaId);

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
