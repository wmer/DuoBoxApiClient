using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoBoxApiClient.Models {
    public class Devedores {
        public string id { get; set; }
        public string em_observacao { get; set; }
        public string cli_telefone { get; set; }
        public string cli_celular { get; set; }
        public int boleto_id { get; set; }
        public string origem_tipo { get; set; }
        public string origem_id { get; set; }
        public string documento_tipo { get; set; }
        public string documento_id { get; set; }
        public string cliente_id { get; set; }
        public int total { get; set; }
        public string data_instalacao { get; set; }
        public string vendedor { get; set; }
        public string cli_nome { get; set; }
        public string nosso_numero { get; set; }
        public string data_vencimento { get; set; }
        public string valor_documento { get; set; }
        public object status { get; set; }
        public string servico_status { get; set; }
        public string servico_nome { get; set; }
        public int dias_atraso { get; set; }
        public double valor_atualizado { get; set; }
        public string valor_documento_formatado { get; set; }
        public string valor_atualizado_formatado { get; set; }
    }
}
