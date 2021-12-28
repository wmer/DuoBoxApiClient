using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoBoxApiClient.Models {
    public class Cliente {
        public string id { get; set; }
        public string nome { get; set; }
        public string nome_fantasia { get; set; }
        public string data_nascimento { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public string tipo_pessoa { get; set; }
        public string exterior { get; set; }
        public string documento_exterior { get; set; }
        public string produtor_rural { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public object optante_simples_nacional { get; set; }
        public string responsavel { get; set; }
        public string ruc { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string endereco_numero { get; set; }
        public string endereco_complemento { get; set; }
        public string endereco_bairro { get; set; }
        public string endereco_referencia { get; set; }
        public string cidade_ibge { get; set; }
        public string cidade { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string pais { get; set; }
        public string coordenadas_gps { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string email2 { get; set; }
        public string rg { get; set; }
        public string nome_pai { get; set; }
        public string nome_mae { get; set; }
        public string profissao { get; set; }
        public string local_trabalho { get; set; }
        public string inscricao_estadual { get; set; }
        public string cobranca_igual { get; set; }
        public string cobranca_cep { get; set; }
        public string cobranca_endereco { get; set; }
        public object cobranca_endereco_numero { get; set; }
        public string cobranca_endereco_complemento { get; set; }
        public string cobranca_endereco_bairro { get; set; }
        public string cobranca_endereco_referencia { get; set; }
        public string cobranca_cidade_ibge { get; set; }
        public string cobranca_cidade { get; set; }
        public string cobranca_localidade { get; set; }
        public string cobranca_uf { get; set; }
        public string cobranca_pais { get; set; }
        public string cobranca_coordenadas_gps { get; set; }
        public string email_cobranca { get; set; }
        public string email_aniversario { get; set; }
        public string email_outros { get; set; }
        public string data_cadastro { get; set; }
        public string cadastro_usuarios_id { get; set; }
        public string data_alteracao { get; set; }
        public string alteracao_usuarios_id { get; set; }
        public string pre_cadastro_revendas_id { get; set; }
        public string pre_cadastro_internetplanos_id { get; set; }
        public string documento_bloqueado { get; set; }
        public string documento_bloqueado_data_hora { get; set; }
        public string documento_bloqueado_observacao { get; set; }
        public object documento_bloqueado_usuarios_id { get; set; }
        public string endereco_bloqueado { get; set; }
        public string cli_id { get; set; }
        public string cli_nome { get; set; }
        public string tipo_servico { get; set; }
        public string plan_nome { get; set; }
        public string plan_valor { get; set; }
        public string pl_id { get; set; }
        public string pl_ativo { get; set; }
        public string pl_status { get; set; }
        public string pl_plano_franquia_dados_atingida { get; set; }
        public string pl_data_instalacao { get; set; }
        public string pl_tipo_conexao { get; set; }
        public string pl_ip_rede { get; set; }
        public string pl_ip_mascara { get; set; }
        public string pl_pppoe_login { get; set; }
        public string pl_pppoe_ip { get; set; }
        public string pl_radio_mac { get; set; }
        public string pl_filtro_mac { get; set; }
        public string pl_ponto_acesso { get; set; }
        public string pl_tecnologia { get; set; }
        public string pl_dici_scm_tecnologias_id { get; set; }
        public string pl_dici_scm_tipo_atendimento { get; set; }
        public object telefone_ramal { get; set; }
    }
}
