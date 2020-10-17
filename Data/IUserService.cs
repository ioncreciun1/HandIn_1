using HandIn_1.Models;

namespace HandIn_1.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}