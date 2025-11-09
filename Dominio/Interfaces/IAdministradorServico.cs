using minimal_api.Dominio.Entididades;
using MinimalAPI.DTOs;

namespace minimal_api.Infraestrutura.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
    }
}