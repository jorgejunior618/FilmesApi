using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(
                nameof(EncontrarFilmePorID),
                new { _id = filme.Id },
                "Filme Cadastrado com sucesso"
            );
        }

        [HttpGet]
        public IActionResult ListarFilme()
        {
            return Ok(filmes);
        }

        [HttpGet("{_id}")]
        public IActionResult EncontrarFilmePorID(int _id)
        {
            Filme? filme = filmes.Find(f=> f.Id == _id);

            if (filme != null)
            {
                return Ok(filme);
            }
            return NotFound();
        }
    }
}
