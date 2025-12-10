using chronovault_api.Models;
using SistepedApi.DTOs.Request;
using SistepedApi.DTOs.Response;
using System.Security.Claims;

namespace SistepedApi.Services.Interfaces
{
    public interface IJwtService
    {
        Task<AuthResponseDTO> GenerateToken(UserCredentialDTO userCredentials);
    }
}
