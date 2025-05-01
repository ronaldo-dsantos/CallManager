using CallManager.Application.Models;
using FluentValidation;

namespace CallManager.Application.Validators
{
    public class ChamadoValidator : AbstractValidator<Chamado>
    {
        public ChamadoValidator()
        {
            RuleFor(c => c.ColaboradorId)
                .NotEmpty().WithMessage("O campo Id do Colaborador é obrigatório.")
                .NotEqual(Guid.Empty).WithMessage("O campo Id do Colaborador não pode ser vazio.");

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
