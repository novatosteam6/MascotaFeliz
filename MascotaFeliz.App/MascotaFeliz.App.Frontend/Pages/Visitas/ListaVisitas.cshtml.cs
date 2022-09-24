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
        private readonly IRepositorioHistoria _repoHistoria; 
        private readonly IRepositorioMascota _repoMascota;


        public IEnumerable<VisitaPyP> listaVisitas {get;set;}
        public Historia historia {get;set;}
        public Mascota mascota {get;set;}
        public VisitaPyP visitaPyP {get;set;}
        
       

        public ListaVisitasModel()
        {
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        }
        
        public IActionResult OnGet(int? visitaId, int historiaId, int mascotaId)
        {
            

            if (visitaId.HasValue)
            {
                visitaPyP = _repoVisita.GetVisitaPyP(visitaId.Value);
                historia = _repoHistoria.GetHistoria(historiaId);
                historia.VisitasPyP.RemoveAll(x => x.Id == visitaId);
                _repoHistoria.UpdateHistoria(historia);
                _repoVisita.DeleteVisitaPyP(visitaId.Value);
            }

                mascota = _repoMascota.GetMascota(mascotaId);
                historia = _repoHistoria.GetHistoria(historiaId);
                listaVisitas = historia.VisitasPyP;
                if(listaVisitas.Count() <= 0) {

                    return RedirectToPage("/Error", new { mascotaId = mascotaId, historiaId = historiaId });
                }
            
            
            return Page();
        }
    }
}
