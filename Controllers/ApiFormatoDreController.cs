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
    public class ApiFormatoDreController : ControllerBase
    {
        private readonly OracleDbContext _context;

        public ApiFormatoDreController
        (
            OracleDbContext context
        )
        {
            _context = context;
        }
        
        //private readonly ILogger<ApiFormatoDreController> _logger;

        //public ApiFormatoDreController(ILogger<ApiFormatoDreController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet("{idCliente}")]
        public List<AD_FORMATODRE> GetFormato()
        {
            //_context = new EfDbContext();
            var registros = _context.AD_FORMATODRE.ToList();

            return registros;
        }
    }
}
