using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {

        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioHistoria _repoHistoria;

        public Historia historia {get;set;}
        public Mascota mascota {get;set;}

        public ErrorModel()
        {
        this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        }

    

        public IActionResult OnGet(int mascotaId, int historiaId)
        {
            mascota = _repoMascota.GetMascota(mascotaId);
            historia = _repoHistoria.GetHistoria(historiaId);

            return Page();
        }
    }
}
