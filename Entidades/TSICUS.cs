using System;
using System.ComponentModel.DataAnnotations;

namespace MvParticipacoes.Api.Entidades
{
    [Serializable]
    public class TSICUS
    {
        [Key]
        public Int64? CODCENCUS { get; set; }

        public string DESCRCENCUS { get; set; }

        public string ATIVO { get; set; }

    }
}
