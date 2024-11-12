namespace JogosCatalogoApi.Models
{
    public class Jogo
    {
        public int JogoId { get; set; }
        public string? Nome { get; set; }
        public string? Genero { get; set; }
        public string? ImagemUrl { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataLancamento { get; set; }
        public bool JaAdquirido { get; set; }
        public int DistribuidoraId { get; set; }
        public Distribuidora? Distribuidora { get; set; }
    }
}
