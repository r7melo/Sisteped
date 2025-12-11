using SistepedApi.DTOs.Request;
using SistepedApi.DTOs.Response;

namespace SistepedApi.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserResponseDTO> GetByIdAsync(int id);
        Task<IEnumerable<UserResponseDTO>> GetAllAsync();
        Task<UserResponseDTO> CreateAsync(UserCreateDTO dto);
    }
}