﻿using CoreBox.Domain;

namespace FindFood.Domain.Usuarios
{
    public partial class Usuario : Entity<Usuario>
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
    }
}
