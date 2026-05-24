using AcademiaPOO.Exceptions;
using AcademiaPOO.Models;
using System;
using System.Collections.Generic;

namespace AcademiaPOO.Services
{
    public class GestorAcademia
    {
        private List<Socio> socios;
        private List<AulaColectiva> aulas;
        private List<Inscricao> inscricoes;

        public GestorAcademia()
        {
            socios = new List<Socio>();
            aulas = new List<AulaColectiva>();
            inscricoes = new List<Inscricao>();
        }

        public void AdicionarSocio(Socio socio)
        {
            socios.Add(socio);
        }

        public void AdicionarAula(AulaColectiva aula)
        {
            aulas.Add(aula);
        }

        public void ListarSocios()
        {
            foreach (var socio in socios)
            {
                socio.ExibirDados();

                Console.WriteLine("-------------------------");
            }
        }

        public Socio BuscarSocio(int id)
        {
            foreach (var socio in socios)
            {
                if (socio.Id == id)
                {
                    return socio;
                }
            }

            throw new SocioNaoEncontradoException();
        }

        public void FazerInscricao(int socioId, AulaColectiva aula)
        {
            Socio socio = BuscarSocio(socioId);

            if (aula.Vagas <= 0)
            {
                throw new AulaLotadaException();
            }

            Inscricao inscricao = new Inscricao(socio, aula);

            inscricoes.Add(inscricao);

            aula.Vagas--;
        }

        public void RegistarPagamento(int socioId)
        {
            Socio socio = BuscarSocio(socioId);

            socio.EstadoPagamento = EstadoPagamento.Pago;
        }
    }
}