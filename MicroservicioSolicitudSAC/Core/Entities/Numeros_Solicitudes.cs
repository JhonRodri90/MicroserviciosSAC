using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Numeros_Solicitudes
{
    [Key]
    public int ns_id { get; set; }
    public string ns_numero { get; set; }
    public DateTime ns_fecha_creacion { get; set; } = DateTime.Now;
}