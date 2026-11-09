using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemploCerto.Models
{
    public class OrdemServiço
    {
        public int OrdemServicoId { get; set; }

        public int ClienteId { get; set; }

        public int VeiculoId { get; set; }

        public string DataAbertura { get; set; }

        public string DataPrevisao { get; set; }

        public string DataFechamento { get; set; }

        public string Status { get; set; }

        public string DescricaoProblema { get; set; }

        public string Diagnostico { get; set; }

        public string Observacoes { get; set; }

        public decimal ValorMaoDeObra { get; set; }

        public decimal ValorTotal { get; set; }

        public string ClienteNome { get; set; }

        public string VeiculoDescricao { get; set; }
    }
}