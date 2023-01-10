using CoreBox.Domain;

namespace FindFood.Domain.Usuarios
{
    public partial class Usuario : Entity<Usuario>
    {
        public string Cnpj { get; private set; } 
    }
}
