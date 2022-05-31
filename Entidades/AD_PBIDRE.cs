using System;
using System.ComponentModel.DataAnnotations;

namespace MvParticipacoes.Api.Entidades
{
    [Serializable]
    public class AD_PBIDRE
    {
        [Key]
        public Int64? ID { get; set; }

        public Int64? CODGRUPONAT { get; set; }

        public string DESCRGRUPONAT{ get; set; }

        public string AD_VARCALC{ get; set; }

        public Int64? CODEMP { get; set; }

        public Int64? CODCENCUS { get; set; }

        public Int64?  CODNAT { get; set; }

        public string DESCRNAT{ get; set; }

        public DateTime DTENTSAI { get; set; }

        public string VLRDESDOB { get; set; }

        public Int64? NUMNOTA { get; set; }

        public Int64? NUFIN { get; set; }

        public string ORIGEM { get; set; }

        public decimal VLRORCA { get; set; }

        public Int32? CODPARC { get; set; }

        public Int32? SEQUENCIA { get; set; }

        public Int32? FORMATO_DRE { get; set; }

    }
}
