using System.Collections.ObjectModel;

namespace JogosCatalogoApi.Models
{
    public class Distribuidora
    {
        public Distribuidora()
        {
            Jogos = new Collection<Jogo>();
        }

        public int DistribuidoraId { get; set; }
        public string? Nome { get; set; }
        public string? ImagemUrl { get; set; }
        public Collection<Jogo>? Jogos { get; set; }
    }
}
