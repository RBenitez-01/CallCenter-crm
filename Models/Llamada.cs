namespace CallCenterApi.Models;

public enum EstadoLlamada
{
    Pendiente = 0,
    Llamando = 1,
    EnCurso = 2,
    Finalizada = 3
}

public class Llamada
{
    public int Id {get; set;}
    public int ClienteId {get; set;}
    public int UsuarioId {get; set;}
    public EstadoLlamada EstadoLlamada {get; set;} = EstadoLlamada.Pendiente;
    public DateTime FechaInicio {get; set;} = DateTime.UtcNow;
    public DateTime? FechaFin {get; set;}

}