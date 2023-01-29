using CoreBox.Domain;

namespace FindFood.Models.Models.Categorias
{
    public class Categoria : Entity<Categoria>
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
    }
}
