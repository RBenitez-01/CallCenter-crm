using System.Data.Common;
namespace CallCenterApi.Models;


public enum EstadoCliente
{
    Disponible = 1,
    Asignado = 2,
    Contactado = 3
}
public class Cliente
{
    public int Id {get; set;}
    public string Nombre {get; set;} = String.Empty;
    public string Telefono {get; set;} = String.Empty;
    public EstadoCliente EstadoCliente {get; set;} = EstadoCliente.Disponible;

}