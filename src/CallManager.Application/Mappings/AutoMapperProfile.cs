using AutoMapper;
using CallManager.Api.DTOs.Chamado;
using CallManager.Api.DTOs.Colaborador;
using CallManager.Application.Models;

namespace CallManager.Api.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Colaborador, ColaboradorDto>().ReverseMap();
            CreateMap<Chamado, ChamadoDto>().ReverseMap();
        }
    }
}
