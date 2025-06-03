﻿using Core.Entities;

namespace MicroservicioHistorialSolicitudesSAC.Dtos;

public class SolicitudResDto
{
    public int so_id { get; set; }
    public string so_numero_solicitud { get; set; }
    public int so_ts_id { get; set; }
    public string so_descripcion { get; set; }
    public DateTime so_fecha_creacion { get; set; } = DateTime.Now;
    public int so_es_id { get; set; }
    public int so_us_id { get; set; }
    public string so_url_image { get; set; }
    public int? so_col_id { get; set; }
    public string so_observaciones { get; set; }
    public string so_respuesta { get; set; }
    public DateTime so_fecha_modificacion { get; set; }
    public int? so_col_id_colaborador_modificacion { get; set; }
    public int so_so_id { get; set; }
    public Usuarios Usuarios { get; set; }
    public Tipos_Solicitudes Tipos_Solicitudes { get; set; } 
    public Estados_Solicitudes Estados_Solicitudes { get; set; }
    public Solicitudes SolicitudApelacion { get; set; }
}

