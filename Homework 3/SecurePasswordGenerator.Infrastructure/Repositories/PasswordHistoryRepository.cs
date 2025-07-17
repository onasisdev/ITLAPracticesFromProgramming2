using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurePasswordGenerator.Domain;
using SecurePasswordGenerator.Domain.Entities;
using SecurePasswrodGenerator.Infraestructure.Context;
using SecurePasswrodGenerator.Infraestructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SecurePasswrodGenerator.Infraestructure.Repositories
{
    public class PasswordHistoryRepository : IPasswordHistoryRepository
    {
        private readonly AppDbContext _context;

        public PasswordHistoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PasswordHistory>> GetAllAsync()
        {
            return await _context.PasswordHistories.ToListAsync();
        }

        public async Task<PasswordHistory> GetByIdAsync(int id)
        {
            return await _context.PasswordHistories.FindAsync(id);
        }

        public async Task AddAsync(PasswordHistory history)
        {
            await _context.PasswordHistories.AddAsync(history);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PasswordHistory passwordHistory)
        {
            var existingpassword = await _context.PasswordHistories.FindAsync(passwordHistory.Id);

            if (existingpassword != null)
            {
                existingpassword.Id = passwordHistory.Id;
                existingpassword.PasswordGenerated = passwordHistory.PasswordGenerated;
                existingpassword.CreatedIn = passwordHistory.CreatedIn;

                _context.PasswordHistories.Update(existingpassword);
                await _context.SaveChangesAsync();
            }
        }


        public async Task DeleteAsync(int id)
        {
            var passwordId = await _context.PasswordHistories.FindAsync(id);
            if (passwordId != null)
            {
                _context.PasswordHistories.Remove(passwordId);
                await _context.SaveChangesAsync();
            }
        }
    }
}
