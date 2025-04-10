using CallManager.Api.DTOs.Chamado;
using FluentValidation;

namespace CallManager.Application.Validators
{
    public class ChamadoCreateDtoValidator : AbstractValidator<ChamadoCreateDto>
    {
        public ChamadoCreateDtoValidator()
        {
            RuleFor(c => c.MatriculaColaborador)
                .NotEmpty().WithMessage("A matrícula do colaborador é obrigatória.")
                .GreaterThan(0).WithMessage("A matrícula do colaborador deve ser maior que zero.");

            RuleFor(c => c.Detalhes)
                .NotEmpty().WithMessage("O campo detalhes é obrigatório.")
                .MaximumLength(1000).WithMessage("Detalhes deve ter no máximo 1000 caracteres.");

            RuleFor(c => c.TipoSolicitacao)
                .NotEmpty().WithMessage("O tipo de solicitação é obrigatório.")
                .IsInEnum().WithMessage("Tipo de solicitação inválido.");
        }
    }
}
