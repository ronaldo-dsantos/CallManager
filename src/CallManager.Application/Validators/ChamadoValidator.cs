using CallManager.Application.Models;
using FluentValidation;

namespace CallManager.Application.Validators
{
    public class ChamadoValidator : AbstractValidator<Chamado>
    {
        public ChamadoValidator()
        {
            RuleFor(c => c.MatriculaColaborador)
                .NotEmpty().WithMessage("A matrícula do colaborador é obrigatória.")
                .InclusiveBetween(1, 999999).WithMessage("A matrícula deve ter de 1 a 6 dígitos.");

            RuleFor(c => c.Tipo)
                .IsInEnum().WithMessage("O tipo do chamado informado é inválido.");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("O campo Descrição é obrigatório.")
                .MaximumLength(1000).WithMessage("O campo Descrição deve ter no máximo 1000 caracteres.");

            RuleFor(c => c.Status)
                .IsInEnum().WithMessage("Status inválido para o chamado");
        }
    }
}
