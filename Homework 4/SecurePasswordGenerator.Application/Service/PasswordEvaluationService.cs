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

        public async Task<string> EvaluatePassword(PasswordEvaluationDto passwordEvaluation)
        {
            var passwordGenerationService = new PasswordGenerationService();

            var criteria = new PasswordCriteriaDto();

            string password = await passwordGenerationService.GeneratePassword(criteria);

            int amountOfCriteriaCompleted = 0;

           

            

            




            if (password.Length < 8)
            {

                passwordEvaluation.Suggestions = """

                    La contraseña es demasiado corta.
                    Asegúrate de que tenga al menos 8 
                    caracteres para mayor seguridad
                    
                    """;

                Console.WriteLine(passwordEvaluation.Suggestions);

            }
            else if (password.Length >= 8) {

                amountOfCriteriaCompleted += 1;

            }

            


            if (criteria.IncludeUppercaseLetters == false)
            {
                passwordEvaluation.Suggestions = "Incluye al menos una letra mayúscula para fortalecer la contraseña.";
                passwordEvaluation.EvaluationStrengthMessage = "Nivel de seguridad: Media";

                Console.WriteLine(passwordEvaluation.Suggestions);
                Console.WriteLine(passwordEvaluation.EvaluationStrengthMessage);
            } 
            else
            {
                amountOfCriteriaCompleted += 1;
            }


            if (criteria.IncludeLowerCaseLetters == false)
            {
                passwordEvaluation.Suggestions = "Agrega letras minúsculas para mejorar la complejidad de tu contraseña";
                passwordEvaluation.EvaluationStrengthMessage = "Nivel de seguridad: Media";

                Console.WriteLine(passwordEvaluation.Suggestions);
                Console.WriteLine(passwordEvaluation.EvaluationStrengthMessage);

            } 
            else
            {
                amountOfCriteriaCompleted += 1;
            }

            if (criteria.IncludeNumbers == false)
            {
                passwordEvaluation.Suggestions = "Incorpora al menos un número para mejorar la complejidad de tu contraseña.";
                passwordEvaluation.EvaluationStrengthMessage = "Nivel de seguridad: Media";

                Console.WriteLine(passwordEvaluation.Suggestions);
                Console.WriteLine(passwordEvaluation.EvaluationStrengthMessage);
            }
            else {
                amountOfCriteriaCompleted += 1;

            }

            if (criteria.IncludeSpecialCharacters == false)
            {
                passwordEvaluation.Suggestions = "Añade símbolos como @, %, # o & para dificultar que tu contraseña sea adivinada.";
                passwordEvaluation.EvaluationStrengthMessage = "Nivel de seguridad: Media";

                Console.WriteLine(passwordEvaluation.Suggestions);
                Console.WriteLine(passwordEvaluation.EvaluationStrengthMessage);

            } 
            else
            {
                amountOfCriteriaCompleted += 1;
            }

            if (password.Contains("1234") || password.Contains("abcd") || password.Contains("querty"))
            {
                passwordEvaluation.Suggestions = "Evita secuencias predecibles como '1234' o 'abcd'; estas reducen la seguridad de tu contraseña.";
                passwordEvaluation.EvaluationStrengthMessage = "Nivel de seguridad: Débil";

                Console.WriteLine(passwordEvaluation.Suggestions);
                

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

                Console.WriteLine(passwordEvaluation.EvaluationStrengthMessage);


            return await Task.FromResult(new string(passwordEvaluation.ToString()));
        }
    }
}

