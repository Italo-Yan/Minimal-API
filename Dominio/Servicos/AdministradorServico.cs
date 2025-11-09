using minimal_api.Dominio.Entididades;
using minimal_api.Infraestrutura.Interfaces;
using MinimalAPI.DTOs;
using MinimalAPI.Infraestrutura.DB;

namespace minimal_api.Dominio.Servicos

{
    public class AdministradorServico : IAdministradorServico
    {

        private readonly DbContexto _contexto;
        public AdministradorServico(DbContexto contexto)
        {
            _contexto = contexto;
        }
    
        public Administrador? Login(LoginDTO loginDTO)
    {
            var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Password == loginDTO.Password).FirstOrDefault();
            return adm;
    }
    }
}