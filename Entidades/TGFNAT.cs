using System;
using System.ComponentModel.DataAnnotations;

namespace MvParticipacoes.Api.Entidades
{
    [Serializable]
    public class TGFNAT
    {
        [Key]
        public Int64? CODNAT { get; set; }

        public string DESCRNAT { get; set; }
        
    }
}
