using EjemploOracle.DataAccess.Models;
using EjemploOracle.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploOracle.Services.Implementation
{
    public class CategoriaService : ICategoriaService
    {
        public Task<RespuestaService<Categorium>> Actualizar(Categorium c)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaService<Categorium>> BuscarPorId(decimal id)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaService<bool>> Eliminar(decimal id)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaService<Categorium>> Guardar(Categorium c)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaService<List<Categorium>>> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
