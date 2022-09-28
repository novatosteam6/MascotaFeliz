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
    public class ListaMascotasModel : PageModel

    {
        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioHistoria _repoHistoria;

        public Mascota mascota { get; set; }
        public Historia historia { get; set; }
        public Veterinario veterinario { get; set; }
        public Dueno dueno { get; set; }
        public IEnumerable<Dueno> listaDuenos { get; set; }
        public IEnumerable<Veterinario> listaVeterinarios { get; set; }
        public IEnumerable<Mascota> listaMascotas {get;set;}

        public ListaMascotasModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        }
        
        public IActionResult OnGet(int? mascotaId)
        {
            if (mascotaId.HasValue)
            {
                _repoMascota.DeleteMascota(mascotaId.Value);
            }

            listaDuenos = _repoDueno.GetAllDuenos();
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();

            mascota = new Mascota();
            historia = new Historia();
            DateTime date1 = DateTime.Now;
            historia.FechaInicial = date1;
            historia.VisitasPyP = new List<VisitaPyP>();

            listaMascotas = _repoMascota.GetAllMascotas();
            return Page();
        }

        public IActionResult OnPost(Mascota mascota, Historia historia, int duenoId, int veterinarioId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            dueno = _repoDueno.GetDueno(duenoId);
            veterinario = _repoVeterinario.GetVeterinario(veterinarioId);
            
            if (mascota != null)
            {
                _repoHistoria.AddHistoria(historia);
                _repoMascota.AddMascota(mascota);
                _repoMascota.AsignarVeterinario(mascota.Id,veterinario.Id);
                _repoMascota.AsignarDueno(mascota.Id,dueno.Id);
                _repoMascota.AsignarHistoria(mascota.Id, historia.Id);
                
            }
            
            return RedirectToPage("/Mascotas/ListaMascotas");
        }



    }
}
