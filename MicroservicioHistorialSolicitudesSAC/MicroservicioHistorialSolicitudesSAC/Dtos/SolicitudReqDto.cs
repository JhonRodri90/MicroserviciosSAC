﻿using Core.Entities;

public class SolicitudReqDto
{
    public int so_id { get; set; }
    public int so_ts_id { get; set; }
    public string so_descripcion { get; set; }
    public int so_es_id { get; set; }
    public int so_col_id { get; set; }
    public string so_respuesta { get; set; }
    public int so_col_id_colaborador_modificacion { get; set; }
    public int? so_so_id { get; set; }
    public Usuarios Usuario { get; set; }

}
