using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Exceptions
{
    public class AnimalException : ApplicationException
    {
        public AnimalException(string message) : base(message) { }
    }

    public class FuncionarioException : ApplicationException
    {
        public FuncionarioException(string message) : base(message) { }
    }

    public class ClienteException : ApplicationException
    {
        public ClienteException(string message) : base(message) { }
    }
    public class FicheiroException : ApplicationException
    {
        public FicheiroException(string message) : base(message) { }
    }

}
