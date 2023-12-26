using System;
using System.Collections.Generic;

namespace Manager.Core.Exceptions{
    public class DomainException : Exception{
        internal List<string> _erros;
        public IReadOnlyCollection<string> Errors => _erros;

        public DomainException(){}

        public DomainException(String message, List<string> errors) : base(message){
            _erros = errors;
        }

        public DomainException(string message): base(message){}

        public DomainException(string message, Exception innerException) : base (message, innerException){

        }
    }
}