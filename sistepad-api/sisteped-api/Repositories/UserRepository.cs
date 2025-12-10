using Microsoft.EntityFrameworkCore;
using SistepedApi.Models;
using SistepedApi.Repositories.Interfaces;
using SistepedApi.Infra.Data;

namespace SistepedApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SistepedDbContext _context;

        public UserRepository(SistepedDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> CreateAsync(User user, UserCredential userCredentials)
        {
            user.CreatedAt = DateTime.Now;
            _context.Users.Add(user);
            _context.UserCredentials.Add(userCredentials);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}