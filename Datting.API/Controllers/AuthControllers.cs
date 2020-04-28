using Microsoft.AspNetCore.Mvc;
using Datting.API.Data;
using System.Threading.Tasks;
using Datting.API.Models;
using Datting.API.Dtos;

namespace Datting.API.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            //validação do request

            userForRegisterDto.UserName = userForRegisterDto.UserName.ToLower();

            if(await _repo.UserExists(userForRegisterDto.UserName))
                return BadRequest("Usuário já cadastrado!");

            var userToCreate = new User
            {
                Username = userForRegisterDto.UserName
            };

            var createdUser = await _repo.Register(userToCreate,userForRegisterDto.Password);

            return StatusCode(201);


        }

    }
}