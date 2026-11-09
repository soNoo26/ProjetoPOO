using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemploCerto.Models
{
    public class Veiculo
    {
        public int IdVeiculo { get; set; }
        public int IdCliente { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Motor {  get; set; }
        public string Combustivel { get; set; }

        public string ClienteNome { get; set; }
    }
}
