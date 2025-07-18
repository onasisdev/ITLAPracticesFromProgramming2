using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurePasswordGenerator.Application.Contract;
using SecurePasswordGenerator.Application.Dtos;

namespace SecurePasswordGenerator.Application.Service
{
    public class PasswordGeneratorService : IPasswordGeneratorService
    {
      
        public async Task<string> GeneratePassword(PasswordCriteriaDto criteria)
        {
         
            List<char> characters = new List<char>();
           


            if (criteria.IncludeSpecialCharacters == true)
            {
                characters.AddRange("!@#$%^&*()-_=+[]{}\\)");
            }

            if (criteria.IncludeNumbers == true)
            {
                characters.AddRange("0562819473056281947305");
            }

            if (criteria.IncludeUppercaseLetters == true)
            {
                characters.AddRange("AFRTHLPOCXEIUMNDGEGKEH");
            }

            if (criteria.IncludeLowerCaseLetters == true)
            {
                characters.AddRange("qwrtypsdfghjklzxcvbnmq");
            }

            var password = new char[criteria.PasswordLength];
            var random = new Random();

            for (int i = 0; i < criteria.PasswordLength; i++)
            {
                password[i] = characters[random.Next(characters.Count)];
            }

            return await Task.FromResult(new string(password));
        }
    }
}

