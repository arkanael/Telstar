using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telstar.Domain.Entities
{
    public class Endereco
    {
        public virtual int IdEndereco { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string CEP { get; set; }

        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
