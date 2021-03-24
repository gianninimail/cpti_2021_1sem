using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private String usuario;
        public string Usuario 
        { 
            get => usuario; 
            
            set => usuario = value; 
        }

        public String Senha { get; set; }
        
    }
}
