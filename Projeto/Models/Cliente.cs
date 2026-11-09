using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemploCerto.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CadastroNacional { get; set; }
        public int QtVeiculos { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int CEP { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
    }
}
