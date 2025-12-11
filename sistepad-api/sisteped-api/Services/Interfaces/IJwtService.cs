using SistepedApi.DTOs.Request;
using SistepedApi.DTOs.Response;

namespace SistepedApi.Services.Interfaces
{
    public interface IJwtService
    {
        Task<AuthResponseDTO> GenerateToken(UserCredentialDTO userCredentials);
    }
}
