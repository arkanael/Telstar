using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telstar.Domain.Entities
{
    public class Cliente
    {
        public virtual int IdCliente { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DataNascimento { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}
