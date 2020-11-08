using System.Collections.Generic;
using System.Threading.Tasks;
using Dominio;
using Aplicacion.Cursos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //   http://localhost:5000/api/Cursos
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CursosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Curso>>> Get() {
             //return await  _mediator.Send(new Consulta.Aplicacion.Cursos)
         return await _mediator.Send(new Consulta.ListaCursos());
        }
            /*
            public async Task<ActionResult<List<Curso>>> Get() =>
             //return await  _mediator.Send(new Consulta.Aplicacion.Cursos)
             await _mediator.Send(new Consulta.Aplicacion.Cursos());
            */
    }
}