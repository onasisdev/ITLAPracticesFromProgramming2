using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurePasswordGenerator.Application.Dtos;

namespace SecurePasswordGenerator.Application.Contract
{
    public interface IPasswordEvaluationService
    {

        Task<List<string>> EvaluatePassword(PasswordEvaluationDto passwordEvaluation, PasswordCriteriaDto passwordCriteria);

    }
}
