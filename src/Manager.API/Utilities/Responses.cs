using System.Collections.Generic;
using Manager.API.ViewModels;

namespace Manager.API.Utilities{
    public static class Responses{
        public static ResultViewModel ApplicationErrorMessage(){
            return new ResultViewModel{
                Message = "Ocorreu algum erro interno na aplicação, por favor tente novamente.",
                Success = false,
                Data = null
            };
        }

        public static ResultViewModel DomainErroMessage(string message){
            return new ResultViewModel{
                Message = message,
                Success = false,
                Data = null
            };
        }

        public static ResultViewModel DomainErroMessage(string message,  IReadOnlyCollection<string> erros){
            return new ResultViewModel{
                Message = message,
                Success = false,
                Data = erros
            };
        }   

        public static ResultViewModel UnauthorizedErrorMessage(){
            return new ResultViewModel{
                Message = "A combinação de login e senha está incorreta!",
                Success = false,
                Data = null
            };
        }               

    }
}