namespace ProjetoExemploCerto.Models
{
    public class OrdemServicoItem
    {
        public int ItemId { get; set; }

        public int OrdemServicoId { get; set; }

        public string Tipo { get; set; }

        public string Descricao { get; set; }

        public decimal Quantidade { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal Subtotal { get; set; }
    }
}