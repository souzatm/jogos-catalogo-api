using System.Collections.ObjectModel;

namespace JogosCatalogoApi.Models
{
    public class Catalogo
    {
        public Catalogo()
        {
            Distribuidoras = new Collection<Distribuidora>();
            Jogos = new Collection<Jogo>();
        }
        public int CatalogoId { get; set; }
        public string? Nome { get; set; }
        public Collection<Distribuidora>? Distribuidoras { get; set; }
        public Collection<Jogo>? Jogos { get; set; }
    }
}
