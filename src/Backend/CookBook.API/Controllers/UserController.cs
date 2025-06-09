using CookBook.Aplication.UseCases.User.Register;
using CookBook.Communication.Requests;
using CookBook.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CookBook.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        public IActionResult Register(RequestRegisterUserJson request)
        {
            var useCase = new RegisterUserUseCase();

            var result = useCase.Execute(request);

            return Created(string.Empty, request);
        }
    }
}
