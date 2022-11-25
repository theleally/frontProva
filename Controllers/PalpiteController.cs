using System.Collections.Generic;
using System.Linq;
using api.Models;
using API_Copa.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/palpite")]
    public class PalpiteController : ControllerBase
    {
        private readonly Context _context;
        public PalpiteController(Context context) =>
            _context = context;

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Palpite palpite)
        {
            _context.Selecoes.Add(palpite);
            _context.SaveChanges();
            return Created("", palpite);
        }
        

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Palpite> palpites = _context.palpites.ToList();
            return Palpites.Count != 0 ? Ok(Palpites) : NotFound();
        }
    }
}