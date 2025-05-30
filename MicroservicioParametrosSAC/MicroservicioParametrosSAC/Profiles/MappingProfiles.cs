using AutoMapper;
using Core.Entities;
using Microsoft.AspNetCore.Identity.Data;

namespace MicroservicioParametrosSAC.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {

        //CreateMap<IEnumerable<Tipo_Identificacion>, IEnumerable<TipoIdentificacionResponse>>()
        //    .ConvertUsing((src, dest, context) => src.Select(x => context.Mapper.Map<TipoIdentificacionResponse>(x)).ToList());

        //CreateMap<Tipo_Identificacion, TipoIdentificacionResponse>()
        //    .ForMember(dest => dest.ti_id, opt => opt.MapFrom(src => src.ti_id))
        //    .ForMember(dest => dest.ti_descripcion, opt => opt.MapFrom(src => src.ti_descripcion));


        //CreateMap<TipoIdentificacionResponse, Tipo_Identificacion>()
        //    .ForMember(dest => dest.ti_id, opt => opt.MapFrom(src => src.ti_id))
        //    .ForMember(dest => dest.ti_descripcion, opt => opt.MapFrom(src => src.ti_descripcion));

        //CreateMap<TipoIdentificacionResponse, TipoIdentificacionResDto>()
        //    .ReverseMap();

    }
}
