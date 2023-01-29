using CoreBox.Domain;

namespace FindFood.Domain.Usuarios
{
    public class Parceiro : Entity<Parceiro>
    {
        public string Cnpj { get; private set; } 
    }
}
