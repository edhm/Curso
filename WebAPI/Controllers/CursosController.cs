using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Cursos;
using Dominio;
//using Aplicacion.Cursos;
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
        //   http://localhost:5000/api/Cursos
        //   http://localhost:5000/api/Cursos/1
        [HttpGet("{id}")]   
        public async Task<ActionResult<Curso>> Detalle(int id)
        {
            return await _mediator.Send(new ConsultaId.CursoUnico{Id=id});
        }
    }
}