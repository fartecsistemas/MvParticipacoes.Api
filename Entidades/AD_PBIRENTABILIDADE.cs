using System;
using System.ComponentModel.DataAnnotations;

namespace MvParticipacoes.Api.Entidades
{
    [Serializable]
    public class AD_PBIRENTABILIDADE
    {
        [Key]
        public Int64? ID { get; set; }        
        public Int64? CODEMP{ get; set; }
        public Int64? NUNOTA{ get; set; }
        public Int64? SEQUENCIA{ get; set; }
        public Int64? CODPROD{ get; set; }
        public string DESCRPROD{ get; set; }
        public Int64? NUMNOTA{ get; set; }
        public Int64? CODCENCUS{ get; set; }
        public Int64? CODNAT{ get; set; }
        public Int64? CODPARC{ get; set; }
        public string QTDNEG{ get; set; }
        public string DTNEG{ get; set; }
        public string CUSTOVARIAVEL{ get; set; }
        public string VLRPIS{ get; set; }
        public string VLRCOFINS{ get; set; }
        public string CUSTOICMS{ get; set; }
        public string CUSTOGERENCIAL{ get; set; }
        public string PARTCUSTOFIXO{ get; set; }
        public string MARGEMCONTRIB{ get; set; }
        public string VALORVENDA{ get; set; }
        public string LUCRO{ get; set; }
        public string VLRCOMCAB { get; set; }

    }
}
