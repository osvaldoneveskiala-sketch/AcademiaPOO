using System;

namespace AcademiaPOO.Models
{
    public class AulaColectiva
    {
        private string nome;
        private int vagas;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Vagas
        {
            get { return vagas; }
            set { vagas = value; }
        }

        public AulaColectiva(string nome, int vagas)
        {
            this.nome = nome;
            this.vagas = vagas;
        }
    }
}