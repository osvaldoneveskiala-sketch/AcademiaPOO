using System;

namespace AcademiaPOO.Exceptions
{
    public class SocioNaoEncontradoException : Exception
    {
        public SocioNaoEncontradoException() 
            : base("Sócio não encontrado.")
        {
        }
    }
}