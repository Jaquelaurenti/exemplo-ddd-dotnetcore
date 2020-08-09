using AutoMapper;
using ExemploDDD.Application.Dtos;
using ExemploDDD.Domain.Entitys;

namespace ExemploDDD.Application.Mappers
{
    public class DtoToModelMappingCliente : Profile
    {
        public DtoToModelMappingCliente()
        {
            ClienteMap();
        }

        private void ClienteMap()
        {
            CreateMap<ClienteDto, Cliente>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(x => x.Sobrenome))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.DataCadastro, opt => opt.Ignore())
                .ForMember(dest => dest.IsAtivo, opt => opt.Ignore());

        }
    }
}
