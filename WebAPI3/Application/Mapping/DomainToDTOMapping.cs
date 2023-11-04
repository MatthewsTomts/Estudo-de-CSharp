using AutoMapper;
using WebAPI3.Domain.DTOs;
using WebAPI3.Domain.Model.FuncionarioAggregate;

namespace WebAPI3.Application.Mapping;

public class DomainToDTOMapping : Profile
{
    public DomainToDTOMapping() 
    {
        CreateMap<Funcionario, FuncionarioDTO>()
            .ForMember(dest => dest.NomeFuncionario, m => m.MapFrom(orig => orig.nome)); 
    }
}
