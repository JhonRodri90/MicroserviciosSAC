﻿namespace MessagingContracts;

public class UsuarioRequest : IUserCreated
{
    public int us_id { get; set; }
    public string us_nombre { get; set; }
    public string us_apellido { get; set; }
    public int us_ti_id { get; set; }
    public string us_identificacion { get; set; }
    public string us_telefono { get; set; }
    public string us_correo { get; set; }
    public int us_tu_id { get; set; }
}
