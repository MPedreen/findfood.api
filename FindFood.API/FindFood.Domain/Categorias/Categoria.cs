using CoreBox.Domain;

namespace FindFood.Domain.Categorias
{
    public partial class Categoria : Entity<Categoria>
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
    }
}
