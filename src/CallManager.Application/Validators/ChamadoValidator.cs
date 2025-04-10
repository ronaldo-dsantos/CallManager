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
                .InclusiveBetween(100000, 999999).WithMessage("A matrícula deve conter 6 dígitos.");

            RuleFor(c => c.TipoSolicitacao)
                .IsInEnum().WithMessage("O tipo de solicitação informado é inválido.");

            RuleFor(c => c.Detalhes)
                .NotEmpty().WithMessage("O campo Detalhes é obrigatório.")
                .MaximumLength(1000).WithMessage("O campo Detalhes deve ter no máximo 1000 caracteres.");
        }
    }
}
