using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoBoxApiClient.Models {
    public class FiltrosDevedores {
        public bool _search { get; set; }
        public string nd { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string vencimento_inicio { get; set; }
        public string vencimento_fim { get; set; }
        public string revendas_id { get; set; }
        public string contrato_suspenso { get; set; }
        public string em_observacao { get; set; }
        public string incluir_rescindidos { get; set; }
        public string tipo { get; set; }
        public string vendedor_id { get; set; }
        public string data_instalacao_inicial { get; set; }
        public string data_instalacao_final { get; set; }
        public string forma_cobranca { get; set; }
        public string sidx { get; set; }
        public string sord { get; set; }
        public string rows { get; set; }
        public string page { get; set; }
    }
}
