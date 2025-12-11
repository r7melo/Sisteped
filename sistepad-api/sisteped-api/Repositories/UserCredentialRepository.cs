using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using SistepedApi.Repositories.Interfaces;
using SistepedApi.Models;
using SistepedApi.Infra.Data;

namespace SistepedApi.Repositories
{
    public class UserCredentialRepository : IUserCredentialRepository
    {
        private readonly SistepedDbContext _context;

        public UserCredentialRepository(SistepedDbContext context)
        {
            _context = context;
        }

        public async Task<UserCredential?> GetByUserIdAsync(int userId)
        {
            return await _context.UserCredentials
                .Include(uc => uc.User)
                .FirstOrDefaultAsync(uc => uc.UserId == userId);
        }

        public async Task<UserCredential> CreateAsync(UserCredential credential)
        {
            _context.UserCredentials.Add(credential);
            await _context.SaveChangesAsync();
            return credential;
        }
    }
}