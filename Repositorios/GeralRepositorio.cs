using System;
using MvParticipacoes.Api.Context;

namespace MvParticipacoes.Api.Repositorios
{
    public class GeralRepositorio
    {
        private readonly OracleDbContext _context;

        public GeralRepositorio(OracleDbContext context)
        {
            _context = context;
        }
    }
}
