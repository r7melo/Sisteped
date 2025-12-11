using AutoMapper;
using SistepedApi.Repositories.Interfaces;
using SistepedApi.DTOs.Request;
using SistepedApi.DTOs.Response;
using SistepedApi.Models;
using SistepedApi.Services.Interfaces;
using SistepedApi.Resources;

namespace SistepedApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(
            IUserRepository userRepository,
            IUserCredentialRepository userCredentialRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserResponseDTO?> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return user != null ? _mapper.Map<UserResponseDTO>(user) : null;
        }

        public async Task<IEnumerable<UserResponseDTO>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserResponseDTO>>(users);
        }

        public async Task<UserResponseDTO?> CreateAsync(UserCreateDTO dto)
        {
            var existingUser = await _userRepository.GetByEmailAsync(dto.Email);

            if (existingUser != null)
            {
                throw new Exception(ErrorMessages.EXC001);
            }

            var user = _mapper.Map<User>(dto);

            var passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            var userCredentials = new UserCredential
            {
                UserId = user.Id,
                User = user,
                PasswordHash = passwordHash,
            };

            var createdUser = await _userRepository.CreateAsync(user, userCredentials);
            return createdUser != null ? _mapper.Map<UserResponseDTO>(createdUser) : null;
        }
    }
}