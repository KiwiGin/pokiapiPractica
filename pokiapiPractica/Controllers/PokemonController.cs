using pokiapiPractica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace pokiapiPractica.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonService _pokemonService;

        public PokemonController()
        {
            _pokemonService = new PokemonService();
        }

        public async Task<ActionResult> Details(string name)
        {
            var pokemon = await _pokemonService.GetPokemonAsync(name);
            return View(pokemon);
        }

        // Método para mostrar la vista de búsqueda
        public ActionResult Search()
        {
            return View();
        }
    }
}
