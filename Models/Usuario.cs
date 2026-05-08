namespace CallCenterApi.Models;

public enum Rol
{
    Supervisor = 1,
    Agente = 2
}

public enum EstadoUsuario
{
    Disponible = 1,

    Ocupado = 2,

    Offline = 3,
}

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string ContrasenaHash { get; set; } = String.Empty;
    public Rol Rol { get; set; } = Rol.Agente;
    public EstadoUsuario EstadoUsuario { get; set; } = EstadoUsuario.Disponible;
}