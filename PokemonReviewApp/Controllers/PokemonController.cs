using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private IPokemonRepository _repository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            //PokemonRepository = pokemonRepository;
            _repository = pokemonRepository;
        }

        //public IPokemonRepository PokemonRepository { get; }

        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<Pokemon>))]

        public IActionResult GetPokemons()
        {
            var pokemons = _repository.GetPokemons();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(pokemons);
        }
    }   
}
