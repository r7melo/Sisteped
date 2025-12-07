using System.Text.RegularExpressions;
using chronovault_api.DTOs.Request;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace chronovault_api.Validators
{
    public class UserCreateDTOValidator : AbstractValidator<UserCreateDTO>
    {
        public UserCreateDTOValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email é obrigatório.")
                .EmailAddress().WithMessage("Email não está no formato válido.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Nome é obrigatório.")
                .MaximumLength(100).WithMessage("Nome não pode conter mais de 100 caracteres.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Senha é obrigatória.")
                .MinimumLength(8).WithMessage("Senha deve possuir pelo menos 8 caracteres")
                .Equal(x => x.PasswordConfirmation).WithMessage("Senha e confirmação de senha devem ser iguais");
        }

        public class UserCredentialDTOValidator : AbstractValidator<UserCredentialDTO>
        {
            public UserCredentialDTOValidator()
            {
                RuleFor(x => x.Email)
                    .NotEmpty().WithMessage("Email é obrigatório.")
                    .EmailAddress().WithMessage("Email não está no formato válido.");

                RuleFor(x => x.Password)
                    .NotEmpty().WithMessage("Senha é obrigatória.")
                    .MinimumLength(8).WithMessage("Senha deve possuir pelo menos 8 caracteres");
            }
        }
    }
}