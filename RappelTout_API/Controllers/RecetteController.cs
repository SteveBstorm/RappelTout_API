using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RappelTout_API.Services;

namespace RappelTout_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetteController : ControllerBase
    {
        private readonly RecetteRepository _recetteRepository;

        public RecetteController(RecetteRepository recetteRepository)
        {
            _recetteRepository = recetteRepository;
        }

        //Renvoi la liste des recette
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        //Renvoi une recette par rapport à son id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //N'oublie pas de proposer l'ajout d'une recette
    }
}
