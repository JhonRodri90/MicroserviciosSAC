namespace MessagingContracts;

public interface IUserCreated
{
    int us_id { get; }
    string us_nombre { get; }
    string us_apellido { get; }
    int us_ti_id { get; }
    string us_identificacion { get; }
    string us_telefono { get; }
    string us_correo { get; }
    int us_tu_id { get; }
}
