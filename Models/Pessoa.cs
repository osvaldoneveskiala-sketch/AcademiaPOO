using System;

namespace AcademiaPOO.Models
{
    public class Pessoa
    {
        private string nome;
        private string telefone;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Pessoa(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Telefone: {telefone}");
        }
    }
}