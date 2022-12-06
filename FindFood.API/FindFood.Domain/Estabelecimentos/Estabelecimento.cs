using CoreBox.Domain;

namespace FindFood.Domain.Estabelecimentos
{
    public partial class Estabelecimento : Entity<Estabelecimento>
    {
        public string Nome { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public IEnumerable<Categoria> Categorias { get; set; }
    }
}
