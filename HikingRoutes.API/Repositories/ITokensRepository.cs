using Microsoft.AspNetCore.Identity;

namespace HikingRoutes.API.Repositories
{
    public interface ITokensRepository
    {
        /// <summary>
        /// Creates JWT 
        /// </summary>
        /// <param name="user">Information about the user</param>
        /// <param name="roles">List of the roles of the user</param>
        /// <returns></returns>
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
