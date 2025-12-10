using SistepedApi.Models;

namespace SistepedApi.Repositories.Interfaces
{
    public interface IUserCredentialRepository
    {
        Task<UserCredential?> GetByUserIdAsync(int userId);
        Task<UserCredential> CreateAsync(UserCredential credential);
    }
}