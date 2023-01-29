using CoreBox.Domain;

namespace FindFood.Domain.Usuarios
{
    public class Cliente : Entity<Cliente>
    {
        public string Cpf { get; private set; }
        public string Genero { get; private set; }
        public DateTime DataNascimento { get; private set; }
    }
}
