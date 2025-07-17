using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurePasswordGenerator.Domain;

using SecurePasswordGenerator.Domain.Entities;

namespace SecurePasswrodGenerator.Infraestructure.Interfaces
{
    public interface IPasswordHistoryRepository
    {
        Task<IEnumerable<PasswordHistory>> GetAllAsync();
        Task<PasswordHistory> GetByIdAsync(int id);
        Task AddAsync(PasswordHistory history);
        Task UpdateAsync(PasswordHistory history);
        Task DeleteAsync(int id);
    }
}
