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
    public class CrearMascotasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        [BindProperty]
        public Mascota mascota { get; set; }

        public CrearMascotasModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        }

        public IActionResult OnGet()
        {
            mascota = new Mascota();
            return Page();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            if (mascota != null)
            {
                _repoMascota.AddMascota(mascota);
            }
            
            return Page();
        }
    }
}
