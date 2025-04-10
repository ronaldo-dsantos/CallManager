﻿using AutoMapper;
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
        private readonly IMapper _mapper;

        public ChamadoService(IChamadoRepository chamadoRepository,
                              IMapper mapper,
                              INotificador notificador) : base(notificador)
        {
            _chamadoRepository = chamadoRepository;
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

            await _chamadoRepository.AdicionarAsync(chamado);            
        }            

        public async Task AtualizarAsync(ChamadoUpdateDto chamadoUpdateDto)
        {
            var chamado = _mapper.Map<Chamado>(chamadoUpdateDto);

            if (!ExecutarValidacao(new ChamadoValidator(), chamado)) return;

            await _chamadoRepository.AtualizarAsync(chamado);
        }            

        public async Task RemoverAsync(int id)
            => await _chamadoRepository.RemoverAsync(id);
    }
}
