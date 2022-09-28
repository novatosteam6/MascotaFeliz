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
    public class ListaDuenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;
        public IEnumerable<Dueno> listaDuenos {get;set;}
        [BindProperty]
        public Dueno dueno { get; set; }

        public ListaDuenosModel()
        {
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        }
         

        public IActionResult OnGet(int? duenoId)
        {
            if (duenoId.HasValue)
            {
                _repoDueno.DeleteDueno(duenoId.Value);
            }

            dueno = new Dueno();

            listaDuenos = _repoDueno.GetAllDuenos();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            if (dueno != null)
            {
                _repoDueno.AddDueno(dueno);
            }
            
            return RedirectToPage("/Duenos/ListaDuenos");
        }
    }
}
