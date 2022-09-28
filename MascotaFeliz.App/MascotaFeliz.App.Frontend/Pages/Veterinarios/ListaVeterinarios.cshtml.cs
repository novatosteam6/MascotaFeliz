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
    public class ListaVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVeterinario; 
        public IEnumerable<Veterinario> listaVeterinarios {get;set;}
        [BindProperty]
        public Veterinario veterinario { get; set; }

        public ListaVeterinariosModel()
        {
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        }
        
        public IActionResult OnGet(int? veterinarioId)
        {
            if (veterinarioId.HasValue)
            {
                _repoVeterinario.DeleteVeterinario(veterinarioId.Value);
            }

            veterinario = new Veterinario();

            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
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
            
            return RedirectToPage("/Veterinarios/ListaVeterinarios");
        }
    }
}
