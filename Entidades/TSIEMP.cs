using System;
using System.ComponentModel.DataAnnotations;

namespace MvParticipacoes.Api.Entidades
{
    [Serializable]
    public class TSIEMP
    {
        [Key]
        public Int64? CODEMP { get; set; }

        public string NOMEFANTASIA { get; set; }        

    }
}
