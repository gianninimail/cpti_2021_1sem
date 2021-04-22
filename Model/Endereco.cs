using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Endereco
    {
        public Int32 ID { get; set; }

        public Int32 TipoEnd { get; set; }

        public String Logradouro { get; set; }

        public Int32 Cidade { get; set; }

        public Int32 Estado { get; set; }

        public override String ToString()
        {
            return String.Format("{0} {1} - {2}/{3}", this.TipoEnd, this.Logradouro, this.Cidade, this.Estado);
        }
    }
}
