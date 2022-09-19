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
    public class CrearVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVeterinario;
        [BindProperty]
        public Veterinario veterinario { get; set; }

        public CrearVeterinariosModel()
        {
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        }

        public IActionResult OnGet()
        {
            veterinario = new Veterinario();
            return Page();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            if (veterinario != null)
            {
                _repoVeterinario.AddVeterinario(veterinario);
            }
            
            return Page();
        }
    }
}
