using AutoMapper;
using CallManager.Api.DTOs.Colaborador;
using CallManager.Application.Interfaces;
using CallManager.Application.Models;

namespace CallManager.Application.Services
{
    public class ColaboradorService : IColaboradorService
    {
        private readonly IColaboradorRepository _colaboradorRepository;
        private readonly IMapper _mapper;

        public ColaboradorService(IColaboradorRepository colaboradorRepository,
                                  IMapper mapper)
        {
            _colaboradorRepository = colaboradorRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ColaboradorDto>> ObterTodosAsync()
            => _mapper.Map<IEnumerable<ColaboradorDto>>(await _colaboradorRepository.ObterTodosAsync());

        public async Task<ColaboradorDto> ObterPorMatriculaAsync(int matricula)
            => _mapper.Map<ColaboradorDto>(await _colaboradorRepository.ObterPorIdAsync(matricula));

        public async Task AdicionarAsync(ColaboradorDto colaboradorDto)
        {
            var colaborador = _mapper.Map<Colaborador>(colaboradorDto);

            await _colaboradorRepository.AdicionarAsync(colaborador);
        }            

        public async Task AtualizarAsync(ColaboradorDto colaboradorDto)
        {
            var colaborador = _mapper.Map<Colaborador>(colaboradorDto);

            await _colaboradorRepository.AtualizarAsync(colaborador);
        }            

        public async Task RemoverAsync(int matricula)
            => await _colaboradorRepository.RemoverAsync(matricula);
    }
}
