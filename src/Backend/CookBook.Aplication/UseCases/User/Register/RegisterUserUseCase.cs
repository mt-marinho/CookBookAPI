using CookBook.Communication.Requests;
using CookBook.Communication.Responses;

namespace CookBook.Aplication.UseCases.User.Register
{
    public class RegisterUserUseCase
    {
        public ResponseRegisteredUserJson Execute(RequestRegisterUserJson request)
        {
            // validar a request
            Validate(request);

            // mapear a request em uma entidade

            // criptografia da senha

            // salvar no baco de dados

            return new ResponseRegisteredUserJson
            {
                Name = request.Name,
            };
        }

        public void Validate(RequestRegisterUserJson request)
        {
            var validator = new RegisterUserValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errorMessages = result.Errors.Select(e => e.ErrorMessage);

                throw new Exception();
            }
        }
    }
}
