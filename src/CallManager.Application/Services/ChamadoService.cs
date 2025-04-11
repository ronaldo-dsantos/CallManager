using AutoMapper;
using CallManager.Api.DTOs.Chamado;
using CallManager.Application.DTOs.Chamado;
using CallManager.Application.Interfaces;
using CallManager.Application.Models;
using CallManager.Application.Validators;

namespace CallManager.Application.Services
{
    public class ChamadoService : BaseService, IChamadoService
    {
        private readonly IChamadoRepository _chamadoRepository;
        private readonly IColaboradorRepository _colaboradorRepository;
        private readonly IMapper _mapper;

        public ChamadoService(IChamadoRepository chamadoRepository,
                              IColaboradorRepository colaboradorRepository,
                              IMapper mapper,
                              INotificador notificador) : base(notificador)
        {
            _chamadoRepository = chamadoRepository;
            _colaboradorRepository = colaboradorRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ChamadoReadDto>> ObterTodosAsync()
        {
            var chamados = await _chamadoRepository.ObterChamadosComColaboradorAsync();

            return _mapper.Map<IEnumerable<ChamadoReadDto>>(chamados);
        }                   

        public async Task<ChamadoReadDto> ObterPorIdAsync(int id)
        {
            var chamado = await _chamadoRepository.ObterChamadoComColaboradorPorIdAsync(id);
            
            return _mapper.Map<ChamadoReadDto>(chamado);
        }

        public async Task AdicionarAsync(ChamadoCreateDto chamadoCreateDto)
        {
            if (!int.TryParse(chamadoCreateDto.MatriculaColaborador, out var matricula))
            {
                Notificar("A matrícula do colaborador deve ser numérica.");
                return;
            }

            var chamado = _mapper.Map<Chamado>(chamadoCreateDto);

            chamado.DataAbertura = DateTime.UtcNow;

            if (!ExecutarValidacao(new ChamadoValidator(), chamado)) return;

            var colaboradorExiste = await _colaboradorRepository.ObterPorIdAsync(chamado.MatriculaColaborador);

            if (colaboradorExiste == null)
            {
                Notificar("O colaborador informado não existe");
                return;
            }

            await _chamadoRepository.AdicionarAsync(chamado);            
        }            

        public async Task AtualizarAsync(ChamadoUpdateDto chamadoUpdateDto)
        {
            var chamadoExistente = await _chamadoRepository.ObterPorIdAsync(chamadoUpdateDto.Id);

            if (chamadoExistente == null)
            {
                Notificar("O chamado informado não existe.");
                return;
            }

            var chamado = _mapper.Map<Chamado>(chamadoUpdateDto);

            if (!ExecutarValidacao(new ChamadoValidator(), chamado)) return;

            await _chamadoRepository.AtualizarAsync(chamado);
        }

        public async Task RemoverAsync(int id)
        {
            var chamado = await _chamadoRepository.ObterPorIdAsync(id);

            if (chamado == null)
            {
                Notificar("O chamado informado não foi encontrado.");
                return;
            }

            await _chamadoRepository.RemoverAsync(id);
        }
    }
}
