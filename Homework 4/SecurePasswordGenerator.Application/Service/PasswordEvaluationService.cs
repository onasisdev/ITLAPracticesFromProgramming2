using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurePasswordGenerator.Application.Contract;
using SecurePasswordGenerator.Application.Dtos;

namespace SecurePasswordGenerator.Application.Service
{
    public class PasswordEvaluationService : IPasswordEvaluationService
    {

        public async Task<PasswordEvaluationDto> EvaluatePassword(PasswordEvaluationDto passwordEvaluation, PasswordCriteriaDto passwordCriteria)
        {
            var passwordGenerationService = new PasswordGenerationService();


            string password = await passwordGenerationService.GeneratePassword(passwordCriteria);

            int amountOfCriteriaCompleted = 0;


            if (password.Length < 8)
            {

                passwordEvaluation.Suggestions.Add( """

                    La contraseña es demasiado corta.
                    Asegúrate de que tenga al menos 8 
                    caracteres para mayor seguridad
                    
                    """);

                Console.WriteLine(passwordEvaluation.Suggestions);

            }
            else if (password.Length >= 8) 
            {
                amountOfCriteriaCompleted += 1;
            }


            if (passwordCriteria.IncludeSpecialCharacters == false)
            {
                passwordEvaluation.Suggestions.Add("Añade símbolos como @, %, # o & para dificultar que tu contraseña sea adivinada.");

            }
            else
            {
                amountOfCriteriaCompleted += 1;
            }

            
            if (passwordCriteria.IncludeNumbers == false)
            {
                passwordEvaluation.Suggestions.Add("Incorpora al menos un número para fortalecer la contraseña.");

            }
            else
            {
                amountOfCriteriaCompleted += 1;
            }


            if (passwordCriteria.IncludeUppercaseLetters == false)
            {
                passwordEvaluation.Suggestions.Add("Incluye al menos una letra mayúscula para fortalecer la contraseña.");    
            
            } 
            else
            { 
                amountOfCriteriaCompleted += 1;
            }


            if (passwordCriteria.IncludeLowerCaseLetters == false)
            {
                passwordEvaluation.Suggestions.Add("Agrega letras minúsculas para fortalecer la contraseña.");

            } 
            else
            {
                amountOfCriteriaCompleted += 1;
            }


            if (password.Contains("1234") || password.Contains("abcd") || password.Contains("querty"))
            {
                passwordEvaluation.Suggestions.Add("Evita secuencias predecibles como '1234' o 'abcd'; estas reducen la seguridad de tu contraseña.")   ;
               
            } else if (!password.Contains("1234") || !password.Contains("abcd") || !password.Contains("querty"))
            {
                amountOfCriteriaCompleted += 1;
            }

            
            if (amountOfCriteriaCompleted <= 2)
            {
                passwordEvaluation.EvaluationStrengthMessage = "Nivel de seguridad: Débil";
                
            } else if (amountOfCriteriaCompleted > 2 && amountOfCriteriaCompleted <= 4)
            {
                passwordEvaluation.EvaluationStrengthMessage = "Nivel de seguridad: Media";

            } else if (amountOfCriteriaCompleted > 4 && amountOfCriteriaCompleted <=6)
            {
                passwordEvaluation.EvaluationStrengthMessage = "Nivel de seguridad: Fuerte";
            }


            PasswordEvaluationDto evaluationResult = new PasswordEvaluationDto
            {
                EvaluationStrengthMessage = passwordEvaluation.EvaluationStrengthMessage,
                Suggestions = passwordEvaluation.Suggestions
            };
            
            
            return await Task.FromResult(evaluationResult);
        }
    }
}

