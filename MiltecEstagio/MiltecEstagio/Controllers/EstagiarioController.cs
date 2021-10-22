using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiltecEstagio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiltecEstagio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstagiarioController : ControllerBase
    {
        public Contexto contexto { get; set; }

        public EstagiarioController(Contexto novoContexto)
        {
            this.contexto = novoContexto;
        }

        [HttpGet]

        public List<Estagiario> Get()
        {
            return contexto.Estagiarios.ToList();
        }

        [HttpGet("{id}")]

        public Estagiario Get(int id)
        {
            return contexto.Estagiarios.First(e => e.IdEstagiario == id);
        }

        [HttpPost]
        [Route("add")]

        public async Task<ActionResult<Estagiario>> Create(Estagiario estagiario)
        {
            estagiario.IdEstagiario = 0;
            contexto.Estagiarios.Add(estagiario);
            await contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = estagiario.IdEstagiario, estagiario });
        }

        [HttpPost]
        [Route("update")]

        public async Task<ActionResult<Estagiario>> Update(Estagiario estagiario)
        {
            contexto.Estagiarios.Add(estagiario);
            await contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = estagiario.IdEstagiario, estagiario });
        }

    }
}
