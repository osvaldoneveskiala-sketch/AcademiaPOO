namespace AcademiaPOO.Models
{
    public class Inscricao
    {
        private Socio socio;
        private AulaColectiva aula;

        public Socio Socio
        {
            get { return socio; }
            set { socio = value; }
        }

        public AulaColectiva Aula
        {
            get { return aula; }
            set { aula = value; }
        }

        public Inscricao(Socio socio, AulaColectiva aula)
        {
            this.socio = socio;
            this.aula = aula;
        }
    }
}