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
    public class TutorController : ControllerBase
    {
        public Contexto contexto { get; set; }

        public TutorController(Contexto novoContexto)
        {
            this.contexto = novoContexto;
        }

        [HttpGet]

        public List<Tutor> Get()
        {
            return contexto.Tutors.ToList();
        }

        [HttpGet("{id}")]

        public Tutor Get(int id)
        {
            return contexto.Tutors.First(e => e.IdTutor == id);
        }

        [HttpPost]

        public String Post([FromBody] Tutor tutor)
        {
            try
            {
                tutor.IdTutor = 0;
                contexto.Tutors.Add(tutor);
                contexto.SaveChanges();
                return "ok";
            }
            catch (Exception e)
            {
                return "Erro" + e.Message;
            }

        }
        [HttpPut]
        
        public String Put([FromBody] Tutor tutor)
        {
            try { 
            contexto.Tutors.Update(tutor);
            contexto.SaveChanges();
            return "ok";
            }catch (Exception e)
            {
                return "Erro" + e.Message;
            }
        }
    }
}
