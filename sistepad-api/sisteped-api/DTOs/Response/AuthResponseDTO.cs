namespace SistepedApi.DTOs.Response
{
    public class AuthResponseDTO
    {
        public string Token { get; set; }
        public UserResponseDTO User { get; set; }
    }
}
