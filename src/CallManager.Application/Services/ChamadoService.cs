﻿using AutoMapper;
using CallManager.Application.DTOs.Chamado;
using CallManager.Application.Enums;
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
            var chamado = _mapper.Map<Chamado>(chamadoCreateDto);            

            if (!ExecutarValidacao(new ChamadoValidator(), chamado)) return;

            chamado.DataAbertura = DateTime.UtcNow;

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
            var chamado = await _chamadoRepository.ObterPorIdAsync(chamadoUpdateDto.Id);

            if (chamado is null)
            {
                Notificar("O chamado informado não existe.");
                return;
            }

            if (chamado.Status == StatusChamado.Concluido)
            {
                Notificar("Chamados já concluídos não podem ser alterados.");
                return;
            }

            chamado.Tratativa = chamadoUpdateDto.Tratativa;
            chamado.Status = chamadoUpdateDto.Status;

            if (chamado.Status == StatusChamado.Concluido)
            {
                chamado.DataConclusao = DateTime.UtcNow;
            }

            if (!ExecutarValidacao(new ChamadoValidator(), chamado)) return;

            await _chamadoRepository.AtualizarAsync(chamado);
        }

        public async Task RemoverAsync(int id)
        {
            await _chamadoRepository.RemoverAsync(id);
        }
    }
}
