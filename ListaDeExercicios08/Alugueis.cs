using System;
using System.Globalization;

namespace ListaDeExercicios08
{
    internal class Alugueis
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Alugueis(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}
