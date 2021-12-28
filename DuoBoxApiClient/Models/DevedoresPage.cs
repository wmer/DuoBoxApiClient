using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoBoxApiClient.Models {
    public class DevedoresPage {
        public int page { get; set; }
        public int total { get; set; }
        public string records { get; set; }
        public List<Devedores> rows { get; set; }
        public DevedoresUserdata userdata { get; set; }
    }
}
