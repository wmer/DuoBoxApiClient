using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoBoxApiClient.Models {
    public class ClientesPage {
        public int page { get; set; }
        public string count { get; set; }
        public int total_pages { get; set; }
        public List<Cliente> registros { get; set; }
    }
}
