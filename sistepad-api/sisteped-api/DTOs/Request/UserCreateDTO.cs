namespace SistepedApi.DTOs.Request
{
    public class UserCreateDTO
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
    }
}