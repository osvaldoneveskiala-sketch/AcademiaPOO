using System;

namespace AcademiaPOO.Exceptions
{
    public class PagamentoEmAtrasoException : Exception
    {
        public PagamentoEmAtrasoException()
            : base("Pagamento em atraso.")
        {
        }
    }
}