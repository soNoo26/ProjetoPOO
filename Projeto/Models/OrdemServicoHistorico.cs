using System;

namespace ProjetoExemploCerto.Models
{
    public class OrdemServicoHistorico
    {
        public int HistoricoId { get; set; }

        public int OrdemServicoId { get; set; }

        public string StatusAnterior { get; set; }

        public string StatusNovo { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}   