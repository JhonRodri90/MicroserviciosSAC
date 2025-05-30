using AutoMapper;
using Microsoft.AspNetCore.Identity.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MicroservicioUsuariosSAC.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        
        /*CreateMap<Usuarios, UsuarioResponse>().ForMember(dest => dest.us_id, opt => opt.MapFrom(src => src.us_id))
            .ForMember(dest => dest.us_apellido, opt => opt.MapFrom(src => src.us_apellido))
            .ForMember(dest => dest.us_correo, opt => opt.MapFrom(src => src.us_correo))
            .ForMember(dest => dest.us_identificacion, opt => opt.MapFrom(src => src.us_identificacion))
            .ForMember(dest => dest.us_nombre, opt => opt.MapFrom(src => src.us_nombre))
            .ForMember(dest => dest.us_telefono, opt => opt.MapFrom(src => src.us_telefono))
            .ForMember(dest => dest.us_ti_id, opt => opt.MapFrom(src => src.us_ti_id))
            .ForMember(dest => dest.Tipo_Identificacion, opt => opt.MapFrom(src => src.Tipo_Identificacion));

        CreateMap<UsuarioResponse, Usuarios>()
            .ForMember(dest => dest.us_id, opt => opt.MapFrom(src => src.us_id))
            .ForMember(dest => dest.us_apellido, opt => opt.MapFrom(src => src.us_apellido))
            .ForMember(dest => dest.us_correo, opt => opt.MapFrom(src => src.us_correo))
            .ForMember(dest => dest.us_identificacion, opt => opt.MapFrom(src => src.us_identificacion))
            .ForMember(dest => dest.us_nombre, opt => opt.MapFrom(src => src.us_nombre))
            .ForMember(dest => dest.us_telefono, opt => opt.MapFrom(src => src.us_telefono))
            .ForMember(dest => dest.us_ti_id, opt => opt.MapFrom(src => src.us_ti_id))
            .ForMember(dest => dest.Tipo_Identificacion, opt => opt.MapFrom(src => src.Tipo_Identificacion))
            .ForMember(dest => dest.Tipos_Usuarios, opt => opt.MapFrom(src => src.Tipos_Usuarios));

        CreateMap<Usuarios, UsuarioRequest>()
            .ForMember(dest => dest.us_id, opt => opt.MapFrom(src => src.us_id))
            .ForMember(dest => dest.us_apellido, opt => opt.MapFrom(src => src.us_apellido))
            .ForMember(dest => dest.us_correo, opt => opt.MapFrom(src => src.us_correo))
            .ForMember(dest => dest.us_identificacion, opt => opt.MapFrom(src => src.us_identificacion))
            .ForMember(dest => dest.us_nombre, opt => opt.MapFrom(src => src.us_nombre))
            .ForMember(dest => dest.us_telefono, opt => opt.MapFrom(src => src.us_telefono))
            .ForMember(dest => dest.us_ti_id, opt => opt.MapFrom(src => src.us_ti_id));

        CreateMap<UsuarioRequest, Usuarios>()
            .ForMember(dest => dest.us_id, opt => opt.MapFrom(src => src.us_id))
            .ForMember(dest => dest.us_apellido, opt => opt.MapFrom(src => src.us_apellido))
            .ForMember(dest => dest.us_correo, opt => opt.MapFrom(src => src.us_correo))
            .ForMember(dest => dest.us_identificacion, opt => opt.MapFrom(src => src.us_identificacion))
            .ForMember(dest => dest.us_nombre, opt => opt.MapFrom(src => src.us_nombre))
            .ForMember(dest => dest.us_telefono, opt => opt.MapFrom(src => src.us_telefono))
            .ForMember(dest => dest.us_ti_id, opt => opt.MapFrom(src => src.us_ti_id));

        CreateMap<IEnumerable<Tipo_Identificacion>, IEnumerable<TipoIdentificacionResponse>>()
            .ConvertUsing((src, dest, context) => src.Select(x => context.Mapper.Map<TipoIdentificacionResponse>(x)).ToList());

        CreateMap<Tipo_Identificacion, TipoIdentificacionResponse>()
            .ForMember(dest => dest.ti_id, opt => opt.MapFrom(src => src.ti_id))
            .ForMember(dest => dest.ti_descripcion, opt => opt.MapFrom(src => src.ti_descripcion));


        CreateMap<TipoIdentificacionResponse, Tipo_Identificacion>()
            .ForMember(dest => dest.ti_id, opt => opt.MapFrom(src => src.ti_id))
            .ForMember(dest => dest.ti_descripcion, opt => opt.MapFrom(src => src.ti_descripcion));

        CreateMap<TipoIdentificacionResponse, TipoIdentificacionResDto>()
            .ReverseMap();

        CreateMap<Colaboradores, ColaboradorResponse>()
            .ForMember(dest => dest.col_id, opt => opt.MapFrom(src => src.col_id))
            .ForMember(dest => dest.col_nombre, opt => opt.MapFrom(src => src.col_nombre))
            .ForMember(dest => dest.col_apellido, opt => opt.MapFrom(src => src.col_apellido))
            .ForMember(dest => dest.col_identificacion, opt => opt.MapFrom(src => src.col_identificacion))
            .ForMember(dest => dest.col_telefono, opt => opt.MapFrom(src => src.col_telefono))
            .ForMember(dest => dest.col_email, opt => opt.MapFrom(src => src.col_email))
            .ForMember(dest => dest.col_tc_id, opt => opt.MapFrom(src => src.col_tc_id))
            .ForMember(dest => dest.col_tu_id, opt => opt.MapFrom(src => src.col_tu_id))
            .ForMember(dest => dest.col_activo, opt => opt.MapFrom(src => src.col_activo))
            .ForMember(dest => dest.col_col_id_lider, opt => opt.MapFrom(src => src.col_col_id_lider));

        CreateMap<ColaboradorResponse, Colaboradores>()
           .ForMember(dest => dest.col_id, opt => opt.MapFrom(src => src.col_id))
            .ForMember(dest => dest.col_nombre, opt => opt.MapFrom(src => src.col_nombre))
            .ForMember(dest => dest.col_apellido, opt => opt.MapFrom(src => src.col_apellido))
            .ForMember(dest => dest.col_identificacion, opt => opt.MapFrom(src => src.col_identificacion))
            .ForMember(dest => dest.col_telefono, opt => opt.MapFrom(src => src.col_telefono))
            .ForMember(dest => dest.col_email, opt => opt.MapFrom(src => src.col_email))
            .ForMember(dest => dest.col_tc_id, opt => opt.MapFrom(src => src.col_tc_id))
            .ForMember(dest => dest.col_tu_id, opt => opt.MapFrom(src => src.col_tu_id))
            .ForMember(dest => dest.col_activo, opt => opt.MapFrom(src => src.col_activo))
            .ForMember(dest => dest.col_col_id_lider, opt => opt.MapFrom(src => src.col_col_id_lider));

        CreateMap<LoginRequest, LoginReqDto>()
            .ReverseMap();*/
    }
}
