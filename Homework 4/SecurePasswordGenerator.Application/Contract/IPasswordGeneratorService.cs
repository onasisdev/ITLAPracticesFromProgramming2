using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurePasswordGenerator.Application.Dtos;

namespace SecurePasswordGenerator.Application.Contract
{
    public interface IPasswordGeneratorService
    {
        Task<string> GeneratePassword(PasswordCriteriaDto criteria);
    }
}
