using System;
using System.ComponentModel.DataAnnotations;

namespace MvParticipacoes.Api.Entidades
{
    [Serializable]
    public class AD_FORMATODRE
    {
        [Key]
        public Int32? ID { get; set; }

        public string DESCRICAO { get; set; }
        
        public Int32? SUBTOTAL { get; set; }
    }
}
