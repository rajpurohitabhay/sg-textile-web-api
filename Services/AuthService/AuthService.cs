using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sg_textile_web_api.Repositories.AuthRepository;

namespace sg_textile_web_api.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthService(IAuthRepository authRepository, IHttpContextAccessor httpContextAccessor)
        {
            _authRepository = authRepository;
            _httpContextAccessor = httpContextAccessor;

        }
        public  async Task<ServiceResponse<string>> Login(string username, string password)
        {
            return await _authRepository.Login(username, password);
        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            return await _authRepository.Register(user, password);
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext!.User.FindFirstValue(ClaimTypes.NameIdentifier)!);
    
    }
}