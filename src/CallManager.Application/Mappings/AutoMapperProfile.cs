using AutoMapper;
using CallManager.Application.DTOs.Chamado;
using CallManager.Application.DTOs.Colaborador;
using CallManager.Application.Models;

namespace CallManager.Api.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Colaborador, ColaboradorDto>().ReverseMap();

            CreateMap<Chamado, ChamadoCreateDto>().ReverseMap();
            CreateMap<Chamado, ChamadoUpdateDto>().ReverseMap();
            CreateMap<Chamado, ChamadoReadDto>()
                .ForMember(dest => dest.Colaborador, opt => opt.MapFrom(src => src.Colaborador));
        }
    }
}
