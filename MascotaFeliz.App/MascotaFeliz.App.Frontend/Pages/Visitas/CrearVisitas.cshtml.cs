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
        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioHistoria _repoHistoria;
        [BindProperty]
        
        public VisitaPyP visitaPyP { get; set; }
        public Mascota mascota { get; set; }
        public Historia historia { get; set; }

        public CrearVisitasModel()
        {
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        }

        public IActionResult OnGet(int mascotaId)
        {
           mascota = _repoMascota.GetMascota(mascotaId);
           historia = _repoHistoria.GetHistoria(mascota.Historia.Id);
           visitaPyP = new VisitaPyP();
           DateTime date1 = DateTime.Now;
           visitaPyP.FechaVisita = date1;
           


            return Page();
        }


        public IActionResult OnPost(VisitaPyP visitaPyP, int historiaId, int veterinarioId, int mascotaId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            if (visitaPyP != null)
            {
                visitaPyP.IdVeterinario = veterinarioId;
                historia = _repoHistoria.GetHistoria(historiaId);

                historia.VisitasPyP.Add(visitaPyP);
                _repoHistoria.UpdateHistoria(historia);

            }
            
            return RedirectToPage("/Mascotas/DetallesMascotas", new { mascotaId = mascotaId});
        }
    }
}
