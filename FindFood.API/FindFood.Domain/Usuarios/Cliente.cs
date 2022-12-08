using CoreBox.Domain;

namespace FindFood.Domain.Usuarios
{
    public partial class Usuario : Entity<Usuario>
    {
        public string Cpf { get; private set; }
        public string Genero { get; private set; }
        public DateTime DataNascimento { get; private set; }
    }
}
