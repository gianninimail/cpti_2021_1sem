using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.EnderecoPadrao = new Endereco();
        }
        public Int64 CPF { get; set; }

        public String Nome { get; set; }

        public Int32 Idade { get; set; }

        public String Cel { get; set; }

        public String Email { get; set; }

        public Int32 EstadoCivil { get; set; }

        public Boolean Animais { get; set; }

        public Boolean Filhos { get; set; }

        public bool Fumante { get; set; }

        public Endereco EnderecoPadrao { get; set; }
    }
}
