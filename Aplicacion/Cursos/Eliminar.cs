using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistencia;

namespace Aplicacion.Cursos
{
    public class Eliminar
    {       
            public class Ejecuta:IRequest
            {
                public int Id{get; set;}
            }
        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly CursosOnlineContext _context;
            public Manejador(CursosOnlineContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var curso= await _context.Curso.FindAsync(request.Id);
                if(curso==null)
                {
                    throw new Exception("Curso NO eliminado");
                }
                _context.Remove(curso);

                var resultado = await _context.SaveChangesAsync();
                
                if(resultado > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("Cambios NO guardados");

            }
        }

    }
}