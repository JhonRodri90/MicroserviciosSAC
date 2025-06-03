﻿using AutoMapper;
using Core.Entities;
using Core.Request;
using Core.Response;
using MicroservicioHistorialSolicitudesSAC.Dtos;

namespace MicroservicioHistorialSolicitudesSAC.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {

        CreateMap<SolicitudRequest, SolicitudReqDto>()
            .ReverseMap();

        CreateMap<SolicitudResponse, SolicitudResDto>()
            .ReverseMap();

        CreateMap<Solicitudes, SolicitudResponse>()
            .ForMember(dest => dest.so_id, opt => opt.MapFrom(src => src.so_id))
            .ForMember(dest => dest.so_numero_solicitud, opt => opt.MapFrom(src => src.so_numero_solicitud))
            .ForMember(dest => dest.so_ts_id, opt => opt.MapFrom(src => src.so_ts_id))
            .ForMember(dest => dest.so_fecha_creacion, opt => opt.MapFrom(src => src.so_fecha_creacion))
            .ForMember(dest => dest.so_es_id, opt => opt.MapFrom(src => src.so_es_id))
            .ForMember(dest => dest.so_us_id, opt => opt.MapFrom(src => src.so_us_id))
            .ForMember(dest => dest.so_url_image, opt => opt.MapFrom(src => src.so_url_image))
            .ForMember(dest => dest.Usuarios, opt => opt.MapFrom(src => src.Usuarios))
            .ForMember(dest => dest.Tipos_Solicitudes, opt => opt.MapFrom(src => src.Tipos_Solicitudes))
            .ForMember(dest => dest.Estados_Solicitudes, opt => opt.MapFrom(src => src.Estados_Solicitudes))
            .ForMember(dest => dest.Colaboradores, opt => opt.MapFrom(src => src.Colaboradores))
            .ForMember(dest => dest.SolicitudApelacion, opt => opt.MapFrom(src => src.SolicitudApelacion));

        CreateMap<SolicitudResponse, Solicitudes>()
            .ForMember(dest => dest.so_id, opt => opt.MapFrom(src => src.so_id))
            .ForMember(dest => dest.so_numero_solicitud, opt => opt.MapFrom(src => src.so_numero_solicitud))
            .ForMember(dest => dest.so_ts_id, opt => opt.MapFrom(src => src.so_ts_id))
            .ForMember(dest => dest.so_fecha_creacion, opt => opt.MapFrom(src => src.so_fecha_creacion))
            .ForMember(dest => dest.so_es_id, opt => opt.MapFrom(src => src.so_es_id))
            .ForMember(dest => dest.so_us_id, opt => opt.MapFrom(src => src.so_us_id))
            .ForMember(dest => dest.so_url_image, opt => opt.MapFrom(src => src.so_url_image))
            .ForMember(dest => dest.Usuarios, opt => opt.MapFrom(src => src.Usuarios))
            .ForMember(dest => dest.Tipos_Solicitudes, opt => opt.MapFrom(src => src.Tipos_Solicitudes))
            .ForMember(dest => dest.Estados_Solicitudes, opt => opt.MapFrom(src => src.Estados_Solicitudes))
            .ForMember(dest => dest.Colaboradores, opt => opt.MapFrom(src => src.Colaboradores))
            .ForMember(dest => dest.SolicitudApelacion, opt => opt.MapFrom(src => src.SolicitudApelacion));

        CreateMap<Solicitudes, SolicitudEncoladoResponse>()
            .ForMember(dest => dest.so_id, opt => opt.MapFrom(src => src.so_id))
            .ForMember(dest => dest.so_numero_solicitud, opt => opt.MapFrom(src => src.so_numero_solicitud))
            .ForMember(dest => dest.so_ts_id, opt => opt.MapFrom(src => src.so_ts_id))
            .ForMember(dest => dest.so_fecha_creacion, opt => opt.MapFrom(src => src.so_fecha_creacion))
            .ForMember(dest => dest.so_es_id, opt => opt.MapFrom(src => src.so_es_id))
            .ForMember(dest => dest.so_us_id, opt => opt.MapFrom(src => src.so_us_id))
            .ForMember(dest => dest.so_url_image, opt => opt.MapFrom(src => src.so_url_image));

        CreateMap<SolicitudEncoladoResponse, Solicitudes>()
            .ForMember(dest => dest.so_id, opt => opt.MapFrom(src => src.so_id))
            .ForMember(dest => dest.so_numero_solicitud, opt => opt.MapFrom(src => src.so_numero_solicitud))
            .ForMember(dest => dest.so_ts_id, opt => opt.MapFrom(src => src.so_ts_id))
            .ForMember(dest => dest.so_fecha_creacion, opt => opt.MapFrom(src => src.so_fecha_creacion))
            .ForMember(dest => dest.so_es_id, opt => opt.MapFrom(src => src.so_es_id))
            .ForMember(dest => dest.so_us_id, opt => opt.MapFrom(src => src.so_us_id))
            .ForMember(dest => dest.so_url_image, opt => opt.MapFrom(src => src.so_url_image));

        CreateMap<IEnumerable<Solicitudes>, IEnumerable<SolicitudResponse>>()
            .ConvertUsing((src, dest, context) => src.Select(x => context.Mapper.Map<SolicitudResponse>(x)).ToList());

        CreateMap<Solicitudes, SolicitudRequest>()
            .ForMember(dest => dest.so_id, opt => opt.MapFrom(src => src.so_id))
            .ForMember(dest => dest.so_descripcion, opt => opt.MapFrom(src => src.so_descripcion))
            .ForMember(dest => dest.so_ts_id, opt => opt.MapFrom(src => src.so_ts_id));

        CreateMap<SolicitudRequest, Solicitudes>()
            .ForMember(dest => dest.so_id, opt => opt.MapFrom(src => src.so_id))
            .ForMember(dest => dest.so_descripcion, opt => opt.MapFrom(src => src.so_descripcion))
            .ForMember(dest => dest.so_ts_id, opt => opt.MapFrom(src => src.so_ts_id));

        CreateMap<SolicitudRequest, SolicitudResponse>()
            .ReverseMap();

        CreateMap<Usuarios, UsuarioResponse>().ForMember(dest => dest.us_id, opt => opt.MapFrom(src => src.us_id))
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


        CreateMap<HistoricoSolicitudRequest, HistoricoSolicitudReqDto>()
            .ReverseMap();

        CreateMap<HistoricoSolicitudResponse, HistoricoSolicitudResDto>()
            .ReverseMap();

        CreateMap<Historicos_Solicitudes, HistoricoSolicitudResponse>()
            .ForMember(dest => dest.hs_id, opt => opt.MapFrom(src => src.hs_id))
            .ForMember(dest => dest.hs_so_id, opt => opt.MapFrom(src => src.hs_so_id))
            .ForMember(dest => dest.hs_es_id, opt => opt.MapFrom(src => src.hs_es_id))
            .ForMember(dest => dest.hs_col_id, opt => opt.MapFrom(src => src.hs_col_id))
            .ForMember(dest => dest.hs_detalle, opt => opt.MapFrom(src => src.hs_detalle))
            .ForMember(dest => dest.hs_fecha, opt => opt.MapFrom(src => src.hs_fecha));

        CreateMap<Historicos_Solicitudes, HistoricoSolicitudRequest>()
            .ForMember(dest => dest.hs_so_id, opt => opt.MapFrom(src => src.hs_so_id))
            .ForMember(dest => dest.hs_es_id, opt => opt.MapFrom(src => src.hs_es_id))
            .ForMember(dest => dest.hs_col_id, opt => opt.MapFrom(src => src.hs_col_id))
            .ForMember(dest => dest.hs_detalle, opt => opt.MapFrom(src => src.hs_detalle))
            .ForMember(dest => dest.hs_fecha, opt => opt.MapFrom(src => src.hs_fecha));

        CreateMap<HistoricoSolicitudRequest, Historicos_Solicitudes>()
            .ForMember(dest => dest.hs_so_id, opt => opt.MapFrom(src => src.hs_so_id))
            .ForMember(dest => dest.hs_es_id, opt => opt.MapFrom(src => src.hs_es_id))
            .ForMember(dest => dest.hs_col_id, opt => opt.MapFrom(src => src.hs_col_id))
            .ForMember(dest => dest.hs_detalle, opt => opt.MapFrom(src => src.hs_detalle))
            .ForMember(dest => dest.hs_fecha, opt => opt.MapFrom(src => src.hs_fecha));

        CreateMap<IEnumerable<Historicos_Solicitudes>, IEnumerable<HistoricoSolicitudResponse>>()
            .ConvertUsing((src, dest, context) => src.Select(x => context.Mapper.Map<HistoricoSolicitudResponse>(x)).ToList());

    }
}
