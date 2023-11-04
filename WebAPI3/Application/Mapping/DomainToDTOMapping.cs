using WebAPI3.Domain.Model.FuncionarioAggregate;
using WebAPI3.Domain.DTOs;
using AutoMapper;

namespace WebAPI3.Application.Mapping;

public class DomainToDTOMapping : Profile
{
    public DomainToDTOMapping() 
    {
        CreateMap<Funcionario, FuncionarioDTO>()
            .ForMember(dest => dest.NomeFuncionario, m => m.MapFrom(orig => orig.nome)); 
    }
}
