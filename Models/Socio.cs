using System;
using AcademiaPOO.Interfaces;

namespace AcademiaPOO.Models
{
    public class Socio : Pessoa, INotificavel
    {
        private int id;
        private TipoPlano plano;
        private EstadoPagamento estadoPagamento;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public TipoPlano Plano
        {
            get { return plano; }
            set { plano = value; }
        }

        public EstadoPagamento EstadoPagamento
        {
            get { return estadoPagamento; }
            set { estadoPagamento = value; }
        }

        public Socio(int id, string nome, string telefone, TipoPlano plano)
            : base(nome, telefone)
        {
            this.id = id;
            this.plano = plano;
            estadoPagamento = EstadoPagamento.Pendente;
        }

        public void EnviarNotificacao()
        {
            Console.WriteLine("Notificação enviada para o sócio.");
        }

        public override void ExibirDados()
        {
            base.ExibirDados();

            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Plano: {plano}");
            Console.WriteLine($"Pagamento: {estadoPagamento}");
        }
    }
}