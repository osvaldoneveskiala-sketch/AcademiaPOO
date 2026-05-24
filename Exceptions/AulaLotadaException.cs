using System;

namespace AcademiaPOO.Exceptions
{
    public class AulaLotadaException : Exception
    {
        public AulaLotadaException()
            : base("A aula está lotada.")
        {
        }
    }
}