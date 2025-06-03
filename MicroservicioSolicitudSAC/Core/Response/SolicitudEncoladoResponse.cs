using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Response
{
    public class SolicitudEncoladoResponse
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
    }
}
