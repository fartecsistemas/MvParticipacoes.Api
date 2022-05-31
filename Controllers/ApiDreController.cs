using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvParticipacoes.Api.Context;
using MvParticipacoes.Api.Entidades;

namespace MvParticipacoes.Api.Controllers
{
    [ApiController]
    [Route("[controller]/{action}/")]
    public class ApiDreController : ControllerBase
    {
        private readonly OracleDbContext _context;

        public ApiDreController
        (
            OracleDbContext context
        )
        {
            _context = context;
        }

        public List<TSIEMP> GetEmpresa()
        {
            var registros = _context.TSIEMP.ToList();
            return registros;
        }

        public List<TSICUS> GetCentroCusto()
        {
            var registros = _context.TSICUS.ToList();
            return registros;
        }

        public List<TGFNAT> GetNatureza()
        {
            var registros = _context.TGFNAT.ToList();
            return registros;
        }

        public List<AD_FORMATODRE> GetFormatoDre()
        {        
            var registros = _context.AD_FORMATODRE.ToList();
            return registros;
        }

        public List<AD_PBIDRE> GetPbiDre()
        {
            var registros = _context.AD_PBIDRE.ToList();
            return registros;
        }

        public List<AD_PBIRENTABILIDADE> GetPbiRentabilidade()
        {
            var registros = _context.AD_PBIRENTABILIDADE.ToList();
            return registros;
        }
    }
}
