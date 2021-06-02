using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Estado
    {
        public Int32 ID { get; set; }

        public String Descricao { get; set; }

        public List<Cidade> Cidades { get; set; }
    }
}
