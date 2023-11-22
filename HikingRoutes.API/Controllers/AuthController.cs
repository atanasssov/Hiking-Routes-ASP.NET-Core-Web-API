using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using HikingRoutes.API.Models.DTOs;
using HikingRoutes.API.Repositories;

namespace HikingRoutes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ITokensRepository _tokensRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokensRepository tokensRepository)
        {
            _userManager = userManager;
            _tokensRepository = tokensRepository;
        }

        // Register an user
        // POST https://localhost:portnumber/api/Auth/Register
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            IdentityUser identityUser = new IdentityUser
            {
                UserName = registerRequestDto.Username,
                Email = registerRequestDto.Username
            };

            IdentityResult identityResult = await _userManager.CreateAsync(identityUser, registerRequestDto.Password);

            if(identityResult.Succeeded)
            {
                if (registerRequestDto.Roles != null && registerRequestDto.Roles.Any())
                {
                    identityResult = await _userManager.AddToRolesAsync(identityUser, registerRequestDto.Roles);

                    if (identityResult.Succeeded)
                    {
                        return Ok("User was registered! Please login.");
                    }
                }
            }

            return BadRequest("Something went wrong");
        }

        // Login user
        // POST https://localhost:portnumber/api/Auth/Login
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            IdentityUser? user = await _userManager.FindByEmailAsync(loginRequestDto.Username);

            if (user != null)
            {
                bool checkPasswordResult = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);

                if (checkPasswordResult)
                {
                    IList<string> roles = await _userManager.GetRolesAsync(user);

                    if (roles != null)
                    {

                        string jwtToken = _tokensRepository.CreateJWTToken(user, roles.ToList());

                        LoginResponseDto response = new LoginResponseDto
                        {
                            JwtToken = jwtToken
                        };

                        return Ok(response);
                    }
                }
            }

            return BadRequest("Username or password is incorrect");
        }

    }
}
