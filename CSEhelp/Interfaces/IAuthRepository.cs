using CSEhelp.Models;

namespace CSEhelp.Interfaces
{
    public interface IAuthRepository
    {
        public Task<ResponseModel> LoginUser(LoginViewModel loginViewModel);
    }
}
