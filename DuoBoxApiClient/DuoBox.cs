using DuoBoxApiClient.Models;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoBoxApiClient {
    public class DuoBox {
        private CosumingHelper _api;

        public DuoBox(string baseAdress, string username, string password) {
            _api = new CosumingHelper(baseAdress);
            _api = _api
                    .AddcontentType("application/x-www-form-urlencoded", "utf-8", true)
                    .AddCustomHeaders("X-Requested-With", "XMLHttpRequest")
                    .AddBasicAuthentication(username, password);
        }

        public async Task<ClientesPage> GetClientes(FiltrosCliente filtros) {
            var result = await _api.PostAsync<FiltrosCliente, ClientesPage>("clientes?json", filtros);
            return result.result;
        }

        public async Task<BoletoPages> GetBoletos(FiltrosClienteCobranca filtros) {
            var result = await _api.PostAsync<FiltrosClienteCobranca, BoletoPages>("clientes_cobrancas/pesquisa?json", filtros);
            return result.result;
        }

        public async Task<List<Devedores>> GetDevedores(FiltrosDevedores filtros) {
            var result = await _api.PostAsync<FiltrosDevedores, DevedoresPage>("relatorios/financeiro/devedores?json", filtros);

            return result.result?.rows;
        }
    }
}
